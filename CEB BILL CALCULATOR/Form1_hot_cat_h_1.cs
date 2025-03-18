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
    public partial class Form1_hot_cat_h_1 : Form
    {

        double charge = 21.50;
        double fixed_charge = 600;
        double chg_for_units;
        double total_charge;
        double max_dem_charge = 0;
        public Form1_hot_cat_h_1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            string temp = tb_units.Text;
            int value;

            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(tb_units.Text);
                if (units_consumed >= 0)
                {
                    chg_for_units = units_consumed * charge;
                    lbl_1.Text = chg_for_units.ToString();
                    lbl_2.Text = fixed_charge.ToString();
                    total_charge = chg_for_units + fixed_charge;
                    lbl_3.Text = total_charge.ToString();
                    pnl_result.Visible = true;
                    tb_units.Text = " ";
                }
                else
                {
                    MessageBox.Show("Please Enter a valid number !", "Inavlid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid number !", "Inavlid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_hot_cat_h_1_Load(object sender, EventArgs e)
        {
            lbl_t_1.Text = charge.ToString();
            lbl_t_2.Text = fixed_charge.ToString();
            lbl_t_3.Text = max_dem_charge.ToString();
        }
    }
}
