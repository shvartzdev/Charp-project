﻿using System.Collections.Generic;
using Education.Models;

namespace Education
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Duration {get; set;}
        public string Description {get; set;}
        //public ICollection<Theme> Themes { get; set; }
    }    
}