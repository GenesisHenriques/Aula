﻿using System;

namespace _30_F4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int largura = 12;
            int cont = 0;

            for (int altura = 7; cont < altura; cont++)

            {
                if (cont < 1) // linha 1
                {

                    for (int caractere = 0; caractere < largura; caractere++)
                    {
                        Console.Write("*");          
                    }
                    
                    Console.WriteLine();
                }

                else if (cont < 2) // linha 2
                {

                    for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere < 5)
                        {
                            Console.Write("*");
                        }
                        else if (caractere > 4 && caractere < 7)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    
                    Console.WriteLine();
                }
                
                else if (cont < 3) // linha 3
                {

                   for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere < 4)
                        {
                            Console.Write("*");
                        }
                        else if (caractere > 3 && caractere < 8)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    
                    Console.WriteLine();
                }

                else if (cont < 4) // linha 4
                {

                     for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere < 3)
                        {
                            Console.Write("*");
                        }
                        else if (caractere > 2 && caractere < 9)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    
                    Console.WriteLine();
                }

                else if (cont < 5) // linha 5
                {

                     for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere < 2)
                        {
                            Console.Write("*");
                        }
                        else if (caractere > 1 && caractere < 10)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    
                    Console.WriteLine();
                }

                else if (cont < 6) // linha 6
                {

                     for (int caractere = 0; caractere < largura; caractere++)
                    {
                        if (caractere < 1)
                        {
                            Console.Write("*");
                        }
                        else if (caractere > 0 && caractere < 11)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    
                    Console.WriteLine();
                }

                else if (cont < 7) // linha 7
                {

                    for (int caractere = 0; caractere < largura; caractere++)
                    {
                        Console.Write("+");          
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
