namespace Entity_Core._Database_First
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Car_listBox = new ListBox();
            Brand_textBox = new TextBox();
            Model_textBox = new TextBox();
            Year_textBox = new TextBox();
            STNumber_textBox = new TextBox();
            Add_button = new Button();
            Update_button = new Button();
            Delete_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Car_listBox
            // 
            Car_listBox.FormattingEnabled = true;
            Car_listBox.Location = new Point(12, 12);
            Car_listBox.Name = "Car_listBox";
            Car_listBox.Size = new Size(484, 264);
            Car_listBox.TabIndex = 0;
            Car_listBox.SelectedIndexChanged += Car_listBox_SelectedIndexChanged;
            // 
            // Brand_textBox
            // 
            Brand_textBox.Location = new Point(624, 30);
            Brand_textBox.Name = "Brand_textBox";
            Brand_textBox.Size = new Size(339, 27);
            Brand_textBox.TabIndex = 1;
            // 
            // Model_textBox
            // 
            Model_textBox.Location = new Point(624, 81);
            Model_textBox.Name = "Model_textBox";
            Model_textBox.Size = new Size(339, 27);
            Model_textBox.TabIndex = 2;
            // 
            // Year_textBox
            // 
            Year_textBox.Location = new Point(624, 133);
            Year_textBox.Name = "Year_textBox";
            Year_textBox.Size = new Size(339, 27);
            Year_textBox.TabIndex = 3;
            // 
            // STNumber_textBox
            // 
            STNumber_textBox.Location = new Point(624, 187);
            STNumber_textBox.Name = "STNumber_textBox";
            STNumber_textBox.Size = new Size(339, 27);
            STNumber_textBox.TabIndex = 4;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(624, 246);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 5;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Update_button
            // 
            Update_button.Location = new Point(756, 246);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(94, 29);
            Update_button.TabIndex = 6;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = true;
            Update_button.Click += Update_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(869, 246);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 7;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 8;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 81);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 140);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 10;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 194);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 11;
            label4.Text = "St.number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 309);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(STNumber_textBox);
            Controls.Add(Year_textBox);
            Controls.Add(Model_textBox);
            Controls.Add(Brand_textBox);
            Controls.Add(Car_listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Car_listBox;
        private TextBox Brand_textBox;
        private TextBox Model_textBox;
        private TextBox Year_textBox;
        private TextBox STNumber_textBox;
        private Button Add_button;
        private Button Update_button;
        private Button Delete_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
