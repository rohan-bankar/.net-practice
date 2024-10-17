using System;

/*
Generate your own function to satisfy the relationship between the inputs and outputs.
Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
Examples
832 ➞ 594
51 ➞ 36
*/
class Ten
{
    public static void Main(string[] args)
    {
        int num = 832;
        int sum = 0;
        int temp = num;
         while(num>0)
         {
            int digit = num%10;
            sum = (sum * 10) + digit;
            num/=10;
         }
         Console.WriteLine($"{temp} => {temp-sum}");
    }
}