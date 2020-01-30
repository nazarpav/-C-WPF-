using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExam
{
    class GameLogic
    {
        private const int QuantityCollumAndRowInMainGrid = 4;
        private int[][] arr;
        private Random rnd;
        public int Score { get; private set; }
        public int GetQCRIM()
        {
            return QuantityCollumAndRowInMainGrid;
        }
        public int[][] GetARR()
        {
            return arr;
        }
        public void TestTile()
        {
            arr[0][0] = 0;
            arr[0][1] = 2;
            arr[0][2] = 4;
            arr[0][3] = 8;
            arr[1][0] = 16;
            arr[1][1] = 32;
            arr[1][2] = 64;
            arr[1][3] = 128;
            arr[2][0] = 256;
            arr[2][1] = 512;
            arr[2][2] = 1024;
            arr[2][3] = 2048;
            arr[3][0] = 4096;
            arr[3][1] = 8192;
            arr[3][2] = 16384;
        } 
        public bool IsFull()
        {
            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    if(arr[i][j]==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool AddTile()
        {
            int ind1;
            int ind2;
            while (!IsFull())
            {
                ind1 = rnd.Next(0, QuantityCollumAndRowInMainGrid);
                ind2 = rnd.Next(0, QuantityCollumAndRowInMainGrid);
                if (arr[ind1][ind2] == 0)
                {
                    arr[ind1][ind2] = GetNewNum();
                    return true;
                }
            }
            return false;
        }
        public bool Displace(Direction dir)
        {
            int[][] SaveArr = new int[QuantityCollumAndRowInMainGrid][];
            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                SaveArr[i] = new int[QuantityCollumAndRowInMainGrid];
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    SaveArr[i][j] = arr[i][j];
                }
            }

            for (int g = 0; g < QuantityCollumAndRowInMainGrid; g++)
            {
                switch (dir)
                {
                    case Direction.UP:
                        for (int i = 0; i < QuantityCollumAndRowInMainGrid - 1; i++)
                        {
                            for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                            {
                                if (arr[i][j] == 0)
                                {
                                    arr[i][j] = arr[i + 1][j];
                                    arr[i + 1][j] = 0;
                                }
                            }
                        }
                        break;
                    case Direction.DOWN:
                        for (int i = QuantityCollumAndRowInMainGrid-1; i > 0; i--)
                        {
                            for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                            {
                                if (arr[i][j] == 0)
                                {
                                    arr[i][j] = arr[i - 1][j];
                                    arr[i - 1][j] = 0;
                                }
                            }
                        }
                        break;
                    case Direction.LEFT:
                        for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
                        {
                            for (int j = 0; j < QuantityCollumAndRowInMainGrid-1; j++)
                            {
                                if (arr[i][j] == 0)
                                {
                                    arr[i][j] = arr[i][j+1];
                                    arr[i][j+1] = 0;
                                }
                            }
                        }
                        break;
                    case Direction.RIGHT:
                        for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
                        {
                            for (int j = QuantityCollumAndRowInMainGrid - 1; j > 0 ; j--)
                            {
                                if (arr[i][j] == 0)
                                {
                                    arr[i][j] = arr[i][j - 1];
                                    arr[i][j - 1] = 0;
                                }
                            }
                        }
                        break;
                }
            }

            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    if (arr[i][j] != SaveArr[i][j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool TileMerge(Direction dir)
        {
            int[][] SaveArr = new int[QuantityCollumAndRowInMainGrid][];
            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                SaveArr[i] = new int[QuantityCollumAndRowInMainGrid];
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    SaveArr[i][j] = arr[i][j];
                }
            }

            switch (dir)
            {
                case Direction.UP:
                    for (int i = 0; i < QuantityCollumAndRowInMainGrid - 1; i++)
                    {
                        for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                        {
                            if (arr[i][j] != 0 && arr[i][j] == arr[i + 1][j])
                            {
                                arr[i][j] *= 2;
                                Score += arr[i][j];
                                arr[i + 1][j] = 0;
                            }
                        }
                    }
                    break;
                case Direction.DOWN:
                     for (int i = QuantityCollumAndRowInMainGrid - 1; i > 0; i--)
                    {
                        for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                        {
                            if (arr[i][j] != 0 && arr[i][j] == arr[i - 1][j])
                            {
                                arr[i][j] *= 2;
                                Score += arr[i][j];
                                arr[i - 1][j] = 0;
                            }
                        }
                    }
                    break;
                case Direction.LEFT:
                    for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
                    {
                        for (int j = 0; j < QuantityCollumAndRowInMainGrid - 1; j++)
                        {
                            if (arr[i][j] != 0 && arr[i][j] == arr[i][j+1])
                            {
                                arr[i][j] *= 2;
                                Score += arr[i][j];
                                arr[i][j+1] = 0;
                            }
                        }
                    }
                    break;
                case Direction.RIGHT:
                    for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
                    {
                        for (int j = QuantityCollumAndRowInMainGrid - 1; j > 0; j--)
                        {
                            if (arr[i][j] != 0 && arr[i][j] == arr[i][j - 1])
                            {
                                arr[i][j] *= 2;
                                Score += arr[i][j];
                                arr[i][j - 1] = 0;
                            }
                        }
                    }
                    break;
            }

            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    if (arr[i][j] != SaveArr[i][j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int GetNewNum()
        {
            if(rnd.Next(0,10)==0)
            {
                return 4;
            }
            else
            {
                return 2;
            }
        }
        public GameLogic()
        {
            arr = new int[QuantityCollumAndRowInMainGrid][];
            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                arr[i] = new int[QuantityCollumAndRowInMainGrid];
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    arr[i][j] = 0;
                }
            }
            rnd = new Random();
            AddTile();
            AddTile();
        }
    }
}
