using System;

class Practice
{
    // static void Main(String[] args)
    // {
    //     // 1. Write a C# program to check whether a year is leap year or not  
    //     for(int year = 2000;year<=2100;year++)
    //     {
    //         if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    //         {
    //             Console.WriteLine(year);
    //         }

    //     }
    // }

    // static void Main(String[] args)
    // {
    //     // 2. Write a C# program to check whether a number is divisible by 5 and 11 or not  
    //     int num = 55;

    //     if(num % 5 == 0  && num % 11 == 0)
    //     {
    //         Console.WriteLine($"{num} is divisible by 5 and 11");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{num} is not divisible by 5 and 11");
    //     }
    // }

    // static void Main(String[] args)
    // {
    //     // 3. Write a C# program to find maximum between three numbers  
    //     int a = 30;
    //     int b = 20;
    //     int c = 35;

    //     if(a > b && a > c)
    //     {
    //         Console.WriteLine($"{a} is greater");
    //     }
    //     else if(b > a)
    //     {
    //         Console.WriteLine($"{b} is greater");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{c} is greater");
    //     }
    // }

    // static void Main(String[] args)
    // {
    //     // 4. Write a C# program to input any alphabet and check whether it is vowel or consonant  
    //     char ch = 'z';
    //     if(ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
    //     {
    //         Console.WriteLine($"{ch} is vowel");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{ch} is consonant");
    //     }
    // }

    // static void Main(String[] args)
    // {
    //     // 5. Write a C# program to create Simple Calculator   
    //     int num1 = 10;
    //     int num2 = 5;
    //     String operation = "/";

    //     switch (operation)
    //     {
    //         case "+":
    //         Console.WriteLine($"Addition = {num1 + num2}");
    //         break;

    //         case "-":
    //         Console.WriteLine($"Substraction = {num1 - num2}");
    //         break;

    //         case "*":
    //         Console.WriteLine($"Multiplication = {num1 * num2}");
    //         break;

    //         case "/":
    //         Console.WriteLine($"Division = {num1 / num2}");
    //         break;
    //         default:
    //         Console.WriteLine("Incorrect operator");
    //         break;
    //     }

    // }


        // static void Main(string[] args)
        // {
        //     // 6. Write a C# program to check whether a number is negative, positive or zero  

        //     int num = -1;

        //     if(num > 0)
        //     {
        //         Console.WriteLine($"{num} is positive");
        //     }
        //     else if(num < 0)
        //     {
        //         Console.WriteLine($"{num} is negative");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Zero");
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 7. Write a C# program to input any character and check whether it is alphabet, digit or special character  
        //     char ch = 'R';
        //     if(ch >= '0' && ch <= '9')
        //     {
        //         Console.WriteLine($"{ch} is digit");
        //     }
        //     else if(ch == '@' || ch == '$' || ch == '&' || ch == '!')
        //     {
        //         Console.WriteLine($"{ch} is special character");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{ch} is alphabet");
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 8. Write a C# program to check whether a number is even or odd   
        //     int num = 11;
        //     if(num % 2 == 0)
        //     {
        //         Console.WriteLine($"{num} is even number");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{num} is odd number");
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 9. Write a C# program print total number of days in a month  
        //     String month = "january";
        //     switch (month)
        //     {
        //         case "january":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "february":
        //         Console.WriteLine($"{month} has 28 days");
        //         break;

        //         case "march":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "april":
        //         Console.WriteLine($"{month} has 30 days");
        //         break;

        //         case "may":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "june":
        //         Console.WriteLine($"{month} has 30 days");
        //         break;

        //         case "july":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "august":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "september":
        //         Console.WriteLine($"{month} has 30 days");
        //         break;

        //         case "october":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;

        //         case "november":
        //         Console.WriteLine($"{month} has 30 days");
        //         break;

        //         case "december":
        //         Console.WriteLine($"{month} has 31 days");
        //         break;
        //         default:
        //         Console.WriteLine("Invalid input");
        //         break;
        //     }
        // }


        // static void Main(string[] args)
        // {
        //     // 10. Write a C# program to input basic salary of an employee and calculate its  
        //     // Gross salary according to following: Basic Salary <= 10000 : HRA = 20%, DA = 80% Basic Salary <= 20000 : HRA = 25%, 
        //     // DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95%  

        //     Console.WriteLine("Enter Salary");
        //     double sal = Convert.ToDouble(Console.ReadLine());
        //     double hra = 0;
        //     double da = 0;
        //     double gross = 0;
        //     if(sal <= 10000)
        //     {
        //         hra = sal * 0.2;
        //         da = sal * 0.8;
        //         gross = sal + hra + da;
        //         Console.WriteLine(gross);   
        //     }
        //     else if(sal <= 20000)
        //     {
        //         hra = sal * 0.25;
        //         da = sal * 0.9;
        //         gross = sal + hra + da;
        //         Console.WriteLine(gross);      
        //     }
        //     else
        //     {
        //         hra = sal * 0.3;
        //         da = sal * 0.95;
        //         gross = sal + hra + da;
        //         Console.WriteLine(gross);     
        //     }
        // }


