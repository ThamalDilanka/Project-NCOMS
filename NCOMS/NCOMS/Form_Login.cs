﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
{
    public partial class Form_Login : Form
    {
        Timer timer = new Timer();

        public Form_Login()
        {
            InitializeComponent();
        }


        private void Form_Login_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        private void Lf_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                tb_Password.Focus();
            }

            if(e.KeyCode == Keys.Delete)
            {
                tb_UserName.Text = "";
            }
        }

        private void Lf_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                tb_UserName.Focus();
            }

            if(e.KeyCode == Keys.Delete)
            {
                tb_Password.Text = "";
            }

            if(e.KeyCode == Keys.Enter)
            {
                Btn_signin_Click(sender, e);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;

            string time = "";

            if(hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            lbl_clock.Text = time;
            lbl_clock.Left = (this.panel_clock.Width - lbl_clock.Width) / 2;

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_signin_Click(object sender, EventArgs e)
        {

            if (tb_UserName.Text.Equals("Manager"))
            {
                Form_ManagerMainWindow form_ManagerMainWindow = new Form_ManagerMainWindow();
                form_ManagerMainWindow.Show();
                this.Hide();
            }

            else if (tb_UserName.Text.Equals("Clerk"))
            {
                Form_ClerkMainWindow form_ClerkMainWindow = new Form_ClerkMainWindow();
                form_ClerkMainWindow.Show();
                this.Hide();
            }

            else if (tb_UserName.Text.Equals("Supervisor"))
            {
                Form_SupervisorMainWindow form_SupervisorMainWindow = new Form_SupervisorMainWindow();
                form_SupervisorMainWindow.Show();
                this.Hide();
            }

            else if (tb_UserName.Text.Equals("Storekeeper"))
            {
                Form_StoreKeeperMainWindow form_StoreKeeperMainWindow = new Form_StoreKeeperMainWindow();
                form_StoreKeeperMainWindow.Show();
                this.Hide();
            }
        }
    }
}
