using System.Security.AccessControl;
using Common;

namespace Demo
{
    enum Season : byte
    {
        Spring,
        Winter,
        Summer,
        Autumn
    }

    enum WeekDays : byte
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Gender : byte
    {
        Male = 2,
        Female
    }

    // Read, write, execute, delete

    [Flags]
    enum Permissions
    {
        Read = 8,
        write = 4, 
        execute = 2,
        delete = 1
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and unboxing

            ////// boxing : casting from value type to reference type 
            ////// unboxing : casting from reference type to value type 

            ////object obj = new object();

            ////obj = "Kiro";

            ////obj = (object) 3; // from value type to reference named object (object) Boxing


            //object obj = new object();

            //int Var = (int)obj; 
            //// Explicied Casting 
            //// unsafe casting
            //// unboxing

            #endregion

            #region Nullable Values

            //int var = 6;

            //var = null; // Can't do that

            //int? var = 6;

            //var = null;

            //int var = 5;

            //int? var2 = null;

            //var2 = var;


            //int? var = 5;

            //int var2 = (int)var;

            // can be casted unless u explicit cast it  (Null reference exception)

            //int? var = null;

            //int var2;

            //if (var != null)
            //{
            //    var2 = (int)var;
            //}
            //else var2 = 0;


            //Console.WriteLine(var2);



            //if (var is not null)
            //{
            //    var2 = (int)var;
            //}
            //else var2 = 0;


            //Console.WriteLine(var2);


            //if (var.HasValue)
            //{
            //    var2 = var.Value;
            //}
            //else
            //{
            //    var = 0;
            //}

            //var2 = var.HasValue ? var.Value : 0;
            //var2 = var is not null ? var.Value : 0;


            //var2 = var ?? 0;

            //Console.WriteLine(var2);
            #endregion

            #region Nullable Reference

            ////string message = "Hello";
            ////message = null;


            //string Var01 = null; // Required 

            //string? Var02 = null; // Nullable

            //Console.WriteLine(Var01.Length);
            //Console.WriteLine(Var02.Length);


            #endregion

            #region Null Propagation Operator

            ////double x = default;

            ////Console.WriteLine(x);

            //int[] arr = default;
            //int[] Arr = { 1,2,3,4,5};

            ////for (int i = 0;(arr is not null) && i < arr.Length; i++) {
            ////    Console.WriteLine("UnReachable code");
            ////}

            //for (int i = 0; (Arr is not null) && i < Arr.Length; i++) {
            //    Console.WriteLine();
            //}

            //if (arr is not null) { // Best Practice for null 
            //    for (int i = 0;i < arr.Length; i++)
            //    {
            //        Console.WriteLine("UnReachable code");
            //    }
            //}

            //for (int i = 0;i < arr?.Length; i++)
            //{
            //    Console.WriteLine("Reachable code");
            //}


            #endregion

            #region Exception Handling

            //static void DoSomeCode()
            //{
            //    try
            //    {
            //        int var1, var2, var3;

            //        var1 = int.Parse(Console.ReadLine());
            //        var2 = int.Parse(Console.ReadLine());

            //        var3 = var1 / var2;

            //        int[] Arr = { 1, 2, 3 };
            //        Arr[100] = 10;
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finally"); // will happen either way 
            //    }
            //}

            //static void DoSomeCodePlus() {

            //    try
            //    {
            //        int var1, var2, var3;

            //        bool flag;


            //        do
            //        {
            //            Console.Write("Enter first Number: ");
            //            flag = int.TryParse(Console.ReadLine(), out var1);

            //        } while (!flag);

            //        do
            //        {
            //            Console.Write("Enter Second Number: ");
            //            flag = int.TryParse(Console.ReadLine(), out var2);

            //        } while (!flag || var2 == 0);

            //        var3 = var1 / var2;


            //        int[] Arr = { 1, 2, 3 };

            //        if (100 < Arr?.Length)
            //        {
            //            Arr[100] = 10;
            //        }
            //    }
            //    catch (FormatException ex) {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}
            //DoSomeCodePlus();


            #endregion

            #region Access Modifiers

            //// Class libarary

            ////Common.TypeA typeA = new TypeA();

            //// cant be accessed coz its in other project (internel)

            //TypeA typeA = new TypeA();

            // private same class only 
            // internel same project
            // public any project
            #endregion

            #region Enum Ex01 Ex02

            // Enum : value type struct / Enum 
            // Stack

            //Season s1 = Season.Spring;

            //s1 = Season.Winter;

            //Console.WriteLine((int)s1);

            //Gender gender = (Gender) 2;

            //Console.WriteLine(gender);


            //Gender Go1 = (Gender) Enum.Parse(typeof(Gender),Console.ReadLine(),true);

            //Console.WriteLine(Go1);

            //object Go1;

            //bool isValid = Enum.TryParse(typeof(Gender),Console.ReadLine(), true, out Go1);

            //Gender var = (Gender) Go1;

            //Permissions Person01 = Permissions.Read; // if read exists it will be deleted

            //Person01 ^= Permissions.delete;

            //Console.WriteLine(Person01);

            ////Console.WriteLine((int) Person01);
            ////
            ////Person01 |= Permissions.delete; //add Permission

            ////Console.WriteLine(Person01);
            ////
            //Person01 &= ~(Permissions.delete);

            //Console.WriteLine(Person01); 
            #endregion
        }
    }
}
