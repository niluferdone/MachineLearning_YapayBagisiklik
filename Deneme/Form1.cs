using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoScroll = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGrid.ColumnCount = 4;
            dataGrid.Columns[0].Name = "Index";
            dataGrid.Columns[1].Name = "x1";
            dataGrid.Columns[2].Name = "x2";
            dataGrid.Columns[3].Name = "fx";

            dataGridSıralama.ColumnCount = 4;
            dataGridSıralama.Columns[0].Name = "Index";
            dataGridSıralama.Columns[1].Name = "x1";
            dataGridSıralama.Columns[2].Name = "x2";
            dataGridSıralama.Columns[3].Name = "fx";

            dataGridIslem.ColumnCount = 4;
            dataGridIslem.Columns[0].Name = "Index";
            dataGridIslem.Columns[1].Name = "x1";
            dataGridIslem.Columns[2].Name = "x2";
            dataGridIslem.Columns[3].Name = "fx";

            dataGridAntijen.ColumnCount = 7;
            dataGridAntijen.Columns[0].Name = "Klon numarası";
            dataGridAntijen.Columns[1].Name = "C değeri";
            dataGridAntijen.Columns[2].Name = "x1";
            dataGridAntijen.Columns[3].Name = "x2";
            dataGridAntijen.Columns[4].Name = "fx";
            dataGridAntijen.Columns[5].Name = "x1 Mutasyon Katsayısı";
            dataGridAntijen.Columns[6].Name = "x2 Mutasyon Katsayısı";

            dataGridMutasyonx1.ColumnCount = 3;
            dataGridMutasyonx1.Columns[0].Name = "Index";
            dataGridMutasyonx1.Columns[1].Name = "x1";
            dataGridMutasyonx1.Columns[2].Name = "x1 mutasyon değeri";

            dataGridMutasyonx2.ColumnCount = 3;
            dataGridMutasyonx2.Columns[0].Name = "Index";
            dataGridMutasyonx2.Columns[1].Name = "x2";
            dataGridMutasyonx2.Columns[2].Name = "x2 mutasyon değeri";

            dataGridMutasyon2.ColumnCount = 4;
            dataGridMutasyon2.Columns[0].Name = "Index";
            dataGridMutasyon2.Columns[1].Name = "Yeni x1";
            dataGridMutasyon2.Columns[2].Name = "Yeni x2";
            dataGridMutasyon2.Columns[3].Name = "Yeni fx";

            dataGridIslem.ColumnCount = 4;
            dataGridIslem.Columns[0].Name = "Index";
            dataGridIslem.Columns[1].Name = "x1";
            dataGridIslem.Columns[2].Name = "x2";
            dataGridIslem.Columns[3].Name = "fx";

            dataGridMutasyon3.ColumnCount = 4;
            dataGridMutasyon3.Columns[0].Name = "Index";
            dataGridMutasyon3.Columns[1].Name = "x1";
            dataGridMutasyon3.Columns[2].Name = "x2";
            dataGridMutasyon3.Columns[3].Name = "fx";

            dataGridMutasyon4.ColumnCount = 4;
            dataGridMutasyon4.Columns[0].Name = "Index";
            dataGridMutasyon4.Columns[1].Name = "x1";
            dataGridMutasyon4.Columns[2].Name = "x2";
            dataGridMutasyon4.Columns[3].Name = "fx";

            dataGridYeniPopulasyon.ColumnCount = 4;
            dataGridYeniPopulasyon.Columns[0].Name = "Index";
            dataGridYeniPopulasyon.Columns[1].Name = "x1";
            dataGridYeniPopulasyon.Columns[2].Name = "x2";
            dataGridYeniPopulasyon.Columns[3].Name = "fx";
        }

        private void btnCalıstır_Click(object sender, EventArgs e)
        {
            int iterasyon = Convert.ToInt32(txtIterasyon.Text);
            int populasyon = Convert.ToInt32(txtPopulasyon.Text);
            int beta = Convert.ToInt32(txtBeta.Text);
            double max = 10.0;
            double min = -10.0;
            Random random = new Random();
            double mutasyon = Convert.ToDouble(txtMutasyon.Text);
            for (int t = 0; t < populasyon; t++)
            {
                double x1 = (random.NextDouble() * (max - min) + min);
                double x2 = (random.NextDouble() * (max - min) + min);
                double number1 = x1 + (2 * x2) - 7;
                double number2 = (2 * x1) + x2 - 5;
                double fx = (number1 * number1) + (number2 * number2);
                dataGrid.Rows.Add(t + 1, x1, x2, fx);

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int say = 1; say <= iterasyon; say++)
            {
                for (int p = 0; p < populasyon; p++)
                {
                    dataGridSıralama.Rows.Add(p + 1, dataGrid.Rows[p].Cells[1].Value, dataGrid.Rows[p].Cells[2].Value, dataGrid.Rows[p].Cells[3].Value);
                }
                dataGrid.Rows.Clear();
                dataGrid.DataSource = null;
                dataGrid.Refresh();


                dataGridSıralama.Sort(dataGridSıralama.Columns["fx"], ListSortDirection.Ascending);

                double sonuc = 0;
                var n = Convert.ToInt32(txtn.Text);
                for (int f = 0; f < n; f++)
                {
                    dataGridIslem.Rows.Add(f + 1, dataGridSıralama.Rows[f].Cells[1].Value, dataGridSıralama.Rows[f].Cells[2].Value, dataGridSıralama.Rows[f].Cells[3].Value);
                }


                for (int i = 1; i <= n; i++)
                {
                    double mn = 0;
                    double mx = 1;

                    int c = ((beta * populasyon) / i);
                    for (int j = 1; j <= c; j++)
                    {
                        double yenix1;
                        double yenix2;
                        double no1;
                        double no2;
                        double mkx1 = (random.NextDouble() * (mx - mn) + mn);
                        double mkx2 = (random.NextDouble() * (mx - mn) + mn);
                        dataGridAntijen.Rows.Add(j, (beta * populasyon) / i, dataGridIslem.Rows[i - 1].Cells[1].Value, dataGridIslem.Rows[i - 1].Cells[2].Value, dataGridIslem.Rows[i - 1].Cells[3].Value, mkx1, mkx2);
                        if (mkx1 <= mutasyon)
                        {
                            dataGridMutasyonx1.Rows.Add(j, dataGridIslem.Rows[i - 1].Cells[1].Value, mkx1);
                            yenix1 = (random.NextDouble() * (max - min) + min);
                        }
                        else
                        {
                            yenix1 = Convert.ToDouble(dataGridIslem.Rows[i - 1].Cells[1].Value);
                        }

                        if (mkx2 <= mutasyon)
                        {
                            dataGridMutasyonx2.Rows.Add(j, dataGridIslem.Rows[i - 1].Cells[2].Value, mkx2);
                            yenix2 = (random.NextDouble() * (max - min) + min);
                        }
                        else
                        {
                            yenix2 = Convert.ToDouble(dataGridIslem.Rows[i - 1].Cells[2].Value);
                        }
                        no1 = (yenix1 + (2 * yenix2) - 7);
                        no2 = ((2 * yenix1) + yenix2 - 5);
                        double yenifx = (no1 * no1) + (no2 * no2);
                        dataGridMutasyon2.Rows.Add(j, yenix1, yenix2, yenifx);

                        dataGridMutasyon3.Rows.Add(j, yenix1, yenix2, yenifx);
                    }
                    sonuc = sonuc + c;
                    txtAntijen.Text = sonuc.ToString();
                }
                dataGridMutasyon3.Sort(dataGridMutasyon3.Columns["fx"], ListSortDirection.Ascending);
                for (int b = 0; b < n; b++)
                {
                    dataGridMutasyon4.Rows.Add(b + 1, dataGridMutasyon3.Rows[b].Cells[1].Value, dataGridMutasyon3.Rows[b].Cells[2].Value, dataGridMutasyon3.Rows[b].Cells[3].Value);
                    dataGridYeniPopulasyon.Rows.Add(b + 1, dataGridMutasyon3.Rows[b].Cells[1].Value, dataGridMutasyon3.Rows[b].Cells[2].Value, dataGridMutasyon3.Rows[b].Cells[3].Value);
                }
                int d = populasyon - n;
                for (int s = 0; s < d; s++)
                {
                    double x1 = (random.NextDouble() * (max - min) + min);
                    double x2 = (random.NextDouble() * (max - min) + min);
                    double number1 = x1 + (2 * x2) - 7;
                    double number2 = (2 * x1) + x2 - 5;
                    double fx = (number1 * number1) + (number2 * number2);
                    dataGridYeniPopulasyon.Rows.Add(s + n + 1, x1, x2, fx);

                }

                double fitness=0.1d;
                int cozum = 0;
                for (int k = 0; k < dataGridYeniPopulasyon.RowCount; k++)
                {
                    dataGrid.Rows.Add(k + 1, dataGridYeniPopulasyon.Rows[k].Cells[1].Value, dataGridYeniPopulasyon.Rows[k].Cells[2].Value, dataGridYeniPopulasyon.Rows[k].Cells[3].Value);
                    if (k < dataGridYeniPopulasyon.RowCount - 1)
                    {
                        double f1 = Convert.ToDouble(dataGridYeniPopulasyon.Rows[k].Cells[3].Value);
                        double f2 = Convert.ToDouble(dataGridYeniPopulasyon.Rows[k + 1].Cells[3].Value);
                        double fark = Math.Abs(f2 - f1);
                        if (fark < fitness)
                        {
                            fitness = fark;
                            cozum = say;
                            lblCozum.Text = "f(x)=" + f2 + " ve " + say + ". iterasyon";
                        }

                    }

                }

                if (say <= iterasyon - 1)
                {

                    dataGridYeniPopulasyon.Rows.Clear();
                    dataGridYeniPopulasyon.DataSource = null;
                    dataGridYeniPopulasyon.Refresh();
                    dataGridSıralama.Rows.Clear();
                    dataGridSıralama.DataSource = null;
                    dataGridSıralama.Refresh();
                    dataGridAntijen.Rows.Clear();
                    dataGridAntijen.DataSource = null;
                    dataGridAntijen.Refresh();
                    txtAntijen.Clear();
                    dataGridIslem.Rows.Clear();
                    dataGridIslem.DataSource = null;
                    dataGridIslem.Refresh();
                    dataGridMutasyonx1.Rows.Clear();
                    dataGridMutasyonx1.Refresh();
                    dataGridMutasyonx2.Rows.Clear();
                    dataGridMutasyonx2.Refresh();
                    dataGridMutasyon2.Rows.Clear();
                    dataGridMutasyon2.Refresh();
                    dataGridMutasyon3.Rows.Clear();
                    dataGridMutasyon3.Refresh();
                    dataGridMutasyon4.Rows.Clear();
                    dataGridMutasyon4.Refresh();
                }

            }


        }
        ///--------------------------------------------------------------------------------------------///
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.DataSource = null;
            dataGrid.Refresh();

            dataGridIslem.Rows.Clear();
            dataGridIslem.DataSource = null;
            dataGridIslem.Refresh();

            dataGridSıralama.Rows.Clear();
            dataGridSıralama.DataSource = null;
            dataGridSıralama.Refresh();

            dataGridAntijen.Rows.Clear();
            dataGridAntijen.DataSource = null;
            dataGridAntijen.Refresh();
            
            dataGridMutasyonx1.Rows.Clear();
            dataGridMutasyonx1.DataSource = null;
            dataGridMutasyonx1.Refresh();

            dataGridMutasyonx2.Rows.Clear();
            dataGridMutasyonx2.DataSource = null;
            dataGridMutasyonx2.Refresh();

            dataGridMutasyon2.Rows.Clear();
            dataGridMutasyon2.DataSource = null;
            dataGridMutasyon2.Refresh();

            dataGridMutasyon3.Rows.Clear();
            dataGridMutasyon3.DataSource = null;
            dataGridMutasyon3.Refresh();

            dataGridMutasyon4.Rows.Clear();
            dataGridMutasyon4.DataSource = null;
            dataGridMutasyon4.Refresh();

            dataGridYeniPopulasyon.Rows.Clear();
            dataGridYeniPopulasyon.DataSource = null;
            dataGridYeniPopulasyon.Refresh();

            txtAntijen.Clear();
            txtBeta.Clear();
            txtIterasyon.Clear();
            txtMutasyon.Clear();
            txtn.Clear();
            txtPopulasyon.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void dataGridAntijen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
