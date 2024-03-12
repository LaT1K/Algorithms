using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1 {
    internal class students_shaker : students_bubble{
        public override void sort(students_bubble[] arr) {
            int left = 0;
            int right = arr.Length - 1;
            bool swapped;

            do {
                swapped = false;

                for (int i = left; i < right; i++) {
                    if (arr[i].Avg > arr[i + 1].Avg || (arr[i].Avg == arr[i + 1].Avg && string.Compare(arr[i].surname, arr[i + 1].surname) > 0)) {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                right--;

                if (!swapped && left == 0) {
                    MessageBox.Show("Природність поведінки працює");
                    break;
                }
                if (!swapped)
                    break;

                swapped = false;

                // Прохід вліво
                for (int i = right; i > left; i--) {
                    if (arr[i].Avg < arr[i - 1].Avg || (arr[i].Avg == arr[i - 1].Avg && string.Compare(arr[i].surname, arr[i - 1].surname) < 0)) {
                        Swap(ref arr[i], ref arr[i - 1]);
                        swapped = true;
                    }
                }
                left++;
            } while (swapped);
        }

        private static void Swap(ref students_bubble a, ref students_bubble b) {
            students_bubble temp = a;
            a = b;
            b = temp;
        }
    }
}
