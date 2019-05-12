namespace Orientare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFROZEN = new System.Windows.Forms.RadioButton();
            this.rbWRITER = new System.Windows.Forms.RadioButton();
            this.rbPRINT = new System.Windows.Forms.RadioButton();
            this.rbFULL_READOUT = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rbReadout = new System.Windows.Forms.RadioButton();
            this.rbCONTROL_WITH_READOUT = new System.Windows.Forms.RadioButton();
            this.rbControl = new System.Windows.Forms.RadioButton();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtCTRL = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(12, 12);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(97, 21);
            this.cmbSerialPorts.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(799, 261);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "SET";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "GET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFROZEN);
            this.groupBox2.Controls.Add(this.rbWRITER);
            this.groupBox2.Controls.Add(this.rbPRINT);
            this.groupBox2.Controls.Add(this.rbFULL_READOUT);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.rbReadout);
            this.groupBox2.Controls.Add(this.rbCONTROL_WITH_READOUT);
            this.groupBox2.Controls.Add(this.rbControl);
            this.groupBox2.Controls.Add(this.rbClear);
            this.groupBox2.Location = new System.Drawing.Point(126, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODE";
            // 
            // rbFROZEN
            // 
            this.rbFROZEN.AutoSize = true;
            this.rbFROZEN.Location = new System.Drawing.Point(6, 166);
            this.rbFROZEN.Name = "rbFROZEN";
            this.rbFROZEN.Size = new System.Drawing.Size(127, 17);
            this.rbFROZEN.TabIndex = 7;
            this.rbFROZEN.TabStop = true;
            this.rbFROZEN.Text = "FROZEN_CONTROL";
            this.rbFROZEN.UseVisualStyleBackColor = true;
            // 
            // rbWRITER
            // 
            this.rbWRITER.AutoSize = true;
            this.rbWRITER.Location = new System.Drawing.Point(6, 145);
            this.rbWRITER.Name = "rbWRITER";
            this.rbWRITER.Size = new System.Drawing.Size(69, 17);
            this.rbWRITER.TabIndex = 6;
            this.rbWRITER.TabStop = true;
            this.rbWRITER.Text = "WRITER";
            this.rbWRITER.UseVisualStyleBackColor = true;
            // 
            // rbPRINT
            // 
            this.rbPRINT.AutoSize = true;
            this.rbPRINT.Location = new System.Drawing.Point(6, 124);
            this.rbPRINT.Name = "rbPRINT";
            this.rbPRINT.Size = new System.Drawing.Size(58, 17);
            this.rbPRINT.TabIndex = 5;
            this.rbPRINT.TabStop = true;
            this.rbPRINT.Text = "PRINT";
            this.rbPRINT.UseVisualStyleBackColor = true;
            // 
            // rbFULL_READOUT
            // 
            this.rbFULL_READOUT.AutoSize = true;
            this.rbFULL_READOUT.Location = new System.Drawing.Point(6, 103);
            this.rbFULL_READOUT.Name = "rbFULL_READOUT";
            this.rbFULL_READOUT.Size = new System.Drawing.Size(110, 17);
            this.rbFULL_READOUT.TabIndex = 4;
            this.rbFULL_READOUT.TabStop = true;
            this.rbFULL_READOUT.Text = "FULL_READOUT";
            this.rbFULL_READOUT.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(56, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 30);
            this.button6.TabIndex = 1;
            this.button6.Text = "SET";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 31);
            this.button5.TabIndex = 0;
            this.button5.Text = "GET";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rbReadout
            // 
            this.rbReadout.AutoSize = true;
            this.rbReadout.Location = new System.Drawing.Point(6, 82);
            this.rbReadout.Name = "rbReadout";
            this.rbReadout.Size = new System.Drawing.Size(78, 17);
            this.rbReadout.TabIndex = 3;
            this.rbReadout.TabStop = true;
            this.rbReadout.Text = "READOUT";
            this.rbReadout.UseVisualStyleBackColor = true;
            // 
            // rbCONTROL_WITH_READOUT
            // 
            this.rbCONTROL_WITH_READOUT.AutoSize = true;
            this.rbCONTROL_WITH_READOUT.Location = new System.Drawing.Point(6, 61);
            this.rbCONTROL_WITH_READOUT.Name = "rbCONTROL_WITH_READOUT";
            this.rbCONTROL_WITH_READOUT.Size = new System.Drawing.Size(171, 17);
            this.rbCONTROL_WITH_READOUT.TabIndex = 2;
            this.rbCONTROL_WITH_READOUT.TabStop = true;
            this.rbCONTROL_WITH_READOUT.Text = "CONTROL_WITH_READOUT";
            this.rbCONTROL_WITH_READOUT.UseVisualStyleBackColor = true;
            // 
            // rbControl
            // 
            this.rbControl.AutoSize = true;
            this.rbControl.Location = new System.Drawing.Point(6, 40);
            this.rbControl.Name = "rbControl";
            this.rbControl.Size = new System.Drawing.Size(77, 17);
            this.rbControl.TabIndex = 1;
            this.rbControl.TabStop = true;
            this.rbControl.Text = "CONTROL";
            this.rbControl.UseVisualStyleBackColor = true;
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(6, 19);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(60, 17);
            this.rbClear.TabIndex = 0;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "CLEAR";
            this.rbClear.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.txtCTRL);
            this.groupBox3.Location = new System.Drawing.Point(16, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 88);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CTRL";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(58, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "SET";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 31);
            this.button7.TabIndex = 0;
            this.button7.Text = "GET";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtCTRL
            // 
            this.txtCTRL.Location = new System.Drawing.Point(7, 19);
            this.txtCTRL.Name = "txtCTRL";
            this.txtCTRL.Size = new System.Drawing.Size(92, 20);
            this.txtCTRL.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.btnRESET);
            this.groupBox4.Location = new System.Drawing.Point(324, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 78);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Backup";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "GET DATA";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(6, 20);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(75, 23);
            this.btnRESET.TabIndex = 0;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(278, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "File";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "D:\\stafeta\\Stafeta_log3.txt";
            this.saveFileDialog1.InitialDirectory = "d:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 546);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSerialPorts);
            this.Name = "Form1";
            this.Text = "Orientare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton rbReadout;
        private System.Windows.Forms.RadioButton rbCONTROL_WITH_READOUT;
        private System.Windows.Forms.RadioButton rbControl;
        private System.Windows.Forms.RadioButton rbClear;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtCTRL;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton rbFROZEN;
        private System.Windows.Forms.RadioButton rbWRITER;
        private System.Windows.Forms.RadioButton rbPRINT;
        private System.Windows.Forms.RadioButton rbFULL_READOUT;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

