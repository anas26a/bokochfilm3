namespace bokochfilm
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Book_Lengh_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Book_Author_TextBox = new System.Windows.Forms.TextBox();
            this.Book_Title_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Film_Button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Film_Lengh_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Film_Title_TextBox = new System.Windows.Forms.TextBox();
            this.Film_Director_TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filmer_Check = new System.Windows.Forms.RadioButton();
            this.Blocker_Check = new System.Windows.Forms.RadioButton();
            this.Alla_Check = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.result_textbox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Lengh_Numeric)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Lengh_Numeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(209, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Book_Lengh_Numeric);
            this.tabPage1.Controls.Add(this.Book_Author_TextBox);
            this.tabPage1.Controls.Add(this.Book_Title_TextBox);
            this.tabPage1.Controls.Add(this.Add_Film_Button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(201, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Spellängd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Regissör:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title:";
            // 
            // Book_Lengh_Numeric
            // 
            this.Book_Lengh_Numeric.Location = new System.Drawing.Point(93, 81);
            this.Book_Lengh_Numeric.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Lengh_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Book_Lengh_Numeric.Name = "Book_Lengh_Numeric";
            this.Book_Lengh_Numeric.Size = new System.Drawing.Size(68, 20);
            this.Book_Lengh_Numeric.TabIndex = 3;
            // 
            // Book_Author_TextBox
            // 
            this.Book_Author_TextBox.Location = new System.Drawing.Point(93, 57);
            this.Book_Author_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Author_TextBox.Name = "Book_Author_TextBox";
            this.Book_Author_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Book_Author_TextBox.TabIndex = 2;
            // 
            // Book_Title_TextBox
            // 
            this.Book_Title_TextBox.Location = new System.Drawing.Point(93, 35);
            this.Book_Title_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Title_TextBox.Name = "Book_Title_TextBox";
            this.Book_Title_TextBox.Size = new System.Drawing.Size(68, 20);
            this.Book_Title_TextBox.TabIndex = 1;
            // 
            // Add_Film_Button
            // 
            this.Add_Film_Button.Location = new System.Drawing.Point(45, 179);
            this.Add_Film_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Film_Button.Name = "Add_Film_Button";
            this.Add_Film_Button.Size = new System.Drawing.Size(97, 32);
            this.Add_Film_Button.TabIndex = 0;
            this.Add_Film_Button.Text = "Lägg till bok";
            this.Add_Film_Button.UseVisualStyleBackColor = true;
            this.Add_Film_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Film_Lengh_Numeric);
            this.tabPage2.Controls.Add(this.Film_Title_TextBox);
            this.tabPage2.Controls.Add(this.Film_Director_TextBox);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(201, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Spellängd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Regissör:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Title:";
            // 
            // Film_Lengh_Numeric
            // 
            this.Film_Lengh_Numeric.Location = new System.Drawing.Point(82, 79);
            this.Film_Lengh_Numeric.Margin = new System.Windows.Forms.Padding(2);
            this.Film_Lengh_Numeric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Film_Lengh_Numeric.Name = "Film_Lengh_Numeric";
            this.Film_Lengh_Numeric.Size = new System.Drawing.Size(80, 20);
            this.Film_Lengh_Numeric.TabIndex = 6;
            // 
            // Film_Title_TextBox
            // 
            this.Film_Title_TextBox.Location = new System.Drawing.Point(82, 31);
            this.Film_Title_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Film_Title_TextBox.Name = "Film_Title_TextBox";
            this.Film_Title_TextBox.Size = new System.Drawing.Size(80, 20);
            this.Film_Title_TextBox.TabIndex = 5;
            // 
            // Film_Director_TextBox
            // 
            this.Film_Director_TextBox.Location = new System.Drawing.Point(82, 55);
            this.Film_Director_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Film_Director_TextBox.Name = "Film_Director_TextBox";
            this.Film_Director_TextBox.Size = new System.Drawing.Size(80, 20);
            this.Film_Director_TextBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 179);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Lägg till film";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Filmer_Check);
            this.groupBox1.Controls.Add(this.Blocker_Check);
            this.groupBox1.Controls.Add(this.Alla_Check);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(309, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(177, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visa";
            // 
            // Filmer_Check
            // 
            this.Filmer_Check.AutoSize = true;
            this.Filmer_Check.Location = new System.Drawing.Point(109, 17);
            this.Filmer_Check.Margin = new System.Windows.Forms.Padding(2);
            this.Filmer_Check.Name = "Filmer_Check";
            this.Filmer_Check.Size = new System.Drawing.Size(52, 17);
            this.Filmer_Check.TabIndex = 3;
            this.Filmer_Check.Text = "Filmer";
            this.Filmer_Check.UseVisualStyleBackColor = true;
            this.Filmer_Check.CheckedChanged += new System.EventHandler(this.Filmer_Check_CheckedChanged);
            // 
            // Blocker_Check
            // 
            this.Blocker_Check.AutoSize = true;
            this.Blocker_Check.Location = new System.Drawing.Point(49, 16);
            this.Blocker_Check.Margin = new System.Windows.Forms.Padding(2);
            this.Blocker_Check.Name = "Blocker_Check";
            this.Blocker_Check.Size = new System.Drawing.Size(59, 17);
            this.Blocker_Check.TabIndex = 2;
            this.Blocker_Check.Text = "Böcker";
            this.Blocker_Check.UseVisualStyleBackColor = true;
            this.Blocker_Check.CheckedChanged += new System.EventHandler(this.Blocker_Check_CheckedChanged);
            // 
            // Alla_Check
            // 
            this.Alla_Check.AutoSize = true;
            this.Alla_Check.Checked = true;
            this.Alla_Check.Location = new System.Drawing.Point(5, 17);
            this.Alla_Check.Margin = new System.Windows.Forms.Padding(2);
            this.Alla_Check.Name = "Alla_Check";
            this.Alla_Check.Size = new System.Drawing.Size(42, 17);
            this.Alla_Check.TabIndex = 1;
            this.Alla_Check.TabStop = true;
            this.Alla_Check.Text = "Alla";
            this.Alla_Check.UseVisualStyleBackColor = true;
            this.Alla_Check.CheckedChanged += new System.EventHandler(this.Alla_Check_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 201);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(296, 45);
            this.result_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(217, 177);
            this.result_textbox.TabIndex = 2;
            this.result_textbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Lengh_Numeric)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Lengh_Numeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown Book_Lengh_Numeric;
        private System.Windows.Forms.TextBox Book_Author_TextBox;
        private System.Windows.Forms.TextBox Book_Title_TextBox;
        private System.Windows.Forms.Button Add_Film_Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown Film_Lengh_Numeric;
        private System.Windows.Forms.TextBox Film_Title_TextBox;
        private System.Windows.Forms.TextBox Film_Director_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Filmer_Check;
        private System.Windows.Forms.RadioButton Blocker_Check;
        private System.Windows.Forms.RadioButton Alla_Check;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox result_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

