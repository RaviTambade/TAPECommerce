namespace Collections{
 class Stack : ICloneable {
        int size;
        int[] sArr;

        public Stack(int val1, int val2, int val3)
        {
        }
        public Stack(int s) : this()
        {
            size = s;
            sArr = new int[size];
        }

        public Stack() : this(45, 56, 78)
        {
            Console.WriteLine("Default constructor is called!");
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    throw new ArgumentException("index is not in range of size");
                else
                    return sArr[index];
            }
            set
            {
                if (index < 0 || index >= size)
                    throw new ArgumentException("index is not in range of size");
                else
                    sArr[index] = value;
            }
        }


        public object Clone()
        {
            //deep copy implementation  need to be explicity set 
            Stack s = new Stack(this.size);
            this.sArr.CopyTo(s.sArr, 0);
            return s;
        }
    }

}