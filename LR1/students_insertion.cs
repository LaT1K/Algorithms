using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1 {
    internal class students_insertion : students_bubble{
        public override void sort(students_bubble[] arr) {
            students_bubble nKey, nTemp;
            int j;
            {
                for(int i = 1; i < arr.Length; i++) {
                    nKey = arr[i];
                    j = i;
                    while((j>0) && (arr[j-1].Avg>nKey.Avg)) { 
                        nTemp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = nTemp;
                        j--;
                    }
                    arr[j] = nKey;
                }
            }
        }
    }
}
