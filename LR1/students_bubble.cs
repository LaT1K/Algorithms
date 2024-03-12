using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class students_bubble
    {
        public string group { get; set; }
        public string surname { get; set; }

        public int English {  get; set; }
        public int Math {  get; set; }
        public int Programming {  get; set; }
        public double Avg { get; set; }

        public students_bubble() {
        }
        public students_bubble(string group, string surname, int English, int Math, int Programming) {
            this.group = group;
            this.surname = surname;
            this.English = English;
            this.Math = Math;                                       
            this.Programming = Programming;
        }
         
        public double calAvg() {
            return (this.English + this.Math + this.Programming) / 3.0;
        }

        public override string ToString() {
            return $"{this.group}, {this.surname}, Avg - { this.calAvg().ToString("F2")}";
        }

        public virtual void sort(students_bubble[] arr ) {
            bool swapped = false; ;
            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length - i - 1; j++) {
                    if (arr[j].Avg > arr[j + 1].Avg) {
                        students_bubble temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                    else if (arr[j].Avg == arr[j + 1].Avg) {
                        if (string.Compare(arr[j].surname, arr[j + 1].surname) > 0) {
                            students_bubble temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }
                    }
                }
                if (!swapped) {
                    MessageBox.Show("Природність поведінки працює");
                    break;
                }
            }
        }

    }
}
