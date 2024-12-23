using System.Drawing;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using Common;
using static System.Net.Mime.MediaTypeNames;

namespace Assi_05
{
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

    enum Season : byte
    {
        Spring,
        Winter,
        Autumn,
        Summer
    }
    enum Spring : byte
    {
        March,
        April,
        May
    }
    enum Summer : byte
    {
        June,
        July,
        August
    }

    enum Autumn : byte
    {
        September,
        October,
        November
    }
    enum Winter
    {
        December,
        January,
        February
    }

    [Flags]
    enum Permissions
    {
        Read = 8,
        write = 4,
        execute = 2,
        delete = 1
    }

    enum Colors
    {
        Red,
        Green,
        Blue,
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 Try all we have learned
            ////// first let's try Casting implicied
            ////object obj = new object();

            ////obj = "Kiro";

            ////obj = (object) 3;

            ////Console.WriteLine(obj);

            //// let's try now the Explicied casting Dangrous!
            //object obj = Console.ReadLine();

            //int Var = (int) obj;


            ////let's try the nullable int type
            //int var2;
            //int? var = null;

            //if (var.HasValue)
            //{
            //    var2 = var.Value;
            //}
            //else
            //{
            //    var = 0;
            //}

            ////var2 = var ?? 0;


            // Nullable reference

            //string message = "Hello";
            //message = null;


            //string Var01 = null; 

            //string? Var02 = null; 

            //Console.WriteLine(Var01.Length); //// Error
            //Console.WriteLine(Var02.Length);



            // Null Propagation
            //int[] arr = { 1,2,3,4,5};

            //if (arr is not null)
            //{ // Best Practice for null 
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine("Reachable code");
            //    }
            //}

            // Exception handling 

            //static void DoSomeCodePlus()
            //{

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
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}
            //DoSomeCodePlus();

            //// Access modifiers (public)

            //TypeA typeA = new TypeA();

            //Enum

            //object? Go1 = Gender.Male;

            //bool isValid = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out Go1);

            //Gender var = (Gender)Go1;

            #endregion

            #region Part2

            #region Q1
            //WeekDays weekDays = WeekDays.Sunday;

            //for (int i = 0; i <= (int)WeekDays.Sunday; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            //Console.WriteLine();

            //// OR

            //var Weekdays = Enum.GetValues(typeof(WeekDays));

            //for (int i = 0; i < Weekdays.Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region Q2

            //    try
            //    {
            //        object? Go1 = null;
            //        bool isValid;

            //        do
            //        {
            //            Console.Write("Enter a Season: ");
            //            isValid = Enum.TryParse(typeof(Season), Console.ReadLine(), true, out Go1);

            //        } while (!isValid);

            //            Season season;

            //            season = (Season)Go1;

            //            switch (season)
            //            {
            //                case Season.Spring:
            //                    foreach (string month in Enum.GetNames(typeof(Spring)))
            //                        Console.WriteLine(month);
            //                    break;
            //                case Season.Summer:
            //                    foreach (string month in Enum.GetNames(typeof(Summer)))
            //                        Console.WriteLine(month);
            //                    break;
            //                case Season.Autumn:
            //                    foreach (string month in Enum.GetNames(typeof(Autumn)))
            //                        Console.WriteLine(month);
            //                    break;
            //                case Season.Winter:
            //                    foreach (string month in Enum.GetNames(typeof(Winter)))
            //                        Console.WriteLine(month);
            //                    break;
            //            }
            //    }
            //    catch (Exception e) {
            //        Console.WriteLine($"Error :{e.Message}");
            //    }

            //}
            #endregion

            #region Q3

            //try
            //{

            //    bool isValid;
            //    int cycle;
            //    Permissions person01 = 0000;

            //    do
            //    {
            //        Console.WriteLine("0. Quit");
            //        Console.WriteLine("1. Add Permission");
            //        Console.WriteLine("2. Delete Permission");
            //        Console.WriteLine("3. Search for Permission");

            //        isValid = int.TryParse(Console.ReadLine(), out cycle);

            //        if (!isValid || cycle < 0 || cycle > 3)
            //        {
            //            Console.WriteLine("Invalid option! ");
            //            break;
            //        }

            //        switch (cycle)
            //        {
            //            case 0:
            //                break;

            //            case 1:
            //                int addOption;
            //                do
            //                {
            //                    Console.WriteLine("All possible permissions with values:");
            //                    Console.WriteLine("0: Quit");
            //                    for (int i = 1; i <= 15; i++)
            //                    {
            //                        Permissions permission = (Permissions)i;
            //                        Console.WriteLine($"{i}: {permission}");
            //                    }

            //                    isValid = int.TryParse(Console.ReadLine(), out addOption);

            //                    if (isValid && addOption > 0 && addOption <= 15)
            //                    {
            //                        person01 |= (Permissions)addOption;
            //                        Console.WriteLine($"Current permissions: {person01}");
            //                    }
            //                    else if (addOption == 0)
            //                    {
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Invalid permission");
            //                    }

            //                } while (addOption != 0);
            //                break;

            //            case 2:
            //                int deleteOption;
            //                do
            //                {
            //                    Console.WriteLine("All possible permissions to delete with values:");
            //                    Console.WriteLine("0: Quit");
            //                    for (int i = 1; i <= 15; i++)
            //                    {
            //                        Permissions permission = (Permissions)i;
            //                        Console.WriteLine($"{i}: {permission}");
            //                    }

            //                    isValid = int.TryParse(Console.ReadLine(), out deleteOption);

            //                    if (isValid && deleteOption > 0 && deleteOption <= 15)
            //                    {
            //                        person01 &= ~(Permissions)deleteOption;
            //                        Console.WriteLine($"Current permissions: {person01}");
            //                    }
            //                    else if (deleteOption == 0)
            //                    {
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Invalid permission");
            //                    }

            //                } while (deleteOption != 0);
            //                break;

            //            case 3:
            //                object? Go1 = null;
            //                bool IsValid = false;

            //                do
            //                {
            //                    Console.Write("Enter a permission to Look Up for: ");
            //                    IsValid = Enum.TryParse(typeof(Permissions), Console.ReadLine(), true, out Go1);
            //                } while (!IsValid);



            //                string ans = person01.ToString();
            //                bool exists = ans.Contains(Go1.ToString());

            //                Console.WriteLine(exists ? "Permission exists." : "Permission does not exist.");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid option.");
            //                break;
            //        }

            //    } while (cycle != 0);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.ToString());

            //}
            ////Console.WriteLine((int) Person01);
            ////
            ////Person01 |= Permissions.delete; //add Permission

            ////Console.WriteLine(Person01);
            ////
            ////Person01 &= ~(Permissions.delete);

            ////Console.WriteLine(Person01);

            #endregion

            #region Q4
            try
            {
                string? input = Console.ReadLine();
                Colors colors;
                if (Enum.TryParse(input, true, out colors))
                {
                    if (colors == Colors.Red || colors == Colors.Blue || colors == Colors.Green)
                    {
                        Console.WriteLine($"{colors} is a primary Color");
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid color");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            #endregion


            #endregion


        }
    }
}
