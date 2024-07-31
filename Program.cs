namespace Class_obj_june_310724
{
     class classAA //internal
    {
        public void method1()
        {
            Student ss=new Student();
            //ss.id = 2343;//invalid
            ss.interVar = 23;//valid
        }
            
    }
   public class Student
    {
        private int id; 
        private String name;
        private float per;
        private int totalFees;
        private int disFees;
        private int actualPaidFees;
        public int interVar;

        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public void display()
        {
            interVar = 89798;
            Console.WriteLine("display called from Class_obj_june_310724#####");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Per
        {
            get { return per; }
            set { per = value; }
        }
        public int TotalFees
        {
            get { return totalFees; }
            set { totalFees = value; }
        }
        public int ActualPaidFees
        {
            get { return actualPaidFees; }
            set { actualPaidFees = value; }
        }
        public int DissFees
        {
            get { return disFees; }
            set { disFees = value; }
        }

    }

    class GTHStudent:Student
    {
        public void method2()
        {
            interVar = 8798;
        }
    }
    class DiscountFees
    {
        private Student s;

        
        public void setStudent(Student st)
        {           
            s = st;
        }
        public void checkDiscountEligibility()
        {
            s.DissFees = 0;
            if (s.Per>60)//89
            {
                
                s.DissFees = (int)(s.TotalFees * 0.30);   // 30000
              
            }
            s.ActualPaidFees = s.TotalFees - s.DissFees;
        }
        public void show()
        {
            Console.WriteLine("-----student Information ----");
            Console.WriteLine("ID : "+s.ID);
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Per: " + s.Per);
            Console.WriteLine("Total Fees: " + s.TotalFees);
            Console.WriteLine("Discount Fees: " + s.DissFees);
            Console.WriteLine("Actual Paid Fees: " + s.ActualPaidFees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student ();
            s1.ID = 1;
            s1.Name = "rajesh";
            s1.Per = 89;
            s1.TotalFees = 213215;

            DiscountFees df = new DiscountFees();
            df.setStudent(s1);
            df.checkDiscountEligibility();
            df.show();
            Console.ReadKey();
        }
    }
}
