﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToJsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter();
            Console.WriteLine(c.NewsById());
            Console.ReadLine();
        }
    }
}
