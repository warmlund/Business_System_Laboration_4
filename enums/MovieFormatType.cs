﻿using System.ComponentModel;

namespace Business_System_Laboration_4
{
    public enum MovieFormatType
    {
        [Description("Ingen info")]
        None,
        [Description("DVD")]
        DVD,
        [Description("Blu-Ray")]
        Blu_Ray
    }
}