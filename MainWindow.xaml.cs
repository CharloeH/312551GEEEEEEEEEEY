using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sellshort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private static void Output()
        {
            int[] arr = new int[] { 56, 12, 99, 32, 1, 95, 25, 5, 100, 84 };
            int n = arr.Length;
            int i;
            Console.WriteLine("Shell Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            shellSort(arr, n);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        private static void shellSort(int[] arr, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Output();
        }
    }
}
