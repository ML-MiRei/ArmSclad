namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    partial class InfoProductForm
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
            label7 = new Label();
            CloseButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            CancelButton = new Button();
            SaveButton = new Button();
            PriceTextBox = new TextBox();
            SpaceOccupiedTextBox = new TextBox();
            NumberPiecesInPackageTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 37);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 9);
            label7.Name = "label7";
            label7.Size = new Size(182, 20);
            label7.TabIndex = 1;
            label7.Text = "Информация о продукте";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(512, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(65, 35);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 120);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(SpaceOccupiedTextBox);
            panel2.Controls.Add(NumberPiecesInPackageTextBox);
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 284);
            panel2.TabIndex = 2;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(300, 227);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(233, 29);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Green;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(38, 227);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(233, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(197, 171);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.PlaceholderText = "0";
            PriceTextBox.Size = new Size(336, 27);
            PriceTextBox.TabIndex = 9;
            // 
            // SpaceOccupiedTextBox
            // 
            SpaceOccupiedTextBox.Location = new Point(309, 137);
            SpaceOccupiedTextBox.Name = "SpaceOccupiedTextBox";
            SpaceOccupiedTextBox.PlaceholderText = "0";
            SpaceOccupiedTextBox.Size = new Size(224, 27);
            SpaceOccupiedTextBox.TabIndex = 8;
            // 
            // NumberPiecesInPackageTextBox
            // 
            NumberPiecesInPackageTextBox.Location = new Point(288, 101);
            NumberPiecesInPackageTextBox.Name = "NumberPiecesInPackageTextBox";
            NumberPiecesInPackageTextBox.PlaceholderText = "0";
            NumberPiecesInPackageTextBox.Size = new Size(245, 27);
            NumberPiecesInPackageTextBox.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(148, 64);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "описание..";
            DescriptionTextBox.Size = new Size(385, 27);
            DescriptionTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(148, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "название..";
            NameTextBox.Size = new Size(385, 27);
            NameTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(38, 170);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 4;
            label6.Text = "Цена за единицу:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(38, 136);
            label5.Name = "label5";
            label5.Size = new Size(265, 25);
            label5.TabIndex = 3;
            label5.Text = "Занимаемое упаковкой место:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(38, 100);
            label4.Name = "label4";
            label4.Size = new Size(235, 25);
            label4.TabIndex = 2;
            label4.Text = "Кол-во единиц в упаковке:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(38, 63);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 1;
            label3.Text = "Описание:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(38, 29);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Название:";
            // 
            // InfoProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 321);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button CloseButton;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox PriceTextBox;
        private TextBox SpaceOccupiedTextBox;
        private TextBox NumberPiecesInPackageTextBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Button CancelButton;
        private Button SaveButton;
        private Label label7;
    }
}