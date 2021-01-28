using System;
using System.Collections.Generic;

namespace E_commarceWebApp.ApiLayer.Models
{
    public partial class Students
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePicPath { get; set; }
        public string ProfilePicExt { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IsMonitor { get; set; }
        public int GradeGid { get; set; }

        public virtual Grades GradeG { get; set; }
    }
}
