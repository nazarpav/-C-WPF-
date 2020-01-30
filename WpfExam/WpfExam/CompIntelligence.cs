using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExam
{
    class CompIntelligence
    {
        private Random rnd;
        public CompIntelligence()
        {
            rnd = new Random();
        }
        public Direction MakeStep(int[][] arr, int QuantityCollumAndRowInMainGrid)
        {
            for (int i = 0; i < QuantityCollumAndRowInMainGrid - 1; i++)
            {
                for (int j = 0; j < QuantityCollumAndRowInMainGrid; j++)
                {
                    if (arr[i][j] != 0 && arr[i][j] == arr[i + 1][j])
                    {
                        return Direction.UP;
                    }
                }
            }
            for (int i = 0; i < QuantityCollumAndRowInMainGrid; i++)
            {
                for (int j = 0; j < QuantityCollumAndRowInMainGrid - 1; j++)
                {
                    if (arr[i][j] != 0 && arr[i][j] == arr[i][j+1])
                    {
                        return Direction.LEFT;
                    }
                }
            }
            switch (rnd.Next(0, 4))
            {
                case 0:
                    return Direction.UP;
                case 1:
                    return Direction.DOWN;
                case 2:
                    return Direction.RIGHT;
                case 3:
                    return Direction.LEFT;
                default:
                    return Direction.NONE;
            }
        }
    }
}
