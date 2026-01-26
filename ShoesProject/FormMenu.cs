using ShoesProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesProject
{
    public partial class FormMenu : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormMenu(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            if (IsGuest )
            {
                btnOrders.Visible = false;
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
