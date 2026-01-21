/*using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
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

    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewImageColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 75;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            *//**//*var colDeliveryDate = new DataGridViewTextBoxColumn();
            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.FillWeight = 25;
            colDeliveryDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange(
            [
                colInfo, colDeliveryDate
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try 
            {
                using(var db)

            }
            catch(Exception ex)
            {

            }
        }
    }
}
*/