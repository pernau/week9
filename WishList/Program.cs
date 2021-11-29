﻿using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffe machine");
            myWishList.Add("new pair of sock");
            myWishList.Add("box of chocolate");
            myWishList.Add("new pillow");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }

        }
    }
}
