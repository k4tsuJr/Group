using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartSalary.Series["Months"].Points.AddXY(" 1", 200);
            chartSalary.Series["Months"].Points.AddXY(" 2", 700);
            chartSalary.Series["Months"].Points.AddXY(" 3", 400);
            chartSalary.Series["Months"].Points.AddXY(" 4", 100);
            chartSalary.Series["Months"].Points.AddXY(" 5", 1200);
            chartSalary.Series["Months"].Points.AddXY(" 6", 1100);
            chartSalary.Series["Months"].Points.AddXY(" 7", 1100);
            chartSalary.Series["Months"].Points.AddXY(" 8", 1000);
            chartSalary.Series["Months"].Points.AddXY(" 9", 600);
            chartSalary.Series["Months"].Points.AddXY(" 10", 700);
            chartSalary.Series["Months"].Points.AddXY(" 11", 400);
            chartSalary.Series["Months"].Points.AddXY(" 12", 100);

            chartGroup.Series["Groups"].Points.AddXY(" 1", 200);
            chartGroup.Series["Groups"].Points.AddXY(" 2", 700);
            chartGroup.Series["Groups"].Points.AddXY(" 3", 400);
            chartGroup.Series["Groups"].Points.AddXY(" 4", 100);
            chartGroup.Series["Groups"].Points.AddXY(" 5", 1200);
            chartGroup.Series["Groups"].Points.AddXY(" 6", 1100);
        }
    }
}
