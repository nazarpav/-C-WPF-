using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfExam
{
    public partial class MainWindow : Window
    {
        private Drawing drawing;
        private GameLogic gameLogic;
        private bool IsGameOver = false;
        private CompIntelligence _compIntelligence;
        public MainWindow()
        {
            InitializeComponent();
            drawing = new Drawing();
            gameLogic = new GameLogic();
            drawing.Draw(gameLogic.GetARR(), this);
            _compIntelligence = new CompIntelligence();
            MaxScore.Content = "0";
            ReadScoreFromFile();
        }
        private void ReadScoreFromFile()
        {
            using (FileStream fstream = File.OpenRead("SaveMaxScore.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                MaxScore.Content = Encoding.Default.GetString(array);
            }
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsGameOver)
            {
                return;
            }
            switch (e.Key)
            {
                case Key.Up:
                    Step(Direction.UP);
                    drawing.Draw(gameLogic.GetARR(), this);
                    break;
                case Key.Down:
                    Step(Direction.DOWN);
                    drawing.Draw(gameLogic.GetARR(), this);
                    break;
                case Key.Left:
                    Step(Direction.LEFT);
                    drawing.Draw(gameLogic.GetARR(), this);
                    break;
                case Key.Right:
                    Step(Direction.RIGHT);
                    drawing.Draw(gameLogic.GetARR(), this);
                    break;
                case Key.F1:
                    gameLogic.TestTile();
                    drawing.Draw(gameLogic.GetARR(), this);
                    break;
                case Key.F2:
                    QOP.Content = "0";
                    while (true)
                    {
                        QOP.Content = int.Parse(QOP.Content.ToString())+1;

                        if (CompIntelligenceStart() > int.Parse(MaxScore.Content.ToString()))
                        {
                            break;
                        }
                        else
                        {
                            GameOver_();
                        }
                    }
                    break;
                case Key.R:
                    GameOver_();
                    break;
            }
            Score.Content = gameLogic.Score.ToString();
        }
        private int CompIntelligenceStart()
        {
            while (!gameLogic.IsFull())
            {
                Step(_compIntelligence.MakeStep(gameLogic.GetARR(),gameLogic.GetQCRIM()));
                drawing.Draw(gameLogic.GetARR(), this);
            }
            return gameLogic.Score;
        }
        private void GameOver_MouseUp(object sender, MouseButtonEventArgs e)
        {
            GameOver_();
        }
        private void GameOverLoad()
        {
            GameOver.Visibility = Visibility.Visible;
            IsGameOver = true;
        }
        private void GameOver_()
        {
            if (gameLogic.Score > int.Parse(MaxScore.Content.ToString()))
            {
                MaxScore.Content = gameLogic.Score;
            }
            gameLogic = new GameLogic();
            drawing.Draw(gameLogic.GetARR(), this);
            GameOver.Visibility = Visibility.Hidden;
            Score.Content = "0";
            IsGameOver = false;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            using (FileStream fstream = new FileStream("SaveMaxScore.txt", FileMode.Truncate))
            {
                byte[] array = Encoding.Default.GetBytes(MaxScore.Content.ToString());
                fstream.Write(array, 0, array.Length);
            }
        }
        private void Step(Direction dir)
        {
            if (gameLogic.Displace(dir))
            {
                if (!gameLogic.AddTile())
                {
                    GameOverLoad();
                }
            }
            if (gameLogic.TileMerge(dir))
            {
                if (!gameLogic.AddTile())
                {
                    GameOverLoad();
                }
            }
            gameLogic.Displace(dir);
        }
    }
}
