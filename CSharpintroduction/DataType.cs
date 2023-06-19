using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpintroduction
{
    class DataType 
    {
        static void Main(string[] args)
        {
            Main1();
            int value = 2147483647;//int datatype 
            Console.WriteLine(value);
            Console.ReadLine();
        }
        static void Main1()
        {
            ////bool-true or false not accepting numbers 
            ////char- single character

            //long  value1 = 9223372036854775807;//long datatype
            //Console.WriteLine(value1);

            //char seat= 's';
            //Console.WriteLine(seat);


            //int i = 623;//implicit conversion 
            //float f = i;
            //Console.WriteLine(f);

            //float f1 = 482.22F;//explicit conversion type 1
            //int i1 = (int)f1;
            //Console.WriteLine(i1);

            ////float f2 = 4824684283868.22F;//explicit conversion type2 (error exception cannot handle bcz when converting float to int we loose the fractional part)
            ////int i2 = Convert.ToInt32(f2);
            ////Console.WriteLine(i2);

            ////Parse &TryParse

            //string strNumber = "300";
            //int i4 = int.Parse(strNumber);
            //Console.WriteLine(i4);

            ////try parse we use bcz if string type we dont know whether number or name 

            //string strNumber1 = "300fhd";
            //int Result = 0;
            //bool isSuccessful = int.TryParse(strNumber1, out Result);

            //if (isSuccessful)
            //{
            //    Console.WriteLine(Result);
            //}

            //else
            //{
            //    Console.WriteLine("Please enter valid number");
            //}

            //Console.WriteLine("please enter your name");//console writ in for name 
            //string name = Console.ReadLine();

            //Console.WriteLine("your name is " + name);



            //Console.WriteLine("please enter your age");//console write for age 
            //int age  = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("your name is " + name);
            //Console.WriteLine("your age  is {0} ",  age);//{0} this indicate placeholder
            //Console.WriteLine("your age is {0},{1}",age,name);//To print both age and name 


            ////Assignment Operators = 
            ////arithmetic operators (+,-,*,/,%)
            ////Comparsion operators (==,!=,>,<=,>=,<,)
            ////conditional operators (&&,||)


            //// string will convert into integer by using (Convert.ToInt32)



            //IF ELSE STATEMENT
            //Console.WriteLine("please enter your number");
            //int inputnumber = Convert.ToInt32(Console.ReadLine());

            //if (inputnumber == 101)
            //{
            //    Console.WriteLine("your number is {0}", inputnumber);
            //}
            //else if (inputnumber == 102)
            //{
            //    Console.WriteLine("your number is {0}", inputnumber);
            //}
            //else if (inputnumber == 103)
            //{
            //    Console.WriteLine("your number is {0}", inputnumber);
            //}
            //else if (inputnumber == 104)
            //{
            //    Console.WriteLine("your number is {0}", inputnumber);
            //}




            // While loop in c#

            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
                
            //Console.ReadLine();



            int i = 1; ;
            while (i < 10)
            {
                if(i==5)
                {
                    break;//we use break to stop were we want to stop the loop
                }
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();





        }
    }
}