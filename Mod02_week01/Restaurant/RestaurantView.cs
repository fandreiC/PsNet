﻿using System;
using RestaurantMenus;

namespace Restaurant
{
     class RestaurantView
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Restaurant!");

            TakeOrder();

            Console.ReadKey();
        }

        public static void TakeOrder()
        {
            Order order1 = new Order();
        }
    }
}
