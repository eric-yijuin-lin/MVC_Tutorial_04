﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Tutorial_04.Models
{
    public partial class TblNews
    {
        public int No { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
