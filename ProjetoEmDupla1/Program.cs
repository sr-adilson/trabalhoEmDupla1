﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmDupla1.Views;


namespace ProjetoEmDupla1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MontaMenu();
            Console.ReadLine();
        }
    }
}
