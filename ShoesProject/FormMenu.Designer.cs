using System.Windows.Forms;

namespace ShoesProject
{
    partial class FormMenu : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblUserName = new Label();
            btnLogut = new Button();
            panelTop = new Panel();
            dgvButtons = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButtons).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(189, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.MediumSpringGreen;
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(234, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(150, 30);
            btnLogut.TabIndex = 5;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogut);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(384, 40);
            panelTop.TabIndex = 1;
            // 
            // dgvButtons
            // 
            dgvButtons.AllowUserToAddRows = false;
            dgvButtons.AllowUserToDeleteRows = false;
            dgvButtons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvButtons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvButtons.BackgroundColor = Color.White;
            dgvButtons.BorderStyle = BorderStyle.None;
            dgvButtons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvButtons.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvButtons.DefaultCellStyle = dataGridViewCellStyle1;
            dgvButtons.Dock = DockStyle.Fill;
            dgvButtons.Location = new Point(0, 40);
            dgvButtons.MultiSelect = false;
            dgvButtons.Name = "dgvButtons";
            dgvButtons.ReadOnly = true;
            dgvButtons.RowHeadersVisible = false;
            dgvButtons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvButtons.Size = new Size(384, 321);
            dgvButtons.TabIndex = 3;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(dgvButtons);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButtons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserName;
        private Button btnLogut;
        private Panel panelTop;
        private DataGridView dgvButtons;
    }
}