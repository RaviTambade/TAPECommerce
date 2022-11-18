 
 using GDI;
 
 Shape shape = new Line();
 shape.Draw();

 Point pt1= new Point{ X=23 ,Y=89};
 Point pt2= new Point{ X=100, Y=300};
 string theColor="red";
 Shape shape2=new Line(pt1, pt2, theColor);

 shape2.Draw();