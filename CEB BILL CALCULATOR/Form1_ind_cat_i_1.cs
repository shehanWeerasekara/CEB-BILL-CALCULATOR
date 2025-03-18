using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEB_BILL_CALCULATOR
{
    public partial class Form1_ind_cat_i_1 : Form
    {

        double charge_before_300 = 10.80;
        double charge_after_300 = 12.20;
        double fixed_charge = 600;
        public Form1_ind_cat_i_1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            int units_consumed = int.Parse(tb_units.Text);
        }
    }
}
