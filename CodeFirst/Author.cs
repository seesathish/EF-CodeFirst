﻿using System.Collections.Generic;

namespace FluentAPI
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }  
    }
}
