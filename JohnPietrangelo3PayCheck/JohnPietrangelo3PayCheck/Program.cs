//John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo3PayCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string myID = "123";
            string name = "! STOP PAYMENT !";
            string id = "";

            double hrsWorked = 0;
            double overTimeWorked = 0;
            double payRate = 0;
            double overTimePayRate = 0;
           
            double federalTax, 
                   stateTax,
                   grossPay,
                   netPay;

            bool validEntery = true;
            
                                                            // Using Do/While Statement.
            do
            {
                                                                //To Print Logo.
                Console.WriteLine();
                Console.WriteLine("     JJJ    JJJ  pPp");
                Console.WriteLine("      j      j   P  P");
                Console.WriteLine("   j  j   j  j   PpP");
                Console.WriteLine("   JjjJ   JjjJ   P");
                Console.WriteLine();
                Console.WriteLine("-----------------------");

                                                         //To get Input Data From User.
                
                Console.Write("What is your ID number? ");
                id = Console.ReadLine();
                                                        /* Else/If Statement.
                                                     To Verify & Validate ID.*/
                if (myID == id)
                {
                    name = "John Pietrangelo";
                    payRate = 10.00;
                    hrsWorked = 50;
                }

                else if (id.Length == 3)
                {
                    Console.Write("\nWhat is Your Name?      ");
                    name = Console.ReadLine();

                    Console.Write("\nWhat is your pay rate?  ");
                    payRate = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nEnter hours worked.     ");
                    hrsWorked = Convert.ToDouble(Console.ReadLine());
                }

                else
                {

                    validEntery = !validEntery;
                    Console.Write("\nInvalid entry!!! \nRe-enter Id number.\n\n");

                    System.Threading.Thread.Sleep(1500);
                    //Console.ReadKey();
                    Console.Clear();

                }
            } while (validEntery = !validEntery);

            //Calculate Pay, OverTime Pay and Tax
            if (hrsWorked > 40)
            {
                overTimeWorked = hrsWorked - 40;
                overTimePayRate = (payRate * 1.5);
                grossPay = (((hrsWorked - overTimeWorked) * payRate) + (overTimeWorked * overTimePayRate));
            }
            else
            {
                grossPay = (hrsWorked * payRate);
            }

            federalTax = (grossPay * .25);
            stateTax = (grossPay * .03);
            netPay = (grossPay - (federalTax + stateTax));

            //Display Formatted check
            Console.Clear();
            Console.WriteLine("\t\t   JJJ    JJJ  pPp");
            Console.WriteLine("\t\t    j      j   P  P");
            Console.WriteLine("\t\t j  j   j  j   PpP");
            Console.WriteLine("\t\t JjjJ   JjjJ   P");
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>>>>>>>>>>Pay Check Summary<<<<<<<<<<<<<<<<");
            Console.WriteLine();
            Console.WriteLine("Employee Name: {0}{1,17}", name, "ID: " + id);
            Console.WriteLine();
            Console.WriteLine("Regular Hours Worked is:     " + (hrsWorked - overTimeWorked) + "  at " + payRate + "  Per Hour");
            if (overTimeWorked > 0)
            {
                Console.WriteLine("Over Time Hours Worked is:   " + overTimeWorked + "  at " + overTimePayRate + "  Per Hour");
            }
            Console.WriteLine();
            Console.WriteLine("Taxes:   Federal - 25%  \t      State - 3%");
            Console.WriteLine();
            Console.WriteLine("Gross Pay:\t\t\t      {0,10:C}", grossPay);
            Console.WriteLine("Less -");
            Console.WriteLine("Federal WithHolding:\t\t      {0,10:C}", federalTax);
            Console.WriteLine("State Withholding:\t\t      {0,10:C}", stateTax);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Net Pay:\t\t\t      {0,10:C}", netPay);
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine();
            //Pause display before exiting
            Console.WriteLine("Press any Key To Exit");

            Console.Read();
            
            //int[] n = new int[10]; /* n is an array of 10 integers */
            //int i, j;

            ///* initialize elements of array n */
            //for (i = 0; i < 10; i++)
            //{
            //    n[i] = i + 100;
            //}

            ///* output each array element's value */
            //for (j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
               
            //}
    //       do
    //{
	         
    //} while (true);
            
        }
    }
}
