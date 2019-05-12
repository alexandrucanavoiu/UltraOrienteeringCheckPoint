translate([0,0,0.5]) cube([17.5,43,1], true);

a  = 7.5;
b  = 20.5;
translate([a,b,0])
    cylinder(5,0.55,0.5,false, $fn=30);

translate([-a,-b,0])
    cylinder(5,0.55,0.5,false, $fn=30);

translate([-a,b,0])
    cylinder(5,0.55,0.5,false, $fn=30);

translate([a,-b,0])
    cylinder(5,0.55,0.5,false, $fn=30);

translate([a,b,0])
    cylinder(3,1,1,false, $fn=30);

translate([-a,-b,0])
    cylinder(3,1,1,false, $fn=30);

translate([-a,b,0])
    cylinder(3,1,1,false, $fn=30);

translate([a,-b,0])
    cylinder(3,1,1,false, $fn=30);
