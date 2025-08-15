using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class Program
    {
        #region Q_1
        ///public static void Q_1(int x, int y)
        ///{
        ///int Box = x;
        ///x = y; // x is now 82
        ///y = Box; // y is now 10
        ///Console.WriteLine($"operation in function");
        ///Console.WriteLine($"after swaping now a = {x} and b = {y}");
        ///}   // ==> By Value

        ///public static void Q_1(ref int x , ref int y )
        ///{
        ///    int Box = x;
        ///    x = y; // x is now 82
        ///    y = Box; // y is now 10
        ///    Console.WriteLine($"operation in function");
        ///    Console.WriteLine($"after swaping now a = {x} and b = {y}");   
        ///
        ///} //==> by Ref

        #endregion

        #region Q_2
        ///passing by value 
        ///public static void Q_2( int[] arr)
        ///{
        ///    if (arr is not null)
        ///    {
        ///        arr[0] = 100; // Changing the first element of the array
        ///        arr = new int[] { 10, 20, 30, 40, 50 }; // Reassigning the array //will not affect the original array outside this function
        ///        Console.Write("\nAfter entering the function\n \t \tarray = { ");
        ///        for (int i = 0; i < arr.Length; i++)
        ///        {
        ///            Console.Write(arr[i] + " ");
        ///        }
        ///        Console.WriteLine("}");
        ///    }
        ///    else
        ///    {
        ///        return;
        ///    }
        ///} ==> Passing the array by value

        ///passing by reference
        ///public static void Q_2(ref int[] arr)
        ///{
        ///    if (arr is not null)
        ///    {
        ///        arr[0] = 100; // Changing the first element of the array
        ///        Console.Write("\nAfter entering the function\n \t \tarray = { ");
        ///        for (int i = 0; i < arr.Length; i++)
        ///        {
        ///            Console.Write(arr[i] + " ");
        ///        }
        ///        Console.WriteLine("}");
        ///    }
        ///    else
        ///    {  return;  }
        ///    arr = new int[] { 10, 20, 30, 40, 50 }; // Reassigning the array //will affect the original array outside this function
        ///}
        #endregion

        #region Q_3
        //public static void Operate(int x, int y,  out int sum,out int subtract)
        //{
        //    sum = x + y ;
        //    subtract = x - y ;
        //    Console.WriteLine($"The summation of the numbers is: {sum}");
        //    Console.WriteLine($"The subtraction of the numbers is: {subtract}");
        //}

        #endregion

        #region Q_4
        //public static int sumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10; // Add the last digit to the sum
        //        num /= 10; // Remove the last digit
        //    }
        //    return sum;
        //}

        #endregion

        #region Q_5
        #region first solution
        //public static void IsPrime(int num)
        //{
        //if (num < 2)
        //{
        //Console.WriteLine($"{num} is not a prime number.");
        //return;
        //}
        //for (int i = 2; i < num; i++)
        //{
        //if (num / i == 1 && num % i == 0)
        //{
        //Console.WriteLine($"{num} is prime");
        //}
        //else
        //{
        //Console.WriteLine($"{num} is not prime");
        //}
        //}
        //} 
        #endregion

        //static bool IsPrime(int num)
        //{
        //    if (num < 2) return false;
        //    for (int i = 2; i < num; i += 1)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        #endregion

        #region Q_6
        //public static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    max = arr[0]; ;
        //    min = arr[0]; ;
        //    for (int i = 1 ; i < arr.Length; i++)
        //    {            
        //        if (arr[i] > max )
        //        {
        //            max = arr[i];

        //        }
        //        else if (min > arr[i])
        //        {
        //            min = arr[i];
        //        }
        //    }
        //}

        #endregion

        #region Q_7
        //static void vactorial(int num)
        //{
        //    long mult = 1;
        //    for (int i = 1; i <= num; i++)
        //    { 
        //        mult *= i;
        //    }
        //    Console.WriteLine($"The factorial of {num} is: {mult}");
        //}
        #endregion

        #region Q_8
        //static string ChangeChar‎(string str , int index , string text)
        //{
        //    char ch = text[0];
        //    string result = str.Replace(str[index], ch);
        //    return result;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Q_1
            //‎Explain the difference between passing (Value type parameters) by value and by reference
            //then write a suitable c# example.

            //sol

            //1. when passing Value Paramenter  by Value ==> ClR Get Cope From The Value But will not Effect 
            // out of the function

            ///int a = 10;
            ///int b = 82;
            ///Q_1(a, b);
            ///Console.WriteLine("operation out of function");
            ///Console.WriteLine($"after swaping now a = {a} and b = {b}"); // a = 10, b = 82
            ///==> By Value
            ///

            //2.when passing Value Paramenter  by Reference ==> ClR will Get the Ref From The Value and will
            //Effect out of the function

            ///int a = 45, b = 34;
            ///Console.WriteLine($"before swaping now a = {a} and b = {b}"); // a = 45, b = 34
            ///Q_1(ref a , ref b); // Value by Ref
            ///Console.WriteLine("operation out of function");
            ///Console.WriteLine($"after swaping now a = {a} and b = {b}"); // a = 10, b = 82
            #endregion

            #region Q_2
            //‎2-‎	Explain the difference between passing (Reference type ‎parameters) by value and by reference
            //then write a suitable c# ‎example.‎

            //sol

            ///1.when passing Reference Type Parameters by Value Type 
            ///==> it will not affect the original array outside this function 
            ///int[] numbers = { 1, 2, 3, 4, 5 };
            ///Console.Write("Before entering the function\n \t \tarray = { ");
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    Console.Write(numbers[i] + " ");
            ///}
            ///Console.WriteLine("}");
            ///Q_2(numbers); // Passing the array by value
            ///Console.Write("\nAfter exiting the function\n \t \tarray = { ");
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    Console.Write(numbers[i] + " ");
            ///}
            ///Console.WriteLine("}");

            ///2.when passing Reference Type Parameters by Reference Type 
            ///==> it will affect the original array outside this function
            ///Q_2(ref numbers); // Passing the array by reference
            ///Console.Write("\nAfter exiting the function\n \t \tarray = { ");
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    Console.Write(numbers[i] + " ");
            ///}
            ///Console.WriteLine("}");


            #endregion

            #region Q_3
            //Write a c# Function that accept 4 parameters from user
            //and return result of summation and subtracting of two numbers

            ///sol
            ///Console.WriteLine("Enter Four Numbers");
            ///int.TryParse(Console.ReadLine(), out int a);
            ///int.TryParse(Console.ReadLine(), out int b);
            ///int sum, sub;
            ///Console.WriteLine($"{a}{b}");
            ///Operate(a, b,out sum ,out sub);
            ///Console.WriteLine($"{a} + {b} = {sum}");
            ///Console.WriteLine($"{a} - {b} = {sub}");
            #endregion

            #region Q_4
            //‎1-‎	Write a program in C# Sharp to create a
            //function to calculate the sum of the ‎individual digits of a given number.‎


            //sol
            //Console.WriteLine("Enter the Number");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine($"\nThe sum of the digits is: {sumOfDigits(number)}");



            /// //Another solution
            ///Console.WriteLine("Enter the Number");
            ///string input = Console.ReadLine() ?? "0";
            ///bool check = int.TryParse(input, out int num);
            ///int sum = 0;
            ///
            ///foreach (char c in input)
            ///{
            ///    if (check)
            ///    {
            ///        int n = c - '0';
            ///
            ///        sum += n;
            ///        Console.Write($"{n} ");
            ///    }
            ///}
            ///Console.WriteLine($"\nThe sum of the digits is: {sum}");






            #endregion

            #region Q_5
            //‎5-‎	Create a function named "IsPrime", which receives an integer number
            //‎and retuns true if it is prime, or false if it is not:‎


            //sol
            //int num;
            //do
            //{
            //Console.WriteLine("Enter The Number");

            //} while (!(int.TryParse(Console.ReadLine(), out num)) || num <=0);

            //if (IsPrime(num))
            //{ Console.WriteLine($"{num} is a prime number."); }
            //else
            //{ Console.WriteLine($"{num} is not a prime number."); }


            #endregion

            #region Q_6
            //‎6-‎	Create a function named , to return the minimum
            //and maximum ‎values stored in an array, using reference parameters

            //sol

            //int[] arr = {8 , 1 ,6 , 2, 3 ,4 ,-5 };
            //int min =0, max = 0;
            //MinMaxArray(arr, ref min,ref max);
            //Console.WriteLine($"The maximum value in the array is: {max}");
            //Console.WriteLine($"The minimum value in the array is: {min}");



            #endregion

            #region Q_7
            //‎7-‎	Create an iterative (non-recursive) function to calculate
            //the factorial ‎of the number specified as parameter

            //sol

            //int num = 5;
            //vactorial(num);


            #endregion

            #region Q_8
            //‎8-‎	Create a function named "ChangeChar" to modify a letter in a certain ‎position (0 based) of a string,
            //replacing it with a different letter

            //sol
            //string str, ch;
            //int index;
            //do
            //{
            //    Console.WriteLine("Enter the string");
            //    str = Console.ReadLine() ;
            //} while ( str.Length == 0);
            //do
            //{
            //    Console.WriteLine("Enter the index of the character you want to change");
            //} while (!(int.TryParse(Console.ReadLine(), out index)) || index < 0 || index >= str.Length);
            //do
            //{
            //    Console.WriteLine("Enter the character you want to change to");
            //    ch = Console.ReadLine();
            //} while (ch.Length > 1 || ch.Length <1 || int.TryParse(ch , out int x) );
            //Console.WriteLine(ChangeChar(str,index , ch));



            #endregion

        }
    }
}
