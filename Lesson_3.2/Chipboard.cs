﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_3._2
{
    class Chipboard : Wood
    {
        public Chipboard(string name, string type, string color, decimal price) : base(name, type, color, price) { }

        public new void PrintAboutItem()
        {
            base.PrintAboutItem();
        }
    }
}
