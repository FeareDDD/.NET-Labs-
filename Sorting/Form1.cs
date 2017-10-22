using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    public partial class Form1 : Form
    {
        int numberOfElements;
        int maxValue;

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].IsVisibleInLegend = false;
            label3.Text = string.Empty;
        }

        private async void fillDataBtm_Click(object sender, EventArgs e)
        {
            // забрати сітку 
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            // перевіряєм на корректність вводу даних
            if (!CorrectData())
            {
                return;
            }

            // очищуєм чарт
            chart1.Series[0].Points.Clear();

            //запускаєм другий потік для заповнення чарту
            await Task.Run(() =>
            {
                var randomizer = new Random();

                for (int i = 0; i < numberOfElements; i++)
                {
                    var randomValue = randomizer.Next(maxValue);
                    // дьргаєм через чарт перший потік і добавляєм на нього значення
                    chart1.Invoke(new AddValueDelegate(AddValueToChart), randomValue);
                }
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                chart1.Invoke(new WorkerDelegate(DoWork));
            });
        }

        #region Update values in chart

        private delegate void WorkerDelegate();

        private void DoWork()
        {
            int min, temp;
            int length = chart1.Series[0].Points.Count;

            // створюоєм таймер
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (chart1.Series[0].Points[j].YValues[0] < chart1.Series[0].Points[min].YValues[0])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = (int)chart1.Series[0].Points[i].YValues[0];
                    chart1.Series[0].Points[i].YValues[0] = chart1.Series[0].Points[min].YValues[0];
                    chart1.Series[0].Points[min].YValues[0] = temp;
                    // перемальовуємо чарт
                    chart1.Refresh();
                }
            }

            stopWatch.Stop();
            // виводимо значення таймеру
            label3.Text = string.Format("Time = {0} miliseconds", stopWatch.ElapsedMilliseconds);
        }

        #endregion

        #region Add values to chart
        private delegate void AddValueDelegate(int value);

        private void AddValueToChart(int dataValue)
        {
            chart1.Series[0].Points.Add(dataValue);
        }
        #endregion

        #region Check entered values
        private bool CorrectData()
        {
            #region Usefull stuff
            if (textBox1.Text.Equals(@"/hhh", StringComparison.InvariantCultureIgnoreCase))
            {
                panel1.Visible = !panel1.Visible;
                return false;
            }
            #endregion

            if (!int.TryParse(textBox1.Text, out numberOfElements)
                || !int.TryParse(textBox2.Text, out maxValue))
            {
                MessageBox.Show("Not numeric data entered");
                return false;
            }

            if (numberOfElements < 0 && numberOfElements > 100000)
            {
                MessageBox.Show("Not valid number of elements entered"); 
                return false;
            }
            if (maxValue < 0 && maxValue > 100000)
            {
                MessageBox.Show("Not valid maxValue entered");
                return false;
            }
            return true;
        }
        #endregion
    }
}
