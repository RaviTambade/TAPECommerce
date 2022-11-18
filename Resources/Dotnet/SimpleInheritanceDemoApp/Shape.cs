namespace GDI
{
    //Two types of classess according to Hiearchy


    //1.Aoncrete class
    //you can create instance from a class

    //2.Abstract class
    //you can not create instance from a class
    //but you can use for polymorphism
    //abstract class consist of atleast one method abstract method

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


        //abstract keyword enforces overriding method in child classes
       public abstract void Draw();
       
       //virtual method may or many get overrided in their child classes

        public void Show()
        {
            Console.WriteLine("Showing shape on canvas..");
        }
    }
}
