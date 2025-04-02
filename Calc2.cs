// using System;

// namespace Other_CS_Cal
// {
//     class Calculator
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Write your equation with spaces between each number and operator");
//             string[] input = Console.ReadLine().Split();
//             int num1 = int.Parse(input[0]);
//             int num2 = int.Parse(input[2]);
//             string ans = "error";
//             if (char.Parse(input[1]) == '+')
//             {
//                 ans = (num1 + num2).ToString();
//             }
//             else if (char.Parse(input[1]) == '-')
//             {
//                 ans = (num1 - num2).ToString();
//             }
//             else if (char.Parse(input[1]) == '*')
//             {
//                 ans = (num1 * num2).ToString();
//             }
//             else if (char.Parse(input[1]) == '/')
//             {
//                 ans = (num1 / num2).ToString();
//             }
//             else if (char.Parse(input[1]) == '%')
//             {
//                 ans = (num1 % num2).ToString();
//             }
//             Console.WriteLine("{0}: {1}" , "Answer" , ans);


//         }
//     }
// }