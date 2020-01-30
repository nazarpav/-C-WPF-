using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExam
{
    class Drawing
    {
    private TilesNum ConvertNumToTilesNum(int num)
    {
        switch (num)
        {
            case 0:
                return TilesNum._0;
            case 2:
                return TilesNum._2;
            case 4:
                return TilesNum._4;
            case 8:
                return TilesNum._8;
            case 16:
                return TilesNum._16;
            case 32:
                return TilesNum._32;
            case 64:
                return TilesNum._64;
            case 128:
                return TilesNum._128;
            case 256:
                return TilesNum._256;
            case 512:
                return TilesNum._512;
            case 1024:
                return TilesNum._1024;
            case 2048:
                return TilesNum._2048;
            case 4096:
                return TilesNum._4096;
            case 8192:
                return TilesNum._8192;
            case 16384:
                return TilesNum._16384;
            default:
                    return TilesNum._0;
        }
    }
        private Brush GetColor(TilesNum num)
        {
            switch (num)
            {
                case TilesNum._0:
                    return Brushes.Chocolate;
                case TilesNum._2:
                    return Brushes.SandyBrown;
                case TilesNum._4:
                    return Brushes.DarkSalmon;
                case TilesNum._8:
                    return Brushes.YellowGreen;
                case TilesNum._16:
                    return Brushes.DarkOrchid;
                case TilesNum._32:
                    return Brushes.Firebrick;
                case TilesNum._64:
                    return Brushes.OliveDrab;
                case TilesNum._128:
                    return Brushes.DarkOliveGreen;
                case TilesNum._256:
                    return Brushes.DarkTurquoise;
                case TilesNum._512:
                    return Brushes.DarkSlateGray;
                case TilesNum._1024:
                    return Brushes.Red;
                case TilesNum._2048:
                    return Brushes.MediumSlateBlue;
                case TilesNum._4096:
                    return Brushes.DarkMagenta;
                case TilesNum._8192:
                    return Brushes.Goldenrod;
                case TilesNum._16384:
                    return Brushes.DarkRed;
                default:
                    return Brushes.Chocolate;
            }
        }
        public void Draw(int[][] arr, MainWindow mw)
        {
            mw._00.Content = arr[0][0] == 0 ? "" : arr[0][0].ToString();
            mw.B00.Background = GetColor(ConvertNumToTilesNum(arr[0][0]));
            mw._01.Content = arr[0][1] == 0 ? "" : arr[0][1].ToString();
            mw.B01.Background = GetColor(ConvertNumToTilesNum(arr[0][1]));
            mw._02.Content = arr[0][2] == 0 ? "" : arr[0][2].ToString();
            mw.B02.Background = GetColor(ConvertNumToTilesNum(arr[0][2]));
            mw._03.Content = arr[0][3] == 0 ? "" : arr[0][3].ToString();
            mw.B03.Background = GetColor(ConvertNumToTilesNum(arr[0][3]));
            mw._10.Content = arr[1][0] == 0 ? "" : arr[1][0].ToString();
            mw.B10.Background = GetColor(ConvertNumToTilesNum(arr[1][0]));
            mw._11.Content = arr[1][1] == 0 ? "" : arr[1][1].ToString();
            mw.B11.Background = GetColor(ConvertNumToTilesNum(arr[1][1]));
            mw._12.Content = arr[1][2] == 0 ? "" : arr[1][2].ToString();
            mw.B12.Background = GetColor(ConvertNumToTilesNum(arr[1][2]));
            mw._13.Content = arr[1][3] == 0 ? "" : arr[1][3].ToString();
            mw.B13.Background = GetColor(ConvertNumToTilesNum(arr[1][3]));
            mw._20.Content = arr[2][0] == 0 ? "" : arr[2][0].ToString();
            mw.B20.Background = GetColor(ConvertNumToTilesNum(arr[2][0]));
            mw._21.Content = arr[2][1] == 0 ? "" : arr[2][1].ToString();
            mw.B21.Background = GetColor(ConvertNumToTilesNum(arr[2][1]));
            mw._22.Content = arr[2][2] == 0 ? "" : arr[2][2].ToString();
            mw.B22.Background = GetColor(ConvertNumToTilesNum(arr[2][2]));
            mw._23.Content = arr[2][3] == 0 ? "" : arr[2][3].ToString();
            mw.B23.Background = GetColor(ConvertNumToTilesNum(arr[2][3]));
            mw._30.Content = arr[3][0] == 0 ? "" : arr[3][0].ToString();
            mw.B30.Background = GetColor(ConvertNumToTilesNum(arr[3][0]));
            mw._31.Content = arr[3][1] == 0 ? "" : arr[3][1].ToString();
            mw.B31.Background = GetColor(ConvertNumToTilesNum(arr[3][1]));
            mw._32.Content = arr[3][2] == 0 ? "" : arr[3][2].ToString();
            mw.B32.Background = GetColor(ConvertNumToTilesNum(arr[3][2]));
            mw._33.Content = arr[3][3] == 0 ? "" : arr[3][3].ToString();
            mw.B33.Background = GetColor(ConvertNumToTilesNum(arr[3][3]));
        }
    }
}
