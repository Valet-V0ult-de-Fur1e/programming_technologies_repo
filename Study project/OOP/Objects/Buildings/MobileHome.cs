﻿using OOP.OOP.Objects.ActionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOP.Objects.Buildings
{
    internal class MobileHome : Building, Moveable
    {
        public MobileHome(string name, int x, int y, bool isBuilded) : base(name, x, y, isBuilded)
        {
        }
        public void moveTo(int x, int y)
        {
            if (isBuild())
            {
                int oldX = getX();
                int oldY = getY();
                this.x = x;
                this.y = y;
                Console.WriteLine("{0}: переместился с координат ({1}, {2}) в координаты ({3}, {4})", getFullName(), oldX, oldY, this.x, this.y);
            }
            else
            {
                Console.WriteLine("{0}: не может переместиться по причине ещё не построено", getFullName());
            }
        }
    }
}
