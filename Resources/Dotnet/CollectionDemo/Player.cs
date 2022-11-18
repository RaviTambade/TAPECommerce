using System.Collections;
 public class Player : IComparable
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public Player(string name, int runs)
        {
            this.Name = name;
            this.Runs = runs;
        }
        public int CompareTo(object obj)
        {
            Player temp = (Player)obj;
            if (this.Runs > temp.Runs)
                return 1;
            if (this.Runs < temp.Runs)
                return -1;
            else
                return 0;
        }
}