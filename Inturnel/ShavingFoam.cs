﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inturnel
{
    public class ShavingFoam : Product
    {
        public bool CanBuy(int money)
        {
            return money > Price;
        } 
    }
}
