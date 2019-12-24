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
namespace KeyboardTrainer2
{
    class Keyboard
    {
        MainWindow window;
        Brush savedBrush;
        Border saveBorder;
        bool isKeyPresed=false;
        public Keyboard(MainWindow window)
        {
            this.window = window;
        }
        public void KeyboardInput(KeyEventArgs e)
        {
            if(isKeyPresed)
            {
                KeyboardReset();
            }
            isKeyPresed = true;
            switch (e.Key)
            {
                case Key.OemTilde:
                    SaveBorder(ref window._0_0B);
                    break;
                case Key.D1:
                    SaveBorder(ref window._0_1B);
                    break;
                case Key.D2:
                    SaveBorder(ref window._0_2B);
                    break;
                case Key.D3:
                    SaveBorder(ref window._0_3B);
                    break;
                case Key.D4:
                    SaveBorder(ref window._0_4B);
                    break;
                case Key.D5:
                    SaveBorder(ref window._0_5B);
                    break;
                case Key.D6:
                    SaveBorder(ref window._0_6B);
                    break;
                case Key.D7:
                    SaveBorder(ref window._0_7B);
                    break;
                case Key.D8:
                    SaveBorder(ref window._0_8B);
                    break;
                case Key.D9:
                    SaveBorder(ref window._0_9B);
                    break;
                case Key.D0:
                    SaveBorder(ref window._0_10B);
                    break;
                case Key.OemMinus:
                    SaveBorder(ref window._0_11B);
                    break;
                case Key.OemPlus:
                    SaveBorder(ref window._0_12B);
                    break;
                case Key.Back:
                    SaveBorder(ref window._0_13B);
                    break;
                //////////////////////////////////////////////////////////////////////////
                case Key.Tab:
                    SaveBorder(ref window._1_0B);
                    break;
                case Key.Q:
                    SaveBorder(ref window._1_1B);
                    break;
                case Key.W:
                    SaveBorder(ref window._1_2B);
                    break;
                case Key.E:
                    SaveBorder(ref window._1_3B);
                    break;
                case Key.R:
                    SaveBorder(ref window._1_4B);
                    break;
                case Key.T:
                    SaveBorder(ref window._1_5B);
                    break;
                case Key.Y:
                    SaveBorder(ref window._1_6B);
                    break;
                case Key.U:
                    SaveBorder(ref window._1_7B);
                    break;
                case Key.I:
                    SaveBorder(ref window._1_8B);
                    break;
                case Key.O:
                    SaveBorder(ref window._1_9B);
                    break;
                case Key.P:
                    SaveBorder(ref window._1_10B);
                    break;
                case Key.OemOpenBrackets:
                    SaveBorder(ref window._1_11B);
                    break;
                case Key.OemCloseBrackets:
                    SaveBorder(ref window._1_12B);
                    break;
                case Key.OemPipe:
                    SaveBorder(ref window._1_13B);
                    break;
                //////////////////////////////////////////////////////////////////////////////////////////////
                case Key.CapsLock:
                    SaveBorder(ref window._2_0B);
                    break;
                case Key.A:
                    SaveBorder(ref window._2_1B);
                    break;
                case Key.S:
                    SaveBorder(ref window._2_2B);
                    break;
                case Key.D:
                    SaveBorder(ref window._2_3B);
                    break;
                case Key.F:
                    SaveBorder(ref window._2_4B);
                    break;
                case Key.G:
                    SaveBorder(ref window._2_5B);
                    break;
                case Key.H:
                    SaveBorder(ref window._2_6B);
                    break;
                case Key.J:
                    SaveBorder(ref window._2_7B);
                    break;
                case Key.K:
                    SaveBorder(ref window._2_8B);
                    break;
                case Key.L:
                    SaveBorder(ref window._2_9B);
                    break;
                case Key.OemSemicolon:
                    SaveBorder(ref window._2_10B);
                    break;
                case Key.OemQuotes:
                    SaveBorder(ref window._2_11B);
                    break;
                case Key.Enter:
                    SaveBorder(ref window._2_12B);
                    break;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Key.LeftShift:
                    SaveBorder(ref window._3_0B);
                    break;
                case Key.Z:
                    SaveBorder(ref window._3_1B);
                    break;
                case Key.X:
                    SaveBorder(ref window._3_2B);
                    break;
                case Key.C:
                    SaveBorder(ref window._3_3B);
                    break;
                case Key.V:
                    SaveBorder(ref window._3_4B);
                    break;
                case Key.B:
                    SaveBorder(ref window._3_5B);
                    break;
                case Key.N:
                    SaveBorder(ref window._3_6B);
                    break;
                case Key.M:
                    SaveBorder(ref window._3_7B);
                    break;
                case Key.OemComma:
                    SaveBorder(ref window._3_8B);
                    break;
                case Key.OemPeriod:
                    SaveBorder(ref window._3_9B);
                    break;
                case Key.OemQuestion:
                    SaveBorder(ref window._3_10B);
                    break;
                case Key.RightShift:
                    SaveBorder(ref window._3_11B);
                    break;
                /////////////////////////////////////////////////////////////////////////////////
                case Key.LeftCtrl:
                    SaveBorder(ref window._4_0B);
                    break;
                case Key.LWin:
                    SaveBorder(ref window._4_1B);
                    break;
                case Key.LeftAlt:
                    SaveBorder(ref window._4_2B);
                    break;
                case Key.Space:
                    SaveBorder(ref window._4_3B);
                    break;
                case Key.RightAlt:
                    SaveBorder(ref window._4_4B);
                    break;
                case Key.RWin:
                    SaveBorder(ref window._4_5B);
                    break;
                case Key.RightCtrl:
                    SaveBorder(ref window._4_6B);
                    break;

                default:
                    Error();
                    break;
            }
        }

