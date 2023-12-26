using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.KoptyaevRS.Sprint7.Project.V3.Lib;

namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KRS.Filter = "Значения, разделённые запятыми(*csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KRS.Filter = "Значения, разделённые запятыми(*csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                    
                }
            }
            return arrayValues;
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_KRS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRS.ShowDialog();
            openFilePath = openFileDialogTask_KRS.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewUniver_KRS.ColumnCount = columns;
            dataGridViewUniver_KRS.RowCount = rows-1;

            dataGridViewResult_KRS.ColumnCount = columns;
            dataGridViewResult_KRS.RowCount = rows - 1;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewUniver_KRS.Columns[i].Width = 100; 
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r == 0)
                    {
                        dataGridViewUniver_KRS.Columns[c].HeaderCell.Value = arrayValues[r, c];
                        dataGridViewResult_KRS.Columns[c].HeaderCell.Value = arrayValues[r, c];
                    }
                    else
                    {
                        dataGridViewUniver_KRS.Rows[r-1].Cells[c].Value = arrayValues[r, c];
                    }
                    
                }
            }
            this.dataGridViewUniver_KRS.Rows.Add("", "", "", "", "", "", "");
            buttonSave_KRS.Enabled = true;
            buttonSortDone_KRS.Enabled = true;
            buttonSearchDone_KRS.Enabled = true;
            buttonAddRows_KRS.Enabled = true;
            buttonDoneGraf_KRS.Enabled = true;
            buttonSum_KRS.Enabled = true;
            buttonMin_KRS.Enabled = true;
            buttonMax_KRS.Enabled = true;
            buttonAvarage_KRS.Enabled = true;
        }

        private void buttonSave_KRS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KRS.FileName = "OutPutFileProject.csv";
            saveFileDialogMatrix_KRS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KRS.ShowDialog();

            string path = saveFileDialogMatrix_KRS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewUniver_KRS.RowCount;
            int columns = dataGridViewUniver_KRS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewUniver_KRS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewUniver_KRS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSortDone_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBoxNumCol_KRS.Text);
                if (num >= 0 && num <= columns)
                {
                    if (num == 0)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[0, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 1)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[1, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 2)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[2, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 3)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[3, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 4)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[4, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 5)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[5, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                    if (num == 6)
                    {
                        for (int i = 0; i < dataGridViewUniver_KRS.Rows.Count - 1; i++)
                        {
                            dataGridViewUniver_KRS.Rows[i].Visible = dataGridViewUniver_KRS[6, i].Value.ToString() == textBoxWord_KRS.Text;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchDone_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_KRS.Text);

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(openFilePath), targetElement);
                
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_KRS.Rows[0].Cells[c].Value = arrayValues[c];
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_KRS_Click(object sender, EventArgs e)
        {
            this.dataGridViewUniver_KRS.Rows.Add("", "", "", "", "", "", "");
        }

        private void buttonDoneGraf_KRS_Click(object sender, EventArgs e)
        {
            this.chartGraf_KRS.ChartAreas[0].AxisX.Title = "Преподаватель";
            this.chartGraf_KRS.ChartAreas[0].AxisY.Title = "Количество часов";

            chartGraf_KRS.Series[0].Points.Clear();
            for (int r = 0; r < rows; r++)
            {
                chartGraf_KRS.Series[0].Points.AddXY(dataGridViewUniver_KRS.Rows[r].Cells[1].Value.ToString(), dataGridViewUniver_KRS.Rows[r].Cells[4].Value.ToString());
            }
        }

        private void buttonSum_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = "sum";
                int columnIndex = 4;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(openFilePath);

                textBoxOutPut_KRS.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMin_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = "min";
                int columnIndex = 4;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(openFilePath);

                textBoxOutPut_KRS.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMax_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = "max";
                int columnIndex = 4;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(openFilePath);

                textBoxOutPut_KRS.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvarage_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = "avarage";
                int columnIndex = 4;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(openFilePath);

                textBoxOutPut_KRS.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Сохранить";
        }

        private void buttonGuide_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonInfo_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Открыть информацию";
        }

        private void buttonAddRows_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonSearchDone_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonSortDone_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonDoneGraf_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonSum_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonMin_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonMax_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonAvarage_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Подсказка";
        }

        private void buttonGuide_KRS_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
