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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void showSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                pnl_submenu.Visible = false;
            }
        }

        private void hideSubmenu()
        {
            if (pnl_submenu.Visible == true)
            {
                pnl_submenu.Visible = false;
            }
        }

        private void showSubmenu1(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubmenu1(); // Hide other submenus if needed
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubmenu1()
        {
            // Hide only if it is visible
            if (pnl_dom_submenu.Visible)
            {
                pnl_dom_submenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openchidlForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_right.Controls.Add(childForm);
            pnl_right.Tag = childForm;
            childForm.BringToFront();
            childForm.BackColor = Color.Cornsilk;
            childForm.Show();
        }
        private void pnl_rel_cat_R1_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_rel_cat_R_1());
        }

        private void pnl_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_bill_cal_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_submenu);
        }

        private void btn_dom_cat_1_Click(object sender, EventArgs e)
        {
            showSubmenu1(pnl_dom_submenu);
        }

        private void btn_ind_cat_i_1_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_ind_cat_i_1());
        }

        private void btn_gen_cat_gp_1_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_gen_cat_GP_1());
        }

        private void btn_hot_cat_h_1_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_hot_cat_h_1());
        }

        private void btn_gov_gv_1_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_gov_cat_GV_1());
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_dom_cal());
        }

        private void btn_bill_rate_Click(object sender, EventArgs e)
        {
            openchidlForm(new Form1_dom_billrate());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
