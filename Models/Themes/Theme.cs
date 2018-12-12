using System.Collections;
using System.Collections.Generic;

namespace Education.Models
{
    public class Theme
    {
        public int ThemeID {get; set;}
        public string ThemeName {get;set;}
         public ICollection<Task> Tasks { get; set; }
        
    }
}