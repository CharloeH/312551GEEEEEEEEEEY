using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace _312551Ethanbiggey
{
    /// <summary>
    /// Interaction logic for TEst.xaml
    /// </summary>
    public partial class TEst : Window
    {
        public enum Diriiiiii { DOWN, UP, LEFT, RIGHT }
        List<Window> WAII = new List<Window>();
        bool isCloseable = false;
        DispatcherTimer GameTimer = new DispatcherTimer();
        public TEst()
        {
            InitializeComponent();

            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1 / int.MaxValue);//fps
            GameTimer.Start();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

           
                int i = random.Next(1, 400);
                int[] ii = new int[3];
                ii[0] = random.Next(0, 256);
                ii[1] = random.Next(0, 256);
                ii[2] = random.Next(0, 256);
                int iii = random.Next(0, 361);
                double[] iiii = new double[2];
                iiii[0] = random.Next(0, 100);
                iiii[1] = random.Next(0, 100);
                int[] iiiii = new int[3];
                iiiii[0] = random.Next(0, 256);
                iiiii[1] = random.Next(0, 256);
                iiiii[2] = random.Next(0, 256);
                int[] iiiiii = new int[3];
                iiiiii[0] = random.Next(0, 256);
                iiiiii[1] = random.Next(0, 256);
                iiiiii[2] = random.Next(0, 256);
                int[] iiiiiii = new int[3];
                iiiiiii[0] = random.Next(0, 256);
                iiiiiii[1] = random.Next(0, 256);
                iiiiiii[2] = random.Next(0, 256);
                windowi.Background = new SolidColorBrush(Color.FromRgb((byte)iiiiiii[0], (byte)iiiiiii[1], (byte)iiiiiii[2]));
                stckGey.Background = new SolidColorBrush(Color.FromRgb((byte)iiiiii[0], (byte)iiiiii[1], (byte)iiiiii[2]));
                txtBx.Foreground = new SolidColorBrush(Color.FromRgb((byte)ii[0], (byte)ii[1], (byte)ii[2]));
                txtBx.Background = new SolidColorBrush(Color.FromRgb((byte)iiiii[0], (byte)iiiii[1], (byte)iiiii[2]));

                txtBx.FontSize = i;
                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = iii;
                stckGey.RenderTransformOrigin = new Point(iiii[0] / 100, iiii[1] / 100);
                stckGey.RenderTransform = new RotateTransform { Angle = iii };


                int[] aiaiaiaiai = new int[] { random.Next(0, 1024), random.Next(0, 1280) };
                windowi.Height = aiaiaiaiai[0];
                windowi.Width = aiaiaiaiai[1];
                RotateTransform rotateTransformi = new RotateTransform();
                rotateTransformi.Angle = iii;
                windowi.RenderTransformOrigin = new Point(iiii[0] / 100, iiii[1] / 100);
                txtBx.Text = "Ethan big gey";

            if (Keyboard.IsKeyDown(Key.LeftAlt) && Keyboard.IsKeyDown(Key.F4))
            {
                Diriiiiii driiii = (Diriiiiii)(new Random()).Next(0, 3);
                MainWindow gey = new MainWindow();
                gey.Show();
                gey.Activate();

                SendKeys.SendWait("^(%({LEFT}))");
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.RightAlt))
            {
                isCloseable = true;
            }
            if (isCloseable == false)
                e.Cancel = true;
        }
    }
}
