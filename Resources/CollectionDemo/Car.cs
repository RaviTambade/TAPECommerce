using System.Collection;
namespace Collections
{
    public class car : IComparable
    {

        public int year;
        public string make;
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public car(string make, int year)
        {
            this.make = make;
            this.year = year;


        }

        public int CompareTo(object obj)
        {
            car secondCar = (car)obj;
            if ( year > secondCar.year)
                return 1;

            if ( year < secondCar.year)
                return -1;

            else
                return 0;
        }


        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            car c = (car)obj;
            return String.Compare(this.make, c.make);
        }

        // Method to return IComparer object for sort helper.
        public static IComparer<car> sortYearAscending()
        {
            return (IComparer<car>)new sortYearAscendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer<car> sortYearDescending()
        {
            return (IComparer<car>)new sortYearDescendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer<car> sortMakeDescending()
        {
            return (IComparer<car>)new sortMakeDescendingHelper();
        }

    }



    public  class sortYearAscendingHelper : IComparer<car>
        {
        public int Compare(car x, car y)
        {
            if (x.year > y.year)
                return 1;

            if (x.year < y.year)
                return -1;

            else
                return 0;
        }

       
        }
  


    public class sortYearDescendingHelper : IComparer<car>
    {
        public int Compare(car a, car b)
        {
            car c1 = (car)a;
            car c2 = (car)b;

            if (c1.year < c2.year)
                return 1;

            if (c1.year > c2.year)
                return -1;

            else
                return 0;
        }

       
    }



   public class sortMakeDescendingHelper : IComparer<car>
    {
        public int Compare(car a, car b)
        {
            car c1 = (car)a;
            car c2 = (car)b;
            return String.Compare(c2.make, c1.make);
        }

        
    }

}

