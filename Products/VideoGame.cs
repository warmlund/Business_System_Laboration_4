﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Business_System_Laboration_4.enums;

namespace Business_System_Laboration_4.Products
{
    public class VideoGame : Product
    {
        private PlatformType _platform;
        public PlatformType Platform { get { return _platform; } set { _platform = value; OnPropertyChanged(nameof(Platform)); } }

        public string FormatDescription { get { return GetDescription(_platform); } set { OnPropertyChanged(nameof(PlatformType)); } }

        public VideoGame(string id, int amount, float price, string name, PlatformType platform) : base(id, amount, price, name)
        {
            _platform = platform;
        }

        public static string GetDescription(PlatformType value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}