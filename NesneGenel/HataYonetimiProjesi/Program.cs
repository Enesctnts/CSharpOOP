﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimiProjesi
{
    class OnUcOlamazHatasi:Exception
    {
        public override string Message => "13 olamaz istisnasi";

    }
    class Program
    {
        static void Main(string[] args)
        {

            throw new OnUcOlamazHatasi();
            

        }
    }
}
