using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    /*IMPLEMENTED IPrintable Interface*/
   interface IPrintable
    {
        void Mprint();
        
    }
   public  class Employee
    {
        
        /* Employee Class To Print IPrintable Methods*/
        public static  void Main()
        {
            Console.Write("Enter the salary of an Employee to find Food ,Petrol,Other Allowances :");
            Manager m = new Manager(Convert.ToDouble(Console.ReadLine()));

            //Console.WriteLine(m.Foodie());
            //Console.WriteLine(m.Others());
            //Console.WriteLine(m.Petrol());
            //  Console.WriteLine(m.GrossSalary());

            m.Foodie();
            m.Petrol();
            m.Others();

            m.GrossSalary();
            m.CalculateSalary();
            m.Mprint();

            Console.Write("Enter the salary of Emp to find Tele and Tour Allowances:");

            MarketingExecutive me = new MarketingExecutive(Convert.ToDouble(Console.ReadLine()));
            me.Grosssalary();
            me.CalculateSalary();
            me.Mprint();

           
        }
        
    }
    /*Manager class*/
    public  class Manager : IPrintable
    {
        private double _Petrol;
        private double _Food;
        private double _Others;
        private double sal;
        private double Gross;
        private double Netsal;
        private double Pf, TDS;
       
        public Manager(double Esalary)
        {
            sal = Esalary;

            
          //  Console.WriteLine(sal);
        }
        public void Foodie()
        {   
            _Food = sal * 0.13;
           
            //return _Food;
        }
        public void Petrol()
        {
            _Petrol = sal * 0.08;
           // return _Petrol;
        }
        public void Others()
        {
            _Others = sal * 0.03;
           
            //return _Others;
        }
        public void GrossSalary()
        {
            Gross = sal + _Food + _Petrol + _Others;
            
        }
        public  void CalculateSalary()
        {
            Pf = (Gross * 0.10);
            TDS = (Gross * 0.18);
            Netsal = Gross - (Pf + TDS);
           // Console.WriteLine("Employee Salary:" + Netsal);
            
        }

       public void Mprint()
        {
            Console.WriteLine("Emp Petrol Allowances:{0}",_Petrol);
            Console.WriteLine("Emp Food Allowances:{0}", _Food);
            Console.WriteLine("Emp Petrol Allowances:{0}", _Others);
            Console.WriteLine("Emp Gross Salary with Allowances:{0}", Gross);
            Console.WriteLine("Emp Net Salary:{0}", Netsal);
        }

    }
    /*Marketing Excutive Class*/
    public class MarketingExecutive : IPrintable
    {
        private double sal;
        private double KM;
        private double TourAllowances;
        private double TelephoneAllowances;
        private double Netsal,Pf,TDS,Gross;
        public MarketingExecutive(double Esal)
        {
            this.sal = Esal;
        }
        public void Grosssalary()
        {
            Console.Write("Enter the Total Kilometers Covered:");
            KM = Convert.ToDouble(Console.ReadLine()); 
            TourAllowances = 5 * KM;
            TelephoneAllowances = 1000;
            Gross = sal + TourAllowances + TelephoneAllowances;
           // Console.WriteLine(Gross);
        }

        public  void CalculateSalary()
        {
            Pf = (Gross * 0.10);
            TDS = (Gross * 0.18);
            Netsal = Gross - (Pf + TDS);
           // Console.WriteLine("Employee Salary:" + Netsal);

        }
      public  void Mprint()
        {
            Console.WriteLine("Emp Travel Allowances:{0}",TourAllowances);
            Console.WriteLine("Emp Telephone Allowances:{0}",TelephoneAllowances);
            Console.WriteLine("Emp Gross salary with  Allowances:{0}",Gross);
            Console.WriteLine("Emp Net Salary :{0}",Netsal);
        }

    }
}
