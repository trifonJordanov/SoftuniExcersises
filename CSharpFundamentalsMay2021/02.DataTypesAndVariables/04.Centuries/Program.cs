﻿using System;

namespace _04.Centuries
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = byte.Parse(Console.ReadLine());
            int years =centuries * 100;
            int days = (int)(years * 365.2422m);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
