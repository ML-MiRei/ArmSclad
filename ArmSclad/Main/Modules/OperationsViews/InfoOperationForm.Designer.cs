namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    partial class InfoOperationForm
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
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            CloseButton = new Button();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Execute = new Button();
            StatusOperation = new Label();
            NameOperation = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Id = new Label();
            TargetString = new Label();
            SetSuccsessStatus = new Button();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 10);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 10);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 450);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(598, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 450);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(CloseButton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(588, 52);
            panel5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 1;
            label2.Text = "Информация о заявке";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(524, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(63, 52);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ProductsList
            // 
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(49, 192);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(506, 176);
            ProductsList.TabIndex = 25;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Название";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Количество";
            columnHeader3.Width = 120;
            // 
            // Execute
            // 
            Execute.BackColor = Color.Green;
            Execute.FlatAppearance.BorderSize = 0;
            Execute.FlatStyle = FlatStyle.Flat;
            Execute.ForeColor = Color.White;
            Execute.Location = new Point(49, 393);
            Execute.Name = "Execute";
            Execute.Size = new Size(230, 29);
            Execute.TabIndex = 23;
            Execute.Text = "стать исполнителем";
            Execute.UseVisualStyleBackColor = false;
            Execute.Click += Execute_Click;
            // 
            // StatusOperation
            // 
            StatusOperation.AutoSize = true;
            StatusOperation.Location = new Point(460, 85);
            StatusOperation.Name = "StatusOperation";
            StatusOperation.Size = new Size(52, 20);
            StatusOperation.TabIndex = 20;
            StatusOperation.Text = "Статус";
            // 
            // NameOperation
            // 
            NameOperation.AutoSize = true;
            NameOperation.Location = new Point(178, 85);
            NameOperation.Name = "NameOperation";
            NameOperation.Size = new Size(77, 20);
            NameOperation.TabIndex = 19;
            NameOperation.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 85);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 18;
            label1.Text = "Тип операции:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 85);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 26;
            label4.Text = "Статус операции:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 150);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 27;
            label5.Text = "Продукты:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 115);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 28;
            label6.Text = "Цель:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 115);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 29;
            label7.Text = "ID цели:";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(421, 115);
            Id.Name = "Id";
            Id.Size = new Size(0, 20);
            Id.TabIndex = 30;
            // 
            // TargetString
            // 
            TargetString.AutoSize = true;
            TargetString.Location = new Point(126, 115);
            TargetString.Name = "TargetString";
            TargetString.Size = new Size(0, 20);
            TargetString.TabIndex = 31;
            // 
            // SetSuccsessStatus
            // 
            SetSuccsessStatus.BackColor = Color.Green;
            SetSuccsessStatus.FlatAppearance.BorderSize = 0;
            SetSuccsessStatus.FlatStyle = FlatStyle.Flat;
            SetSuccsessStatus.ForeColor = Color.White;
            SetSuccsessStatus.Location = new Point(49, 393);
            SetSuccsessStatus.Name = "SetSuccsessStatus";
            SetSuccsessStatus.Size = new Size(230, 29);
            SetSuccsessStatus.TabIndex = 32;
            SetSuccsessStatus.Text = "выполнено";
            SetSuccsessStatus.UseVisualStyleBackColor = false;
            SetSuccsessStatus.Click += SetSuccsessStatus_Click;
            // 
            // InfoOperationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(608, 470);
            Controls.Add(SetSuccsessStatus);
            Controls.Add(TargetString);
            Controls.Add(Id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ProductsList);
            Controls.Add(Execute);
            Controls.Add(StatusOperation);
            Controls.Add(NameOperation);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoOperationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoOperationForm";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Button CloseButton;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button Execute;
        private Label StatusOperation;
        private Label NameOperation;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label Id;
        private Label TargetString;
        private Button SetSuccsessStatus;
    }
}