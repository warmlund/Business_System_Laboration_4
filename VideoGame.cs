﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Business_System_Laboration_4
{
    public class VideoGame : Product
    { 
        private PlatformType _platform;
        public  PlatformType Platform { get { return _platform; } set { _platform=value; } }

        public VideoGame(string id, int amount, float price, string name, PlatformType platform): base(id, amount, price, name)
        {
                 _platform= platform;
        }
    }
}