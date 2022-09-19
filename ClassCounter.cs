﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRobot
{
    class ClassCounter
    {
        public delegate void MethodContainer();
        
        public event MethodContainer onCount;
        public void Count()
        {
            for(int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    onCount();
                }
            }
        }
    }
}
