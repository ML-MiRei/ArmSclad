namespace ArmSclad.UI.Main.Modules.OrdersView
{
    partial class OrdersForm
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
            panel1 = new Panel();
            UpdateMode = new CheckBox();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            panel2 = new Panel();
            DeleteOrder = new Button();
            AddOrder = new Button();
            OrdersList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(UpdateMode);
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 47);
            panel1.TabIndex = 3;
            // 
            // UpdateMode
            // 
            UpdateMode.AutoSize = true;
            UpdateMode.Location = new Point(187, 12);
            UpdateMode.Name = "UpdateMode";
            UpdateMode.Size = new Size(198, 24);
            UpdateMode.TabIndex = 8;
            UpdateMode.Text = "режим редактирования";
            UpdateMode.UseVisualStyleBackColor = true;
            // 
            // NextPageButton
            // 
            NextPageButton.BackColor = Color.FromArgb(0, 0, 64);
            NextPageButton.FlatAppearance.BorderSize = 0;
            NextPageButton.FlatStyle = FlatStyle.Flat;
            NextPageButton.Image = Properties.Resources.icons8_направо_24;
            NextPageButton.Location = new Point(106, 9);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(41, 29);
            NextPageButton.TabIndex = 6;
            NextPageButton.UseVisualStyleBackColor = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // UpdatePageButton
            // 
            UpdatePageButton.BackColor = Color.FromArgb(0, 0, 64);
            UpdatePageButton.FlatAppearance.BorderSize = 0;
            UpdatePageButton.FlatStyle = FlatStyle.Flat;
            UpdatePageButton.Image = Properties.Resources.icons8_обновить_30;
            UpdatePageButton.Location = new Point(59, 9);
            UpdatePageButton.Name = "UpdatePageButton";
            UpdatePageButton.Size = new Size(41, 29);
            UpdatePageButton.TabIndex = 5;
            UpdatePageButton.UseVisualStyleBackColor = false;
            UpdatePageButton.Click += UpdatePageButton_Click;
            // 
            // PrevPageButton
            // 
            PrevPageButton.BackColor = Color.FromArgb(0, 0, 64);
            PrevPageButton.FlatAppearance.BorderSize = 0;
            PrevPageButton.FlatStyle = FlatStyle.Flat;
            PrevPageButton.Image = Properties.Resources.icons8_налево_24;
            PrevPageButton.Location = new Point(12, 9);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(41, 29);
            PrevPageButton.TabIndex = 4;
            PrevPageButton.UseVisualStyleBackColor = false;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DeleteOrder);
            panel2.Controls.Add(AddOrder);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 647);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 62);
            panel2.TabIndex = 5;
            // 
            // DeleteOrder
            // 
            DeleteOrder.BackColor = Color.FromArgb(192, 0, 0);
            DeleteOrder.FlatAppearance.BorderSize = 0;
            DeleteOrder.FlatStyle = FlatStyle.Flat;
            DeleteOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteOrder.ForeColor = Color.White;
            DeleteOrder.Image = Properties.Resources.icons8_мусор_24;
            DeleteOrder.Location = new Point(106, 13);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(77, 37);
            DeleteOrder.TabIndex = 1;
            DeleteOrder.UseVisualStyleBackColor = false;
            DeleteOrder.Click += DeleteOrder_Click;
            // 
            // AddOrder
            // 
            AddOrder.BackColor = Color.FromArgb(0, 0, 64);
            AddOrder.FlatAppearance.BorderSize = 0;
            AddOrder.FlatStyle = FlatStyle.Flat;
            AddOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddOrder.ForeColor = Color.White;
            AddOrder.Location = new Point(12, 13);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(77, 37);
            AddOrder.TabIndex = 0;
            AddOrder.Text = "+";
            AddOrder.UseVisualStyleBackColor = false;
            AddOrder.Click += AddOrder_Click;
            // 
            // OrdersList
            // 
            OrdersList.BackColor = Color.White;
            OrdersList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7, columnHeader4, columnHeader5, columnHeader8 });
            OrdersList.Dock = DockStyle.Fill;
            OrdersList.FullRowSelect = true;
            OrdersList.GridLines = true;
            OrdersList.Location = new Point(0, 47);
            OrdersList.MultiSelect = false;
            OrdersList.Name = "OrdersList";
            OrdersList.Scrollable = false;
            OrdersList.Size = new Size(1139, 600);
            OrdersList.TabIndex = 6;
            OrdersList.UseCompatibleStateImageBehavior = false;
            OrdersList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID клиента";
            columnHeader2.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Составляющее";
            columnHeader7.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Адрес доставки";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Время доставки";
            columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Цена";
            columnHeader8.Width = 100;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 709);
            Controls.Add(OrdersList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox UpdateMode;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private Panel panel2;
        private Button DeleteOrder;
        private Button AddOrder;
        private ListView OrdersList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
    }
}