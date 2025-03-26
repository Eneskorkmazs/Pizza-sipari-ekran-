namespace PİZZA_SİPARİŞ_EKRANI
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            baslik = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(76, 249);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "ince kenar";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(290, 249);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kalın kenar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 546);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(287, 546);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 7;
            label1.Text = "Ebat :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 552);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 8;
            label2.Text = "Adet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 552);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 9;
            label3.Text = "Toplam :";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Küçük", "Orta", "Büyük" });
            comboBox1.Location = new Point(74, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 33);
            comboBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Dana jambon";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 90);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 29);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Sosis";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 125);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 29);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Mısır";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 160);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(95, 29);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Ançuez";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 195);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(86, 29);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "Zeytin";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Location = new Point(76, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 230);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzemeler";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(219, 195);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(85, 29);
            checkBox10.TabIndex = 20;
            checkBox10.Text = "Peynir";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(218, 160);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(118, 29);
            checkBox9.TabIndex = 19;
            checkBox9.Text = "Ton baılığı";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(219, 125);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(94, 29);
            checkBox8.TabIndex = 18;
            checkBox8.Text = "Mantar";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(219, 90);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(85, 29);
            checkBox7.TabIndex = 17;
            checkBox7.Text = "Sucuk";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(218, 55);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(86, 29);
            checkBox6.TabIndex = 16;
            checkBox6.Text = "Salam";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(74, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 129);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(143, 592);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Kapat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(287, 592);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 20;
            button2.Text = "Sipariş ver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // baslik
            // 
            baslik.BackColor = Color.FromArgb(192, 0, 0);
            baslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            baslik.Location = new Point(-1, -2);
            baslik.Name = "baslik";
            baslik.Size = new Size(458, 52);
            baslik.TabIndex = 21;
            baslik.Text = "PİZZA SİPARİŞ EKRANI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 654);
            ControlBox = false;
            Controls.Add(baslik);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "PİZZA";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private GroupBox groupBox1;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label baslik;
    }
}
