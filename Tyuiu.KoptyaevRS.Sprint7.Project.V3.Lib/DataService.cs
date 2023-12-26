using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public string[] Search(object[,] data, string targetElement)
        {
            bool ElementFound = false;
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            int targetRow = -1;
            int targetColumn = -1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j].Equals(targetElement))
                    {
                        ElementFound = true;
                        targetRow = i;
                        targetColumn = j;
                        break;
                    }
                }
                if (ElementFound)
                {
                    break;
                }
            }

            string[] result = new string[columns];
            if (ElementFound)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j] = data[targetRow, j].ToString();
                }
            }
            else
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j] = string.Empty;
                }
            }

            return result;
        }

        public double DataStatistics(object[,] data, string commandStat, int column)
        {
            int numRows = data.GetLength(0);
            int numColumns = data.GetLength(1);

            double result = 0;
            if (commandStat == "sum")
            {
                for (int i = 1; i < numRows; i++)
                {
                    result += Convert.ToInt32(data[i, column]);
                }

            }

            List<int> termsList = new List<int>();
            if (commandStat == "min")
            {
                for (int i = 1; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Min());
            }

            if (commandStat == "max")
            {
                for (int i = 1; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Max());
            }

            if (commandStat == "avarage")
            {
                double resSum = 0;
                for (int i = 1; i < numRows; i++)
                {
                    resSum += Convert.ToDouble(data[i, column]);
                }
                result = resSum / (numRows-1);
                result = Math.Round(result, 2);
            }

            return result;
        }
    }
}
