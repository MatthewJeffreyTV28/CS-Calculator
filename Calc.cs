// using System;

// namespace CS_Calculator
// {
//     class Calculator
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Choose your first number");
//             int num1 = int.Parse(Console.ReadLine());
//             Console.WriteLine("Choose and Operator. [+] [-] [*] [/] [%]");
//             string operate = Console.ReadLine();
//             Console.WriteLine("Choose your second number");
//             int num2 = int.Parse(Console.ReadLine());
//             string ans = "error";
//             if (char.Parse(operate) == '+')
//             {
//                 ans = (num1 + num2).ToString();
//             }
//             else if (char.Parse(operate) == '-')
//             {
//                 ans = (num1 - num2).ToString();
//             }
//             else if (char.Parse(operate) == '*')
//             {
//                 ans = (num1 * num2).ToString();
//             }
//             else if (char.Parse(operate) == '/')
//             {
//                 ans = (num1 / num2).ToString();
//             }
//             else if (char.Parse(operate) == '%')
//             {
//                 ans = (num1 % num2).ToString();
//             }
//             Console.WriteLine("{0}: {1}" , "Answer" , ans);
//         }
//     }
// }