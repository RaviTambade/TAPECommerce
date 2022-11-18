namespace GDI
{
    public  abstract class Shape
    {
        public Shape()
        {
            this.Color = "red";
        }
        public Shape(string color)
        {
            this.Color = color;
        }
        public string Color { get; set; }
        public abstract void Draw();
       
        public void Show()
        {
            Console.WriteLine("Showing shape on canvas..");
        }
    }
}
