namespace GDI;

/**
*!Mother of all classes is Object class
*!ToString() method is inherited to classes because of Object parent class
*/
public class Point {

/**
 *!Auto Property
 *! They are used to store X and Y co ordinate value
*/


   //Normal Property
   /* private int x;
    public int X {
            get{return this.x;}
            set{this.x=value;}
    }
  */


    //Auto Property
    public int X {get;set;}
    public int Y {get;set;}


  //Change default  behaviour of an object by overriding ToString method
    public override string ToString()
    {
        string strData="X ="+ this.X + ", Y="+this.Y;
        return strData ;
    }
}