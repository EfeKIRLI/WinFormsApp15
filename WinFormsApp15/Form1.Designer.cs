namespace WinFormsApp15
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 415);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PAYMENT";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(67, 151);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 14;
            label8.Text = "Geçici ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(146, 187);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 13;
            label7.Text = "0.00 $ ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 187);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 12;
            label6.Text = "Net Price:";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(217, 360);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 11;
            button1.Text = "PURCHASE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(150, 116);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 10;
            label5.Text = "0.00 $ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 116);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Total Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(150, 148);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 8;
            label4.Text = "0 % ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 67);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "Total items";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "Book Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Ivory;
            groupBox2.Controls.Add(listBox1);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 144);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "YOUR ORDER ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(6, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 104);
            listBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(213, 148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Discount Amount % ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "150", "250", "500", "750", "1000", "" });
            comboBox2.Location = new Point(150, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(53, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "The Lion, the Witch and the Wardrobe", "She: A History of Adventure", "Vardi Wala Gunda (वर्दी वाला गुंडा)", "The Da Vinci Code", "Harry Potter and the Chamber of Secrets", "Harry Potter and the Prisoner of Azkaban", "Harry Potter and the Goblet of Fire", "Harry Potter and the Order of the Phoenix", "Harry Potter and the Half-Blood Prince", "Harry Potter and the Deathly Hallows", "The Alchemist (O Alquimista)", "The Catcher in the Rye", "The Bridges of Madison County", "Ben-Hur: A Tale of the Christ", "You Can Heal Your Life", "One Hundred Years of Solitude (Cien años de soledad)", "Lolita", "Heidi", "The Common Sense Book of Baby and Child Care", "Anne of Green Gables", "Black Beauty", "The Name of the Rose (Il Nome della Rosa)", "The Eagle Has Landed", "Watership Down", "The Hite Report", "Charlotte's Web", "The Ginger Man" });
            comboBox1.Location = new Point(150, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 28);
            comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(15, 360);
            button2.Name = "button2";
            button2.Size = new Size(93, 39);
            button2.TabIndex = 15;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}