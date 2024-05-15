using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bdn_Lesson04.Models
{
    public class Bdncustomer
    {
        public int CustomerId { get; set; }
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int YearofBirth { get; set; }
    }
}