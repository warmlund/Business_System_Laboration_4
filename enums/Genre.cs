﻿using System.ComponentModel;

namespace Business_System_Laboration_4
{
    public enum Genre
    {
        [Description("Ingen info")]
        None,
        [Description("Historia")]
        Historia,
        [Description("Kurslitteratur")]
        Kurslitteratur,
        [Description("Äventyr")]
        Äventyr,
        [Description("Noir")]
        Noir,
        [Description("Skräck")]
        Skräck
    }
}