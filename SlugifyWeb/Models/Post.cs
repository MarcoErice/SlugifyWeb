﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlugifyWeb.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public bool ExplicitLanguage { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
