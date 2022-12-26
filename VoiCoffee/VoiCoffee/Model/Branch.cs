using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VoiCoffee.Model
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Province { get; set; }
        public string Address { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Img { get; set; }
    }
}

