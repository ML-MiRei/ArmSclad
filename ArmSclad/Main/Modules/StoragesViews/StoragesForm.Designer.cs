namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    partial class StoragesForm
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
            ColumnHeader Name;
            panel1 = new Panel();
            ClearFilterButton = new Button();
            FiltresButton = new Button();
            SearchWorkTime = new DateTimePicker();
            label13 = new Label();
            SearchMinCapacity = new TextBox();
            SearchMaxCapacity = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            SearchName = new TextBox();
            StoragesList = new ListView();
            StorageInfo = new Panel();
            AcceptanceButton = new Button();
            QualityСontrolButton = new Button();
            RepackagingButton = new Button();
            ShipmentButton = new Button();
            InventoryButton = new Button();
            DeleteButton = new Button();
            SettingsButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MovingButton = new Button();
            ShowEmployees = new Button();
            ShowProducts = new Button();
            ProgressCapacity = new ProgressBar();
            RemainingCapacityLabel = new Label();
            CapacityLabel = new Label();
            ClosingTimeLabel = new Label();
            OpeningTimeLabel = new Label();
            AddressLabel = new Label();
            NameLabel = new Label();
            panel3 = new Panel();
            UpdateButton = new Button();
            AddStorageButton = new Button();
            NextPageButton = new Button();
            PrevPageButton = new Button();
            Name = new ColumnHeader();
            panel1.SuspendLayout();
            StorageInfo.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Text = "Название склада";
            Name.Width = 241;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ClearFilterButton);
            panel1.Controls.Add(FiltresButton);
            panel1.Controls.Add(SearchWorkTime);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(SearchMinCapacity);
            panel1.Controls.Add(SearchMaxCapacity);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(SearchName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 87);
            panel1.TabIndex = 1;
            // 
            // ClearFilterButton
            // 
            ClearFilterButton.BackColor = Color.FromArgb(0, 0, 64);
            ClearFilterButton.FlatAppearance.BorderSize = 0;
            ClearFilterButton.FlatStyle = FlatStyle.Flat;
            ClearFilterButton.Location = new Point(1041, 50);
            ClearFilterButton.Name = "ClearFilterButton";
            ClearFilterButton.Size = new Size(65, 23);
            ClearFilterButton.TabIndex = 34;
            ClearFilterButton.UseVisualStyleBackColor = false;
            ClearFilterButton.Click += ClearFilterButton_Click;
            // 
            // FiltresButton
            // 
            FiltresButton.BackColor = Color.FromArgb(0, 0, 64);
            FiltresButton.FlatAppearance.BorderSize = 0;
            FiltresButton.FlatStyle = FlatStyle.Flat;
            FiltresButton.Location = new Point(1041, 20);
            FiltresButton.Name = "FiltresButton";
            FiltresButton.Size = new Size(65, 23);
            FiltresButton.TabIndex = 33;
            FiltresButton.UseVisualStyleBackColor = false;
            // 
            // SearchWorkTime
            // 
            SearchWorkTime.Format = DateTimePickerFormat.Time;
            SearchWorkTime.Location = new Point(820, 48);
            SearchWorkTime.Name = "SearchWorkTime";
            SearchWorkTime.ShowUpDown = true;
            SearchWorkTime.Size = new Size(142, 27);
            SearchWorkTime.TabIndex = 32;
            SearchWorkTime.Value = new DateTime(2024, 5, 26, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(820, 18);
            label13.Name = "label13";
            label13.Size = new Size(113, 18);
            label13.TabIndex = 31;
            label13.Text = "Время работы:";
            // 
            // SearchMinCapacity
            // 
            SearchMinCapacity.Location = new Point(703, 50);
            SearchMinCapacity.Name = "SearchMinCapacity";
            SearchMinCapacity.PlaceholderText = "0";
            SearchMinCapacity.Size = new Size(72, 27);
            SearchMinCapacity.TabIndex = 30;
            // 
            // SearchMaxCapacity
            // 
            SearchMaxCapacity.Location = new Point(703, 16);
            SearchMaxCapacity.Name = "SearchMaxCapacity";
            SearchMaxCapacity.PlaceholderText = "0";
            SearchMaxCapacity.Size = new Size(72, 27);
            SearchMaxCapacity.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(483, 54);
            label12.Name = "label12";
            label12.Size = new Size(206, 18);
            label12.TabIndex = 28;
            label12.Text = "Минимальная вместимость:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(483, 20);
            label11.Name = "label11";
            label11.Size = new Size(214, 18);
            label11.TabIndex = 27;
            label11.Text = "Максимальная вместимость:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(188, 18);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 26;
            label10.Text = "Название:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(30, 30);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 25;
            label9.Text = "Фильтры:";
            // 
            // SearchName
            // 
            SearchName.Location = new Point(188, 43);
            SearchName.Name = "SearchName";
            SearchName.PlaceholderText = "название..";
            SearchName.Size = new Size(230, 27);
            SearchName.TabIndex = 0;
            // 
            // StoragesList
            // 
            StoragesList.Columns.AddRange(new ColumnHeader[] { Name });
            StoragesList.Dock = DockStyle.Left;
            StoragesList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StoragesList.FullRowSelect = true;
            StoragesList.GridLines = true;
            StoragesList.HideSelection = true;
            StoragesList.Location = new Point(0, 87);
            StoragesList.Name = "StoragesList";
            StoragesList.Scrollable = false;
            StoragesList.Size = new Size(241, 622);
            StoragesList.TabIndex = 3;
            StoragesList.UseCompatibleStateImageBehavior = false;
            StoragesList.View = View.Details;
            // 
            // StorageInfo
            // 
            StorageInfo.BackColor = Color.White;
            StorageInfo.Controls.Add(AcceptanceButton);
            StorageInfo.Controls.Add(QualityСontrolButton);
            StorageInfo.Controls.Add(RepackagingButton);
            StorageInfo.Controls.Add(ShipmentButton);
            StorageInfo.Controls.Add(InventoryButton);
            StorageInfo.Controls.Add(DeleteButton);
            StorageInfo.Controls.Add(SettingsButton);
            StorageInfo.Controls.Add(label8);
            StorageInfo.Controls.Add(label7);
            StorageInfo.Controls.Add(label6);
            StorageInfo.Controls.Add(label5);
            StorageInfo.Controls.Add(label4);
            StorageInfo.Controls.Add(label3);
            StorageInfo.Controls.Add(label2);
            StorageInfo.Controls.Add(label1);
            StorageInfo.Controls.Add(MovingButton);
            StorageInfo.Controls.Add(ShowEmployees);
            StorageInfo.Controls.Add(ShowProducts);
            StorageInfo.Controls.Add(ProgressCapacity);
            StorageInfo.Controls.Add(RemainingCapacityLabel);
            StorageInfo.Controls.Add(CapacityLabel);
            StorageInfo.Controls.Add(ClosingTimeLabel);
            StorageInfo.Controls.Add(OpeningTimeLabel);
            StorageInfo.Controls.Add(AddressLabel);
            StorageInfo.Controls.Add(NameLabel);
            StorageInfo.Dock = DockStyle.Fill;
            StorageInfo.Location = new Point(241, 87);
            StorageInfo.Name = "StorageInfo";
            StorageInfo.Size = new Size(898, 622);
            StorageInfo.TabIndex = 4;
            // 
            // AcceptanceButton
            // 
            AcceptanceButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AcceptanceButton.Location = new Point(733, 519);
            AcceptanceButton.Name = "AcceptanceButton";
            AcceptanceButton.Size = new Size(113, 73);
            AcceptanceButton.TabIndex = 31;
            AcceptanceButton.Text = "приём";
            AcceptanceButton.UseVisualStyleBackColor = true;
            AcceptanceButton.Click += AcceptanceButton_Click;
            // 
            // QualityСontrolButton
            // 
            QualityСontrolButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QualityСontrolButton.Location = new Point(596, 519);
            QualityСontrolButton.Name = "QualityСontrolButton";
            QualityСontrolButton.Size = new Size(113, 73);
            QualityСontrolButton.TabIndex = 30;
            QualityСontrolButton.Text = "контроль\r\nкачества";
            QualityСontrolButton.UseVisualStyleBackColor = true;
            // 
            // RepackagingButton
            // 
            RepackagingButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RepackagingButton.Location = new Point(461, 519);
            RepackagingButton.Name = "RepackagingButton";
            RepackagingButton.Size = new Size(113, 73);
            RepackagingButton.TabIndex = 29;
            RepackagingButton.Text = "переупаковка";
            RepackagingButton.UseVisualStyleBackColor = true;
            // 
            // ShipmentButton
            // 
            ShipmentButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShipmentButton.Location = new Point(317, 519);
            ShipmentButton.Name = "ShipmentButton";
            ShipmentButton.Size = new Size(113, 73);
            ShipmentButton.TabIndex = 28;
            ShipmentButton.Text = "отгрузка";
            ShipmentButton.UseVisualStyleBackColor = true;
            ShipmentButton.Click += ShipmentButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InventoryButton.Location = new Point(176, 519);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(113, 73);
            InventoryButton.TabIndex = 27;
            InventoryButton.Text = "инвентаризация";
            InventoryButton.UseVisualStyleBackColor = true;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Image = Properties.Resources.icons8_мусор_24;
            DeleteButton.Location = new Point(45, 29);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(36, 37);
            DeleteButton.TabIndex = 26;
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(0, 0, 64);
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Image = Properties.Resources.icons8_настройки_30;
            SettingsButton.Location = new Point(101, 29);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(36, 37);
            SettingsButton.TabIndex = 25;
            SettingsButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(45, 469);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 20;
            label8.Text = "Действия:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(45, 345);
            label7.Name = "label7";
            label7.Size = new Size(308, 25);
            label7.TabIndex = 19;
            label7.Text = "Дополнительная информация:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(317, 220);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 18;
            label6.Text = "Занято:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(45, 220);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 17;
            label5.Text = "Всего:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(45, 177);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 16;
            label4.Text = "Вместимость:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(302, 131);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 15;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(45, 131);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 14;
            label2.Text = "Время работы:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(45, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 13;
            label1.Text = "Адрес:";
            // 
            // MovingButton
            // 
            MovingButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MovingButton.Location = new Point(45, 519);
            MovingButton.Name = "MovingButton";
            MovingButton.Size = new Size(113, 73);
            MovingButton.TabIndex = 9;
            MovingButton.Text = "перемещение\r\nпродуктов";
            MovingButton.UseVisualStyleBackColor = true;
            // 
            // ShowEmployees
            // 
            ShowEmployees.BackColor = Color.FromArgb(0, 0, 64);
            ShowEmployees.FlatAppearance.BorderSize = 0;
            ShowEmployees.FlatStyle = FlatStyle.Flat;
            ShowEmployees.ForeColor = Color.White;
            ShowEmployees.Location = new Point(461, 389);
            ShowEmployees.Name = "ShowEmployees";
            ShowEmployees.Size = new Size(385, 44);
            ShowEmployees.TabIndex = 8;
            ShowEmployees.Text = "информация о продуктах";
            ShowEmployees.UseVisualStyleBackColor = false;
            // 
            // ShowProducts
            // 
            ShowProducts.BackColor = Color.FromArgb(0, 0, 64);
            ShowProducts.FlatAppearance.BorderSize = 0;
            ShowProducts.FlatStyle = FlatStyle.Flat;
            ShowProducts.ForeColor = Color.White;
            ShowProducts.Location = new Point(45, 389);
            ShowProducts.Name = "ShowProducts";
            ShowProducts.Size = new Size(385, 44);
            ShowProducts.TabIndex = 7;
            ShowProducts.Text = "информация о сотрудниках";
            ShowProducts.UseVisualStyleBackColor = false;
            // 
            // ProgressCapacity
            // 
            ProgressCapacity.BackColor = Color.White;
            ProgressCapacity.ForeColor = Color.Navy;
            ProgressCapacity.Location = new Point(45, 276);
            ProgressCapacity.Name = "ProgressCapacity";
            ProgressCapacity.Size = new Size(801, 44);
            ProgressCapacity.Style = ProgressBarStyle.Continuous;
            ProgressCapacity.TabIndex = 6;
            // 
            // RemainingCapacityLabel
            // 
            RemainingCapacityLabel.AutoSize = true;
            RemainingCapacityLabel.Font = new Font("Microsoft Sans Serif", 12F);
            RemainingCapacityLabel.Location = new Point(430, 220);
            RemainingCapacityLabel.Name = "RemainingCapacityLabel";
            RemainingCapacityLabel.Size = new Size(23, 25);
            RemainingCapacityLabel.TabIndex = 5;
            RemainingCapacityLabel.Text = "0";
            // 
            // CapacityLabel
            // 
            CapacityLabel.AutoSize = true;
            CapacityLabel.Font = new Font("Microsoft Sans Serif", 12F);
            CapacityLabel.Location = new Point(135, 220);
            CapacityLabel.Name = "CapacityLabel";
            CapacityLabel.Size = new Size(23, 25);
            CapacityLabel.TabIndex = 4;
            CapacityLabel.Text = "0";
            // 
            // ClosingTimeLabel
            // 
            ClosingTimeLabel.AutoSize = true;
            ClosingTimeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            ClosingTimeLabel.Location = new Point(332, 131);
            ClosingTimeLabel.Name = "ClosingTimeLabel";
            ClosingTimeLabel.Size = new Size(62, 25);
            ClosingTimeLabel.TabIndex = 3;
            ClosingTimeLabel.Text = "20:00";
            // 
            // OpeningTimeLabel
            // 
            OpeningTimeLabel.AutoSize = true;
            OpeningTimeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            OpeningTimeLabel.Location = new Point(227, 131);
            OpeningTimeLabel.Name = "OpeningTimeLabel";
            OpeningTimeLabel.Size = new Size(62, 25);
            OpeningTimeLabel.TabIndex = 2;
            OpeningTimeLabel.Text = "08:00";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Microsoft Sans Serif", 12F);
            AddressLabel.Location = new Point(140, 87);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(76, 25);
            AddressLabel.TabIndex = 1;
            AddressLabel.Text = "адрес..";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(168, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(139, 38);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(UpdateButton);
            panel3.Controls.Add(AddStorageButton);
            panel3.Controls.Add(NextPageButton);
            panel3.Controls.Add(PrevPageButton);
            panel3.Location = new Point(0, 636);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 73);
            panel3.TabIndex = 25;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(0, 0, 64);
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Image = Properties.Resources.icons8_обновить_30;
            UpdateButton.Location = new Point(144, 23);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Padding = new Padding(5);
            UpdateButton.Size = new Size(38, 38);
            UpdateButton.TabIndex = 3;
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AddStorageButton
            // 
            AddStorageButton.BackColor = Color.FromArgb(0, 0, 64);
            AddStorageButton.FlatAppearance.BorderSize = 0;
            AddStorageButton.FlatStyle = FlatStyle.Flat;
            AddStorageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddStorageButton.ForeColor = Color.White;
            AddStorageButton.Location = new Point(188, 23);
            AddStorageButton.Name = "AddStorageButton";
            AddStorageButton.Size = new Size(38, 38);
            AddStorageButton.TabIndex = 2;
            AddStorageButton.Text = "+";
            AddStorageButton.UseVisualStyleBackColor = false;
            // 
            // NextPageButton
            // 
            NextPageButton.BackColor = Color.FromArgb(0, 0, 64);
            NextPageButton.FlatAppearance.BorderSize = 0;
            NextPageButton.FlatStyle = FlatStyle.Flat;
            NextPageButton.Image = Properties.Resources.icons8_направо_24;
            NextPageButton.Location = new Point(56, 23);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(38, 38);
            NextPageButton.TabIndex = 1;
            NextPageButton.UseVisualStyleBackColor = false;
            // 
            // PrevPageButton
            // 
            PrevPageButton.BackColor = Color.FromArgb(0, 0, 64);
            PrevPageButton.FlatAppearance.BorderSize = 0;
            PrevPageButton.FlatStyle = FlatStyle.Flat;
            PrevPageButton.Image = Properties.Resources.icons8_налево_24;
            PrevPageButton.Location = new Point(12, 23);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(38, 38);
            PrevPageButton.TabIndex = 0;
            PrevPageButton.UseVisualStyleBackColor = false;
            // 
            // StoragesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 709);
            Controls.Add(panel3);
            Controls.Add(StorageInfo);
            Controls.Add(StoragesList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            this.Name = "StoragesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoragesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            StorageInfo.ResumeLayout(false);
            StorageInfo.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView StoragesList;
        private Panel StorageInfo;
        private Label NameLabel;
        private Label ClosingTimeLabel;
        private Label OpeningTimeLabel;
        private Label AddressLabel;
        private Label CapacityLabel;
        private Label RemainingCapacityLabel;
        private Label label1;
        private Button MovingButton;
        private Button ShowEmployees;
        private Button ShowProducts;
        private ProgressBar ProgressCapacity;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox SearchName;
        private Label label11;
        private TextBox SearchMinCapacity;
        private TextBox SearchMaxCapacity;
        private Label label12;
        private DateTimePicker SearchWorkTime;
        private Label label13;
        private Button FiltresButton;
        private Panel panel3;
        private Button NextPageButton;
        private Button PrevPageButton;
        private Button AddStorageButton;
        private Button SettingsButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearFilterButton;
        private Button AcceptanceButton;
        private Button QualityСontrolButton;
        private Button RepackagingButton;
        private Button ShipmentButton;
        private Button InventoryButton;
    }
}