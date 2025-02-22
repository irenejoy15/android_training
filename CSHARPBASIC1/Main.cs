using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPBASIC1
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.Write("-------C# Primitves---------");
            //Camel Case sa Variable
            //Pascal = void ComputeSalary
            //string firstName = "";
            //string lastName = "";
            //string discountMessage = string.Empty;
            //bool isSingle = false;
            //int Age = 0;
            ////Lagyan ang M sa Decimal
            //decimal dailyRate = 500.45234332423m;
            //int workDays = 30;
            ////
            //decimal salary = workDays * dailyRate;
            //decimal allowance = 500;
            //decimal deductions = 1000;
            //int salaryWithAllowance = (Convert.ToInt32(salary * dailyRate)- Convert.ToInt32(deductions));
            ////
            //Console.Write("Enter your name ");
            //firstName = Console.ReadLine();


            //Console.Write("Enter your last name ");
            //lastName = Console.ReadLine();

            //Console.Write("Enter your Age ");
            //string tempAge = Console.ReadLine();
            //Age = Convert.ToInt32(tempAge);

            //if (Age >= 60) {
            //    discountMessage = " Senior Discount is 30%";
            //}
            //else if(Age >= 19 &&  Age < 59){
            //    string discountPercentage = "10";
            //    Console.Write("Enter Discount: ");
            //    discountPercentage = Console.ReadLine();
            //    discountMessage = $"with {discountPercentage}% discount";
            //}
            //else{
            //    discountMessage = "no Discount";
            //}
                

            // Console.WriteLine("Hello " + firstName+ "  " + lastName + " Age: " + Age + " Rate: " + dailyRate + " Salary For Jan " + salaryWithAllowance + ' ' +discountMessage);
            Console.Write("-------C# Collections---------");
            List<string> productList= new List<string>()
            {
                "Kojic","Toner","Sunblock"
            };

            Console.WriteLine("Record 2: "+ productList[1]);
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"Record:{i} = " + productList[i]);
            }
            Console.Write("-------C# Array List---------");

            ArrayList employee = new ArrayList();

            employee.Add("IRENE");
            employee.Add("CEF");
            employee.Add("JIJOY");
            employee.Add(1000.56);

            for (int i = 0;i < employee.Count; i++)
            {
                Console.WriteLine($"Employee: {i}= "+ employee[i]);
            }
            Console.WriteLine($"Employee #2 "+ employee[0]);

            Console.Write("-------C# Dictionary---------");

            Dictionary<int, string> category = new Dictionary<int, string>();
            category.Add(1, "Electronics");
            category.Add(2, "Electronics 2");
            category.Add(3, "PS5");
            category.Add(4, "PS4");

            for (int y = 1; y < category.Count; y++) {
                Console.WriteLine($"category: {y}= " + category[y]);
            }

            Console.WriteLine($"category: 3= " + category[3]);
            Console.Write("-------C# Anonymous---------");

            var supplier = new { Id = 1, Company = "ZYA", Contact = "IRENE", };
            //var name = "asasa";
            //var n1 = 1000.32m;

            Console.WriteLine(supplier);
            var product = new { 
                Id = 1, 
                Company = "ZYA", 
                Supplier1 = new {id=1,supplier_name="irene"}, 
            };
            Console.WriteLine(product.Supplier1.supplier_name);

            Console.Write("-------C# OOP---------");
            //Instantiate
            Product product1 = new Product();
            Product product2 = new Product();
            //
            Order order1 = new Order();
            Order order2 = new Order();

            product1.Id = 1;
            product1.Name = "PS4";


            product2.Id = 2;
            product2.Name = "PS5";

            product1.Price = 1000.50m;
            var sellingPrice1 = product1.ComputeSellingPrice(500.40m);
            order1.Quantity = 40;
            var totalOrder1 = order1.ComputeTotalOrder(sellingPrice1);

            order2.Quantity = 50;
            product2.Price = 2000.50m;
            var sellingPrice2 = product2.ComputeSellingPrice(1500.40m);
            var totalOrder2 = order2.ComputeTotalOrder(sellingPrice2);



            Console.WriteLine(product1.Name+" selling price = "+sellingPrice1+ "Order Price " + totalOrder1);
            Console.WriteLine(product2.Name+" selling price = "+sellingPrice2 + "Order Price " + totalOrder2);
        }
    }
}
