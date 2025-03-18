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
    public partial class Form1_rel_cat_R_1 : Form
    {

        

        double charge_0_30_if_above_60 = 1.90;
        double charge_31_90_if_above_60 = 2.88;
        double charge_91_120_if_above_60 = 9.75;
        double charge_121_180_if_above_60 = 7.50;
        double charge_180_inf_if_above_60 = 9.40;

        double fixed_charge_0_30_if_above_60 = 30.00;
        double fixed_charge_31_90_if_above_60 = 60.00;
        double fixed_charge_91_120_if_above_60 = 180.00;
        double fixed_charge_121_180_if_above_60 = 180.00;
        double fixed_charge_180_inf_if_above_60 = 240.00;

        double charge_0_30;
        double charge_31_90;
        double charge_91_120;
        double charge_121_180;
        double charge_above_180;
        double total_charge;
        public Form1_rel_cat_R_1()
        {
            InitializeComponent();
        }

        private void mymethod1(double fixedCharge)
        {
            lbl_1.Text = charge_0_30.ToString();
            lbl_2.Text = charge_31_90.ToString();
            lbl_3.Text = charge_91_120.ToString();
            lbl_4.Text = charge_121_180.ToString();
            lbl_5.Text = charge_above_180.ToString();
            lbl_6.Text = fixedCharge.ToString();
            lbl_7.Text = total_charge.ToString();
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
                    if (units_consumed <= 30)
                    {
                        charge_0_30 = units_consumed * charge_0_30_if_above_60;
                        
                        total_charge = charge_0_30 + fixed_charge_0_30_if_above_60;

                        mymethod1(fixed_charge_0_30_if_above_60);

                        pnl_result.Visible = true;
                        tb_units.Text = " ";
                    }
                    else if (units_consumed <= 90)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60;
                        charge_31_90 = (units_consumed - 30) * charge_31_90_if_above_60;
                        total_charge = charge_0_30 + fixed_charge_31_90_if_above_60;

                        mymethod1(fixed_charge_31_90_if_above_60);

                        pnl_result.Visible = true;
                        tb_units.Text = " ";
                    }
                    else if (units_consumed <= 120)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60;
                        charge_31_90 = 60 * charge_31_90_if_above_60;
                        charge_91_120 = (units_consumed - 90) * charge_91_120_if_above_60;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + fixed_charge_91_120_if_above_60;

                        mymethod1(fixed_charge_91_120_if_above_60);

                        pnl_result.Visible = true;
                        tb_units.Text = " ";
                    }
                    else if (units_consumed <= 180)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60;
                        charge_31_90 = 30 * charge_31_90_if_above_60;
                        charge_91_120 = 30 * charge_91_120_if_above_60;
                        charge_121_180 = (units_consumed - 120) * charge_121_180_if_above_60;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + fixed_charge_121_180_if_above_60;

                        mymethod1(fixed_charge_121_180_if_above_60);

                        pnl_result.Visible = true;
                        tb_units.Text = " ";
                    }
                    else if (units_consumed > 180)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60;
                        charge_31_90 = 30 * charge_31_90_if_above_60;
                        charge_91_120 = 30 * charge_91_120_if_above_60;
                        charge_121_180 = 60 * charge_121_180_if_above_60;
                        charge_above_180 = (units_consumed - 180) * charge_180_inf_if_above_60;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + charge_above_180 + fixed_charge_180_inf_if_above_60;

                        mymethod1(fixed_charge_180_inf_if_above_60);

                        pnl_result.Visible = true;
                        tb_units.Text = " ";
                    }
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

        private void Form1_rel_cat_R_1_Load(object sender, EventArgs e)
        {

            lbl_t_1.Text = charge_0_30_if_above_60.ToString();
            lbl_t_2.Text = charge_31_90_if_above_60.ToString();
            lbl_t_3.Text = charge_91_120_if_above_60.ToString();
            lbl_t_4.Text = charge_121_180_if_above_60.ToString();
            lbl_t_5.Text = charge_180_inf_if_above_60.ToString();

            lbl_t_6.Text = fixed_charge_0_30_if_above_60.ToString();
            lbl_t_7.Text = fixed_charge_31_90_if_above_60.ToString();
            lbl_t_8.Text = fixed_charge_91_120_if_above_60.ToString();
            lbl_t_9.Text = fixed_charge_121_180_if_above_60.ToString();
            lbl_t_10.Text = fixed_charge_180_inf_if_above_60.ToString();
        }
    }
}
