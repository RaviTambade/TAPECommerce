namespace  Collections 
 {
    public class DataManager{
        static void DemoRectangularArray()
        {
            int[,] mtrx = new int[2, 3] {
                                            { 10, 20, 30 },
                                            { 40, 50, 60 }
            };

         Console.WriteLine("Rectangule Array Elements");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
            }
        }

        static void DemoJaggedArray()
        {
            object[][] mtrxjagged = new object[3][];

            mtrxjagged[0] = new object[] { "Rajan", "Ganesh" };
            mtrxjagged[1] = new object[] { 56, 45, 999 };
            mtrxjagged[2] = new object[] { new DateTime(2018, 12, 7), 45.56, true, "Hitesh" };

            Console.WriteLine("\n\n\n Jagged Array Elements\n");
            for (int i = 0; i < mtrxjagged.Length; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < mtrxjagged[i].Length; j++)
                {
                    Console.Write(mtrxjagged[i][j] + "\t");
                }
            }
        }
    }
 }