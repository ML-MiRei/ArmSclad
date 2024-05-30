namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    partial class InputAmount
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите количество выбранного продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Кол-во:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 128);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 3;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InputAmount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(397, 192);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputAmount";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}