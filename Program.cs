using System;

namespace Calcuator
{
    class Program
    {
       
        static void Main(string[] args)
        {
             double firstNumber;
             double secoundNmuber;
             double result;
             string ops;
             Console.WriteLine("                       calcuator in C#\n");
             ConsoleKeyInfo cki;
            
             do
                {
                    
                    Console.WriteLine();
                    Console.Write("enter your first number     ");
                    string input = Console.ReadLine();

                    bool check1;
                    do
                      {
                         if (!Double.TryParse(input, out firstNumber))
                           {
                               Console.WriteLine();
                               Console.WriteLine("Wrong input");
                               Console.WriteLine();
                               Console.Write("enter your first number    ");
                               input = Console.ReadLine();
                               Console.WriteLine();
                               check1 = false;
                           }
                           else
                           {
                               check1 = true;
                           }
                      } while (check1 == false);

                    firstNumber = double.Parse(input);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t select your operator  + , - , * , / , % ");
                    Console.WriteLine();
                    ops = Console.ReadLine();
                    Console.WriteLine();
                    string[] operators = { "+", "-", "*", "/", "%" };
                    int i = 0;

                    do
                      {
                          if (ops == operators[i])
                             {
                                 i = 10;
                             }
                         else
                             {
                                i++;
                             }
                         if (i == 5)
                            {
                                Console.WriteLine("\t\t\t select your operator  + , - , * , / , % ");
                                ops = Console.ReadLine();
                                i = 0;
                            }

                      } while (i < 5);
                    
                    Console.Write("enter your secound number    ");
                    input = Console.ReadLine();

                    do
                      {
                          if (!Double.TryParse(input, out secoundNmuber))
                             {
                                 Console.WriteLine();
                                 Console.WriteLine("Wrong input");
                                 Console.WriteLine();
                                 Console.Write("enter your secound number,    ");
                                 input = Console.ReadLine();
                                 Console.WriteLine();
                                 check1 = false;
                             }
                          else
                            {
                                 check1 = true;
                            }
                       } while (check1 == false);

                       secoundNmuber = double.Parse(input);

                       if (ops == "+")
                           {
                                result = firstNumber + secoundNmuber;
                                Console.WriteLine(firstNumber + " " + ops + "  " + secoundNmuber + " = " + result);
                                Console.WriteLine();
                                Console.WriteLine("Type anykey to continue calculation or click enter to leave");
                                Console.WriteLine();
                           }
                    
                       if (ops == "-")
                           {
                                result = firstNumber - secoundNmuber;
                                Console.WriteLine(firstNumber + " " + ops + "  " + secoundNmuber + " = " + result);
                                Console.WriteLine();
                                Console.WriteLine("Type anykey to continue calculation or click enter to leave");
                                Console.WriteLine();

                           }

                        if (ops == "*")
                           {
                               result = firstNumber * secoundNmuber;
                               Console.WriteLine(firstNumber + " " + ops + "  " + secoundNmuber + " = " + result);
                               Console.WriteLine();
                               Console.WriteLine("Type anykey to continue calculation  or click enter to leave");
                               Console.WriteLine();

                           }

                        if (ops == "/")
                           {

                            if (secoundNmuber == 0)
                               {
                                   Console.WriteLine();
                                   Console.WriteLine("  divition by zero not allowed ");
                               }
                        Console.WriteLine();
                        result = firstNumber / secoundNmuber;
                        Console.WriteLine(firstNumber + " " + ops + "  " + secoundNmuber + " = " + result);
                        Console.WriteLine();
                        Console.WriteLine("Type anykey to continue calculation  or click enter to leave");
                        Console.WriteLine();

                    }

                       if (ops == "%")
                          {
                               result = firstNumber % secoundNmuber;
                               Console.WriteLine(firstNumber + " " + ops + "  " + secoundNmuber + " = " + result);
                               Console.WriteLine();
                               Console.WriteLine("Type anykey to continue calculation or click enter to leave");
                               Console.WriteLine();

                          }
                       Console.WriteLine();
                       cki = Console.ReadKey();
                       Console.WriteLine();
                   } while (cki.Key != ConsoleKey.Enter);

        }
    }
}
