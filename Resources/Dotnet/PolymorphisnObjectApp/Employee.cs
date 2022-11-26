namespace HR;

public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee (string fname, string lname)
        {

            this.FirstName = fname;
            this.LastName = lname;
        }

        public override string ToString()
        {
            return FirstName + "  " + LastName;
        }
    }