﻿using static System.Console;

    public class Program
    {
        static void Adicionar20(int a)
        {
            a = a + 20;
        }
        public static void Main()
        {
            int a = 2;
            Adicionar20(a);

            WriteLine($"O valor da variável a é {a}");
        }
    }