        public string ConvertInputedKey(bool isUppercase,bool  isUppercase_CapsLock, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.OemTilde:
                    if (isUppercase)
                    {
                        return "~";
                    }
                    else
                    {
                        return "`";
                    }
                case Key.D1:
                    if (isUppercase)
                    {
                        return "!";
                    }
                    else
                    {
                        return "1";
                    }
                case Key.D2:
                    if (isUppercase)
                    {
                        return "@";
                    }
                    else
                    {
                        return "2";
                    }
                case Key.D3:
                    if (isUppercase)
                    {
                        return "#";
                    }
                    else
                    {
                        return "3";
                    }
                case Key.D4:
                    if (isUppercase)
                    {
                        return "$";
                    }
                    else
                    {
                        return "4";
                    }
                case Key.D5:
                    if (isUppercase)
                    {
                        return "%";
                    }
                    else
                    {
                        return "5";
                    }
                case Key.D6:
                    if (isUppercase)
                    {
                        return "^";
                    }
                    else
                    {
                        return "6";
                    }
                case Key.D7:
                    if (isUppercase)
                    {
                        return "&";
                    }
                    else
                    {
                        return "7";
                    }
                case Key.D8:
                    if (isUppercase)
                    {
                        return "*";
                    }
                    else
                    {
                        return "8";
                    }
                case Key.D9:
                    if (isUppercase)
                    {
                        return "(";
                    }
                    else
                    {
                        return "9";
                    }
                case Key.D0:
                    if (isUppercase)
                    {
                        return ")";
                    }
                    else
                    {
                        return "0";
                    }
                case Key.OemMinus:
                    if (isUppercase)
                    {
                        return "_";
                    }
                    else
                    {
                        return "-";
                    }
                case Key.OemPlus:
                    if (isUppercase)
                    {
                        return "+";
                    }
                    else
                    {
                        return "=";
                    }
                //////////////////////////////////////////////////////////////////////////
                case Key.Q:
                    if (isUppercase||isUppercase_CapsLock)
                    {
                        return "Q";
                    }
                    else
                    {
                        return "q";
                    }
                case Key.W:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "W";
                    }
                    else
                    {
                        return "w";
                    }
                case Key.E:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "E";
                    }
                    else
                    {
                        return "e";
                    }
                case Key.R:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "R";
                    }
                    else
                    {
                        return "r";
                    }
                case Key.T:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "T";
                    }
                    else
                    {
                        return "t";
                    }
                case Key.Y:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "Y";
                    }
                    else
                    {
                        return "y";
                    }
                case Key.U:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "U";
                    }
                    else
                    {
                        return "u";
                    }
                case Key.I:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "I";
                    }
                    else
                    {
                        return "i";
                    }
                case Key.O:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "O";
                    }
                    else
                    {
                        return "o";
                    }
                case Key.P:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "P";
                    }
                    else
                    {
                        return "p";
                    }
                case Key.OemOpenBrackets:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "{";
                    }
                    else
                    {
                        return "[";
                    }
                case Key.OemCloseBrackets:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "}";
                    }
                    else
                    {
                        return "]";
                    }
                case Key.OemPipe:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "|";
                    }
                    else
                    {
                        return "\\";
                    }
                //////////////////////////////////////////////////////////////////////////////////////////////
                case Key.A:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "A";
                    }
                    else
                    {
                        return "a";
                    }
                case Key.S:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "S";
                    }
                    else
                    {
                        return "s";
                    }
                case Key.D:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "D";
                    }
                    else
                    {
                        return "d";
                    }
                case Key.F:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "F";
                    }
                    else
                    {
                        return "f";
                    }
                case Key.G:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "G";
                    }
                    else
                    {
                        return "g";
                    }
                case Key.H:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "H";
                    }
                    else
                    {
                        return "h";
                    }
                case Key.J:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "J";
                    }
                    else
                    {
                        return "j";
                    }
                case Key.K:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "K";
                    }
                    else
                    {
                        return "k";
                    }
                case Key.L:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "L";
                    }
                    else
                    {
                        return "l";
                    }
                case Key.OemSemicolon:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return ":";
                    }
                    else
                    {
                        return ";";
                    }
                case Key.OemQuotes:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "\"";
                    }
                    else
                    {
                        return "'";
                    }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Key.Z:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "Z";
                    }
                    else
                    {
                        return "z";
                    }
                case Key.X:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "X";
                    }
                    else
                    {
                        return "x";
                    }
                case Key.C:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "C";
                    }
                    else
                    {
                        return "c";
                    }
                case Key.V:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "V";
                    }
                    else
                    {
                        return "v";
                    }
                case Key.B:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "B";
                    }
                    else
                    {
                        return "b";
                    }
                case Key.N:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "N";
                    }
                    else
                    {
                        return "n";
                    }
                case Key.M:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "M";
                    }
                    else
                    {
                        return "m";
                    }
                case Key.OemComma:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "<";
                    }
                    else
                    {
                        return ",";
                    }
                case Key.OemPeriod:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return ">";
                    }
                    else
                    {
                        return ".";
                    }
                case Key.OemQuestion:
                    if (isUppercase || isUppercase_CapsLock)
                    {
                        return "?";
                    }
                    else
                    {
                        return "/";
                    }
                /////////////////////////////////////////////////////////////////////////////////
                case Key.Space:
                    return " ";
                default:
                    return "";
            }
        }

        public void Error()
        {
            saveBorder = window.MVBorder;
            savedBrush = window.MVBorder.Background;
            window.MVBorder.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }
        public void GenerateKeys(bool isUppercase, bool isUppercase_CapsLock)
        {
            if(isUppercase|| isUppercase_CapsLock)
            {
                if (!isUppercase_CapsLock)
                {
                    window._0_0.Content = "~";
                    window._0_1.Content = "!";
                    window._0_2.Content = "@";
                    window._0_3.Content = "#";
                    window._0_4.Content = "$";
                    window._0_5.Content = "%";
                    window._0_6.Content = "^";
                    window._0_7.Content = "&";
                    window._0_8.Content = "*";
                    window._0_9.Content = "(";
                    window._0_10.Content = ")";
                    window._0_11.Content = "_";
                    window._0_12.Content = "+";

                    window._1_11.Content = "{";
                    window._1_12.Content = "}";
                    window._1_13.Content = "|";

                    window._2_10.Content = ":";
                    window._2_11.Content = "\"";

                    window._3_8.Content = "<";
                    window._3_9.Content = ">";
                    window._3_10.Content = "?";
                }
                window._1_1.Content = "Q";
                window._1_2.Content = "W";
                window._1_3.Content = "E";
                window._1_4.Content = "R";
                window._1_5.Content = "T";
                window._1_6.Content = "Y";
                window._1_7.Content = "U";
                window._1_8.Content = "I";
                window._1_9.Content = "O";
                window._1_10.Content = "P";
                
                window._2_1.Content = "A";
                window._2_2.Content = "S";
                window._2_3.Content = "D";
                window._2_4.Content = "F";
                window._2_5.Content = "G";
                window._2_6.Content = "H";
                window._2_7.Content = "J";
                window._2_8.Content = "K";
                window._2_9.Content = "L";
                
                window._3_1.Content = "Z";
                window._3_2.Content = "X";
                window._3_3.Content = "C";
                window._3_4.Content = "V";
                window._3_5.Content = "B";
                window._3_6.Content = "N";
                window._3_7.Content = "M";
                
            }
            else
            {
                window._0_0.Content = "`";
                window._0_1.Content = "1";
                window._0_2.Content = "2";
                window._0_3.Content = "3";
                window._0_4.Content = "4";
                window._0_5.Content = "5";
                window._0_6.Content = "6";
                window._0_7.Content = "7";
                window._0_8.Content = "8";
                window._0_9.Content = "9";
                window._0_10.Content = "0";
                window._0_11.Content = "-";
                window._0_12.Content = "=";
                window._1_1.Content = "q";
                window._1_2.Content = "w";
                window._1_3.Content = "e";
                window._1_4.Content = "r";
                window._1_5.Content = "t";
                window._1_6.Content = "y";
                window._1_7.Content = "u";
                window._1_8.Content = "i";
                window._1_9.Content = "o";
                window._1_10.Content = "p";
                window._1_11.Content = "[";
                window._1_12.Content = "]";
                window._1_13.Content = "\\";
                window._2_1.Content = "a";
                window._2_2.Content = "s";
                window._2_3.Content = "d";
                window._2_4.Content = "f";
                window._2_5.Content = "g";
                window._2_6.Content = "h";
                window._2_7.Content = "j";
                window._2_8.Content = "k";
                window._2_9.Content = "l";
                window._2_10.Content = ";";
                window._2_11.Content = "\'";
                window._3_1.Content = "z";
                window._3_2.Content = "x";
                window._3_3.Content = "c";
                window._3_4.Content = "v";
                window._3_5.Content = "b";
                window._3_6.Content = "n";
                window._3_7.Content = "m";
                window._3_8.Content = ",";
                window._3_9.Content = ".";
                window._3_10.Content = "/";
            }
        }
        private void SaveBorder(ref Border border)
        {
            saveBorder = border;
            savedBrush = border.Background;
            border.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
        }
        public void KeyboardReset()
        {
            saveBorder.Background = savedBrush;
            isKeyPresed = false;
        }
    }
}
