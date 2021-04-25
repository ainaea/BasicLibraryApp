﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverPhoto { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
    }
}
