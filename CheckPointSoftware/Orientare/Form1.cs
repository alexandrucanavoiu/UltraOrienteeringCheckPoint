using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Orientare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSerialPorts.DataSource = SerialPort.GetPortNames();
            cmbSerialPorts.SelectedItem = "COM7";
             //serialPort1.PortName = "COM7";
            //serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.SelectedIndex > -1)
            {
                //MessageBox.Show(String.Format("You selected port '{0}'", cmbSerialPorts.SelectedItem));
                serialPort1.PortName = cmbSerialPorts.SelectedItem.ToString();

                try
                {
                    serialPort1.Open();
                }
                catch { Exception ex; }
                finally
                {
                    if (serialPort1 != null)
                    {
                        if (serialPort1.IsOpen)
                        {
                            richTextBox1.AppendText(serialPort1.PortName + " port opened.\n");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            richTextBox1.Text = "Serial Port CLOSED.\n";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("GET TIME");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string txt = serialPort1.ReadExisting().ToString();
            SetText(txt.ToString());
            if (txt.StartsWith("\r\nMode:"))
            {
                string mode = txt.Replace("\r\n", "").Replace("Mode:", "").Replace(">", "");
                SetMODE(mode);
                //SetText(" ---- mode -----" +  mode  );
                //rbControl.Select();
            }
            if (txt.StartsWith("\r\nTime:"))
            {
                //string mode = txt.Replace("\r\n", "").Replace("Mode:", "").Replace(">", "");
                
                SetText(serialPort1.ReadTo(">").ToString());
                SetText("Time:           " + DateTime.Now.ToString("yyyy\\/MM\\/dd HH:mm:ss"));
                //SetText(" ---- mode -----" +  mode  );
                //rbControl.Select();
            }

            if (txt.StartsWith("\r\nControl:"))
            {
                string ctrl = txt.Replace("\r\n", "").Replace("Control:", "").Replace(">", "");
                SetCTRL(ctrl);
                //SetText(" ---- mode -----" +  mode  );
                //rbControl.Select();
            }

            if ( txt.StartsWith("Card:") && rbReadout.Checked) //
            {
                //SetText("\nSTART\n");
                //txt=txt.Replace("^37,", "Card:");
                using (System.IO.StreamWriter file =
                //new System.IO.StreamWriter(@"D:\Stafeta_log.txt", true))
                new System.IO.StreamWriter(saveFileDialog1.FileName, true))
                {
                   // file.Write(txt);
                }
                if (!txt.EndsWith(",") || !txt.EndsWith("%")) txt += serialPort1.ReadTo("%").ToString();
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(saveFileDialog1.FileName, true))
                {
                    file.WriteLine(txt+"%\n");
                }
                string[] stringSeparators = new string[] { "\r\n" };
                string[] tmp = txt.Split(stringSeparators, StringSplitOptions.None);
                string[] parts = tmp[1].Split(',');
                SetText(tmp[1] + "%\n");
                int start=0, finish=0;
                for (int i=0;i<parts.Count(); i=i+2) {
                    if(parts[i] == "252")
                    {
                        finish = Convert.ToInt32(parts[i+1]);
                    }
                    if(parts[i] == "251")
                    {
                        start = Convert.ToInt32(parts[i+1]);
                    }
                }
                TimeSpan t = TimeSpan.FromSeconds(finish - start);

                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                                t.Hours,
                                t.Minutes,
                                t.Seconds);
                SetText("\nTotal: " + (finish - start).ToString()+ "seconds - " + answer);
                //SetText("\nSTOP\n");
                //writeToFile = true;
            } 



        }

        delegate void SetTextCallback(string text);
        delegate void SetModeCallback(string text);
        delegate void SetCTRLCallback(string text);
        private void SetCTRL(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtCTRL.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetCTRL);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtCTRL.Text = text;
            }
        }
        private void SetMODE(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.groupBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMODE);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Controls.Find("rb" + text.Trim(), true)[0].Select();
            }
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text);
                this.richTextBox1.ScrollToCaret();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("SET TIME " + DateTime.Now.ToString("yyyyMMddHHmmss"));
            //richTextBox1.AppendText("SET TIME " + DateTime.Now.ToString("yyyyMMddHHmmss") + "\n");
            //Time:1937044895,2031/05/20 12:01:35
            //> SET TIME YYYY05DD120139        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("GET MODE");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //richTextBox1.AppendText("SET MODE "+ groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + "\n");
            serialPort1.WriteLine("SET MODE " + groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("GET CTRL");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //richTextBox1.AppendText("SET MODE "+ groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text + "\n");
            serialPort1.WriteLine("SET CTRL " + txtCTRL.Text);
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("SET RESET_BACKUP");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("GET BACKUP");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
