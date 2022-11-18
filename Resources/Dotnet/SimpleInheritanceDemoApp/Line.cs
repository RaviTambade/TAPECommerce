namespace GDI
{
    public class Line : Shape
    {

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Line():base()
        {
            this.StartPoint=new Point { X=0, Y=0 };
            this.EndPoint = new Point { X = 0, Y = 0 };
            //this.Color = "red";

        }


        public Line(Point pt1, Point pt2, string color):base(color)
        {
            this.StartPoint=pt1;
            this.EndPoint=pt2;
            this.Color=color;
        }
        public override  void Draw()
        {
            Console.WriteLine("StartPoint={0}, {1}, EndPoint= {2},{3} , Color={4}",
                StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y, Color);
           
        }
    }
}
