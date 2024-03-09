using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal struct students_bubble
    {
        public string group { get; set; }
        public string surname { get; set; }

        public int English {  get; set; }
        public int Math {  get; set; }
        public int Programming {  get; set; }
        public double Avg { get; set; }
        public students_bubble()
        {
        }
        public students_bubble(string group, string surname, int English, int Math, int Programming)
        {
            this.group = group;
            this.surname = surname;
            this.English = English;
            this.Math = Math;                                       
            this.Programming = Programming;
        }
         
        public double calAvg()
        {
            return (this.English + this.Math + this.Programming) / 3.0;
        }

        public string ToString()
        {
            return $"{this.group}, {this.surname}, Avg - { this.calAvg().ToString("F2")}";
        }
    }
}
