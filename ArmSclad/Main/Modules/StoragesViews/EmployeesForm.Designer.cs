namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    partial class EmployeesForm
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
            CloseButton = new Button();
            EmployeesList = new ListView();
            idEmployee = new ColumnHeader();
            FullNameEmployee = new ColumnHeader();
            PositionEmployee = new ColumnHeader();
            PrevPageButton = new Button();
            UpdatePageButton = new Button();
            NextPageButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 45);
            panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(499, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(65, 45);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X\r\n";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // EmployeesList
            // 
            EmployeesList.Columns.AddRange(new ColumnHeader[] { idEmployee, FullNameEmployee, PositionEmployee });
            EmployeesList.Dock = DockStyle.Fill;
            EmployeesList.GridLines = true;
            EmployeesList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            EmployeesList.Location = new Point(0, 45);
            EmployeesList.MultiSelect = false;
            EmployeesList.Name = "EmployeesList";
            EmployeesList.Size = new Size(565, 398);
            EmployeesList.Sorting = SortOrder.Ascending;
            EmployeesList.TabIndex = 1;
            EmployeesList.UseCompatibleStateImageBehavior = false;
            EmployeesList.View = System.Windows.Forms.View.Details;
            // 
            // idEmployee
            // 
            idEmployee.Text = "ID";
            // 
            // FullNameEmployee
            // 
            FullNameEmployee.Text = "Имя";
            FullNameEmployee.Width = 200;
            // 
            // PositionEmployee
            // 
            PositionEmployee.Text = "Должность";
            PositionEmployee.Width = 300;
            // 
            // PrevPageButton
            // 
            PrevPageButton.BackColor = Color.FromArgb(0, 0, 64);
            PrevPageButton.FlatAppearance.BorderSize = 0;
            PrevPageButton.FlatStyle = FlatStyle.Flat;
            PrevPageButton.Image = Properties.Resources.icons8_налево_24;
            PrevPageButton.Location = new Point(12, 10);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(41, 29);
            PrevPageButton.TabIndex = 1;
            PrevPageButton.UseVisualStyleBackColor = false;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // UpdatePageButton
            // 
            UpdatePageButton.BackColor = Color.FromArgb(0, 0, 64);
            UpdatePageButton.FlatAppearance.BorderSize = 0;
            UpdatePageButton.FlatStyle = FlatStyle.Flat;
            UpdatePageButton.Image = Properties.Resources.icons8_обновить_30;
            UpdatePageButton.Location = new Point(59, 10);
            UpdatePageButton.Name = "UpdatePageButton";
            UpdatePageButton.Size = new Size(41, 29);
            UpdatePageButton.TabIndex = 2;
            UpdatePageButton.UseVisualStyleBackColor = false;
            UpdatePageButton.Click += UpdatePageButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.BackColor = Color.FromArgb(0, 0, 64);
            NextPageButton.FlatAppearance.BorderSize = 0;
            NextPageButton.FlatStyle = FlatStyle.Flat;
            NextPageButton.Image = Properties.Resources.icons8_направо_24;
            NextPageButton.Location = new Point(106, 10);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(41, 29);
            NextPageButton.TabIndex = 3;
            NextPageButton.UseVisualStyleBackColor = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 443);
            Controls.Add(EmployeesList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CloseButton;
        private ListView EmployeesList;
        private ColumnHeader idEmployee;
        private ColumnHeader FullNameEmployee;
        private ColumnHeader PositionEmployee;
        private Button PrevPageButton;
        private Button NextPageButton;
        private Button UpdatePageButton;
    }
}