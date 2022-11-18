namespace GDI;


/**
*!Child Parent relationship
*!Child Class: Line
*!Parent Class :Shape
*/


/**
*!Class Relationship ( association , inheritance)
*!All protected data members of parent class can be used in child class
*!Line is a Shape   (inheritance)
*!Line has  a Point (association)

*/
public class Line:Shape{

/**
*! Data members :2 
*/

private Point startPoint;
private Point endPoint;
public Line(){
    this.startPoint=new Point();
    this.startPoint.X=0;
    this.startPoint.Y=0;
    this.endPoint=new Point();
    this.endPoint.X=0;
    this.endPoint.Y=0;
    this.color="blue";
}

public Line(Point pt1, Point pt2,string c){
    this.startPoint=pt1;
    this.endPoint=pt2;
    this.color=c;
}



//method overriding

public override string ToString()
{
    string strStartPoint=this.startPoint.ToString();
    string strEndPoint=this.endPoint.ToString();
    string data=string.Format( "("+strStartPoint + "),( "+ strEndPoint + ") , "+ this.color);
    return data;
  //  return base.ToString();
}



}