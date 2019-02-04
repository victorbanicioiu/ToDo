using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {
        public int id { get; set; }
        public string objective { get; set; }
        public bool isDone { get; set; }
        public virtual ApplicationUser user { get; set; }

    }
}