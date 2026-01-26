using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using ShoesProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 75;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDeliveryDate = new DataGridViewTextBoxColumn();
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
                using (var db = new ShopDbContext())
                {
                    /*var orders = db.Orders
                        .Where(w => w.IdUser == CurrentUser.Id) //только заказы текущего пользоваетля
                        .Include(i => i.ProductsOrders)
                        .Include(i => i.Status)
                        .Include(i => i.DeliveryPoint)
                        .Include(i => i.DeliveryDate)
                        .ToList();*/

                    var orders = db.Orders
                        .Where(w => w.IdUser == CurrentUser.Id)
                        .Include(i => i.ProductsOrders)
                            .ThenInclude(po => po.Product) // опционально, если нужно
                        .Include(i => i.Status)
                        .Include(i => i.DeliveryPoint)
                        .OrderBy(o => o.OrderDate) // Сортируем по дате заказа
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);
                        row.Cells["colDeliveryDate"].Value = order.DeliveryDate;
                    }

                    //возобновить отрисовку
                    dgvOrders.ResumeLayout();
                    //высота строк по содержимому
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка загрузки: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private string FormatOrderInfo(Order order)
        {
            string items = "";

            foreach (var i in order.ProductsOrders)
            {
                items += $"{i.Product.Art}, {i.Quantity}, ";
            }

            // Убираем последнюю запятую и пробел
            if (items.Length > 2)
            {
                items = items.Remove(items.Length - 2);
            }

            return $"Артикул заказа: {items}\n" +
                $"Статус заказа: {order.Status.StatusName}\n" +
                $"Адрес пункта выдачи: {order.DeliveryPoint.DeliveryAddress}\n" +
                $"Дата заказа: {order.OrderDate}";
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // Специальный результат для "Назад"
            this.Close();
        }
    }
}
