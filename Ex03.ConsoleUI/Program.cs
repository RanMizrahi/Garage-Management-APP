﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            GarageManagerInteractor garageApp = new GarageManagerInteractor();
            garageApp.RunGarage();
        }
    }
}