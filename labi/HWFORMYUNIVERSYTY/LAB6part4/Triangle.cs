﻿using System;

namespace LAB6part4
{
    public class Triangle:GraphicPrimitive
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle at ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
        public override void Scale(float factor)
        {
        }
    }
}