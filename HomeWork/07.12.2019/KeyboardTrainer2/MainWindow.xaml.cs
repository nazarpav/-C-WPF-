using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace KeyboardTrainer2
{
    
    public partial class MainWindow : Window
    {
        private string tmp = String.Empty;
        private int counter = 0;
        private Keyboard keyboard;
        private bool isUppercase=false;
        private bool isUppercase_CapsLock=false;
        private Random rnd = new Random();
        private DispatcherTimer timer;
        private int quantityEnteredSymbolPerMinutes;
        private bool IsGame = false;
        private SoundPlayer eror = new SoundPlayer("erorS.wav");
        private void TimerTick(object sender, EventArgs e)
        {
            Time.Content = Math.Round(float.Parse(Time.Content.ToString()) + 0.1f,1).ToString();
            if(float.Parse(Time.Content.ToString())%1==0)
            {
                CharPerMin.Content = quantityEnteredSymbolPerMinutes * 60;
                quantityEnteredSymbolPerMinutes = 0;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            keyboard = new Keyboard(this);
            keyboard.GenerateKeys(isUppercase, isUppercase_CapsLock);
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            Time.Content = 0;
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(1000000);
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsGame)
            {
                return;
            }
            if(e.Key==Key.LeftShift|| e.Key == Key.RightShift)
            {
                isUppercase = true;
            }
            else if(e.Key==Key.CapsLock)
            {
                isUppercase_CapsLock = !isUppercase_CapsLock;
            }
            keyboard.KeyboardInput(e);

            keyboard.GenerateKeys(isUppercase, isUppercase_CapsLock);
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsGame)
            {
                return;
            }
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                isUppercase = false;
            }
            keyboard.KeyboardReset();
            tmp = keyboard.ConvertInputedKey(isUppercase, isUppercase_CapsLock, e);
            if (StringForComparison.Content?.ToString()[counter].ToString() == tmp)
            {
                ++counter;
                ++quantityEnteredSymbolPerMinutes;
                InputtedString.Content += tmp;
            }
            else if (e.Key != Key.LeftShift && e.Key != Key.RightShift && e.Key != Key.CapsLock)
            {
                Mistakes.Content = int.Parse(Mistakes.Content.ToString()) + 1;
                eror.Play();
            }
            if(StringForComparison.Content?.ToString()== InputtedString.Content?.ToString())
            {
                Compleated.Content = int.Parse(Compleated.Content.ToString()) + 1;
                StringForComparison.Content = GenerateText();
                counter = 0;
                InputtedString.Content = "";
            }



            keyboard.GenerateKeys(isUppercase, isUppercase_CapsLock);
        }

        private string GenerateText()
        {
            string result = string.Empty;
            if (LEasy.IsSelected)
            {
                for (int i = 0; i < 20; i++)
                {
                    result += (char)rnd.Next(97, 123);

                }
            }
            else if (LMedium.IsSelected)
            {
                for (int i = 0; i < 15; i++)
                {
                    result += (char)rnd.Next(97, 123);
                    result += (char)rnd.Next(48, 58);

                }
            }
            else if (LHard.IsSelected)
            {
                for (int i = 0; i < 40; i++)
                {
                    result += (char)rnd.Next(32, 127);

                }
            }
            return result;
        }
        private void ButtonClickStart(object sender, RoutedEventArgs e)
        {
            if (IsGame)
            {
                return;
            }
            StringForComparison.Content = GenerateText();
            timer.Start();
            Compleated.Content = "0";
            IsGame = true;
            ReloadData();
        }
        
        private void ReloadData()
        {
            if (!IsGame)
            {
                return;
            }
            Time.Content = 0;
            Mistakes.Content = "0";
            StringForComparison.Content = GenerateText();
            counter = 0;
            InputtedString.Content = "";
        }

        private void ButtonClickRestart(object sender, RoutedEventArgs e)
        {
            if (!IsGame)
            {
                return;
            }
            InputtedString.Content = "";
            StringForComparison.Content = GenerateText();
        }
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (!IsGame)
            {
                return;
            }
            timer.Stop();
            LabelInPause.Visibility = Visibility.Visible;
            IsGame = false;
        }

        private void LabelInPause_MouseEnter(object sender, MouseEventArgs e)
        {
            timer.Start();
            LabelInPause.Visibility = Visibility.Hidden;
            IsGame = true;
        }
    }
}