        // -------- Loop Programs ----------
        
        // static void Main(string[] args)
        // {
        //     // 1.  Display numbers from 1 to 100. 
        //     for(int i=1;i<=100;i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }


        // static void Main(string[] args)
        // {
        //     // 2.  Display all even numbers from 1 to 100. 

        //         for(int i=1;i<=100;i++)
        //     {
        //         if(i%2 == 0)
        //         {
        //         Console.WriteLine(i);
        //         }
        //     }
        // }


        // static void Main(string[] args)
        // {
        //     // 3.  Display all odd numbers from 200 to 300. 
        //      for(int i=200;i<=300;i++)
        //     {
        //         if(i%2 != 0)
        //         {
        //         Console.WriteLine(i);
        //         }
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 4.  Display the seventh element between 400 to 500 (both numbers excluded). 
        //     for(int i=400;i<500;i+=7)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }


        // static void Main(string[] args)
        // {
        //     // 5.  Find the first 10 even numbers. 
        //     int count = 0;
        //     for(int i=1;i<100;i++)
        //     {
        //         if(count < 10)
        //         {
        //             if(i % 2 == 0) 
        //             {
        //                 Console.WriteLine(i);
        //                 count++;
        //             } 
        //         }
        //     }
        // }


        // static void Main(string[] args)
        // {
        //     // 6.  Find all prime numbers < 100. 
        //     int count = 0;
        //     for(int i=1;i<100;i++)
        //     {
        //         count = 0;
        //         for(int j=2;j<i;j++)
        //         {
        //             if(i%j == 0)
        //             {
        //                 count++;
        //             }
        //         } 
        //         // Console.WriteLine(count);
        //         if(i == 1)
        //         {
        //             continue;
        //         }
        //         else if(count == 0)
        //         {
        //             Console.WriteLine(i);
        //         }             
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     // 7.  Calculate factorial of a number. 
        //     int num = 5;
        //     int factorial = 1;
        //     for(int i = num;i>0;i--)
        //     {
        //         factorial = factorial * i;
        //     }
        //     Console.WriteLine(factorial);
        // }

        // public static void Main(string[] args) 
        // {
        //     // 8.  Count the number of digits in any number. 
        //     int num = 1;
        //     int count = 0;
        //     while(num > 0)
        //     {
        //         num/=10;
        //         count++;
        //     }
        //     Console.WriteLine(count);
        // } 

        // public static void Main(string[] args)
        // {
        //     // 11.  Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ..... k. where k < n . n is entered by user 
        //         int num1 = 0;
        //         int num2 = 1;
        //         int num3 = 0;
        //         Console.Write(num1+","+num2);
        //     for(int i = 3; i < 8;i++)
        //     {
        //         num3 = num1+num2;
        //         Console.Write(","+num3);
        //         num1 = num2;
        //         num2 = num3;
        //     }
        // }  

        // public static void Main(string[] args)
        // {
        //     // 12.  Find the sum of all digits of a number. 
        //     int num = 121;
        //     int sum = 0;
        //     while(num>0)
        //     {
        //         int digit = num % 10;
        //         sum+=digit;
        //         num/=10;
        //     }
        //     Console.WriteLine(sum);
        // }

        // public static void Main(string[] args)
        // {
        //     // 13.  Find out if the given number is palindrome or not.
        //     int num =1646;
        //     int temp = num;
        //     int sum = 0;

        //     while(num > 0)
        //     {
        //         int digit = num%10;
        //         sum = (sum * 10) + digit;
        //         num/=10;
        //     }
        //     Console.WriteLine((sum == temp)? "palindrome" : "not palindrome");
        // }

        // public static void Main(string[] args)
        // {
        //     // 14. check no is automorphic or notinput n=25 output Automorphicas 25*25=625
        //     int num = 6;
        //     int temp = num;
        //     int square = num * num;
        //     int count = 0;
        //     int checkCount = 0;
        //     while(num > 0)
        //     {
        //         num/=10;
        //         count++;
        //     }
        //     Console.WriteLine(count);
        //     while(temp > 0)
        //     {
        //         if(temp % 10 == square%10)
        //         {
        //             checkCount++;
        //         }
        //         temp/= 10;
        //         square/=10;
        //     }
        //     Console.WriteLine(checkCount);
        //     Console.WriteLine((count == checkCount)? "Automorphic":"Not Automorphic");
        // }
}