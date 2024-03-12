using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1 {
    internal class students_min_element : students_bubble {
        public override void sort(students_bubble[] arr) {
            students_bubble min, temp;
            int n_min = 0;
            for(int i = 0; i < arr.Length; i++) {
                min = arr[i];
                n_min = i;
                for(int j = i; j < arr.Length; j++) {
                    if (min.Avg > arr[j].Avg || (min.Avg == arr[i].Avg && string.Compare(min.surname, arr[i].surname) > 0)) {
                        min = arr[j];
                        n_min = j;
                    }
                }
                temp = arr[n_min];
                arr[n_min] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
