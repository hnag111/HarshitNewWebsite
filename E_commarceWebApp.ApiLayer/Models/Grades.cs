using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ApiLayer.Models
{
    public partial class Grades
    {
        public Grades()
        {
            Students = new HashSet<Students>();
        }

        public int Gid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
