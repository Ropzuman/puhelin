﻿using System;

namespace puhelin
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p1 = new Phone("Samsung");

            p1.Call("020202");
            p1.EndCall();


            p1.Call("0700 123 123");
            p1.EndCall();
        }
    }
}
