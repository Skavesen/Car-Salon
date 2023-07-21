using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseDB
{
    public partial class ReportForm : Form
    {
        public ReportForm(List<string> filtered)
        {
            InitializeComponent();
            label1.Text += filtered[2];
            label2.Text += filtered[0];
            label3.Text += filtered[1];
            label4.Text += filtered[3].Substring(0,10);
            label5.Text += filtered[4];
            label10.Text += filtered[5];

        }
    }
}
