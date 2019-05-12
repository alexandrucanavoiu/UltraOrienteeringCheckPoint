
//translate([0,6,0]) nano();
 //rc522();
nano();

module nano() {
    translate([0,0,0.5]) cube([18,43,1], true);

a  = 7.5;
b  = 20.5;
r = 0.7;
translate([a,b,0])
    cylinder(5,r,r,false, $fn=30);

translate([-a,-b,0])
    cylinder(5,r,r,false, $fn=30);

translate([-a,b,0])
    cylinder(5,r,r,false, $fn=30);

translate([a,-b,0])
    cylinder(5,r,r,false, $fn=30);

translate([a,b,0])
    cylinder(3,1,1,false, $fn=30);

translate([-a,-b,0])
    cylinder(3,1,1,false, $fn=30);

translate([-a,b,0])
    cylinder(3,1,1,false, $fn=30);

translate([a,-b,0])
    cylinder(3,1,1,false, $fn=30);
}

module rc522() {
    translate([17,0,0])
    cylinder(4,1.5,1.5,false, $fn=30);
    
translate([-17,0,0])
    cylinder(4,1.5,1.5,false, $fn=30);
    
translate([12.5,37,0])
    cylinder(4,1.5,1.5,false, $fn=30);    
    
translate([-12.5,37,0])
    cylinder(4,1.5,1.5,false, $fn=30);    
    
rotate([0,0,-7]) translate([-17,17,1])    
    cube([5,43,2],true);
rotate([0,0,7])  translate([17,17,1])  
    cube([5,43,2],true);
    
//translate([-15,25,0])       cube([5,15,2],false);
//translate([10,25,0])  cube([5,15,2],false);
    
translate([0,25.5,1])   
    cube([58.5,4,2],true);

translate([0,4,1])   
    cube([58.5,4,2],true);

//translate([0,6,0.4]) cube([18,43,.8], true);
}