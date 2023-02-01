namespace REST_client
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetAll_btn = new System.Windows.Forms.Button();
            this.GetGameById_btn = new System.Windows.Forms.Button();
            this.get_book_by_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.delete_id_numeric = new System.Windows.Forms.NumericUpDown();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.author_tb = new System.Windows.Forms.TextBox();
            this.title_update_tb = new System.Windows.Forms.TextBox();
            this.author_update_tb = new System.Windows.Forms.TextBox();
            this.price_update_numeric = new System.Windows.Forms.NumericUpDown();
            this.id_update_numeric = new System.Windows.Forms.NumericUpDown();
            this.insert_price_numeric = new System.Windows.Forms.NumericUpDown();
            this.insert_year = new System.Windows.Forms.TextBox();
            this.update_year = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.get_book_by_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_update_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_price_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(497, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(277, 420);
            this.listBox1.TabIndex = 0;
            // 
            // GetAll_btn
            // 
            this.GetAll_btn.Location = new System.Drawing.Point(38, 48);
            this.GetAll_btn.Name = "GetAll_btn";
            this.GetAll_btn.Size = new System.Drawing.Size(196, 53);
            this.GetAll_btn.TabIndex = 1;
            this.GetAll_btn.Text = "Get All Books";
            this.GetAll_btn.UseVisualStyleBackColor = true;
            this.GetAll_btn.Click += new System.EventHandler(this.GetAll_btn_Click);
            // 
            // GetGameById_btn
            // 
            this.GetGameById_btn.Location = new System.Drawing.Point(38, 123);
            this.GetGameById_btn.Name = "GetGameById_btn";
            this.GetGameById_btn.Size = new System.Drawing.Size(196, 55);
            this.GetGameById_btn.TabIndex = 2;
            this.GetGameById_btn.Text = "Get Book by ID";
            this.GetGameById_btn.UseVisualStyleBackColor = true;
            this.GetGameById_btn.Click += new System.EventHandler(this.GetGameById_btn_Click);
            // 
            // get_book_by_id_numeric
            // 
            this.get_book_by_id_numeric.Location = new System.Drawing.Point(265, 142);
            this.get_book_by_id_numeric.Name = "get_book_by_id_numeric";
            this.get_book_by_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.get_book_by_id_numeric.TabIndex = 3;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(38, 202);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(196, 55);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(38, 293);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(196, 55);
            this.Insert_btn.TabIndex = 5;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(38, 417);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(196, 55);
            this.Update_btn.TabIndex = 6;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // delete_id_numeric
            // 
            this.delete_id_numeric.Location = new System.Drawing.Point(265, 221);
            this.delete_id_numeric.Name = "delete_id_numeric";
            this.delete_id_numeric.Size = new System.Drawing.Size(106, 20);
            this.delete_id_numeric.TabIndex = 7;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(265, 285);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(100, 20);
            this.title_tb.TabIndex = 8;
            // 
            // author_tb
            // 
            this.author_tb.Location = new System.Drawing.Point(265, 311);
            this.author_tb.Name = "author_tb";
            this.author_tb.Size = new System.Drawing.Size(100, 20);
            this.author_tb.TabIndex = 9;
            // 
            // title_update_tb
            // 
            this.title_update_tb.Location = new System.Drawing.Point(265, 435);
            this.title_update_tb.Name = "title_update_tb";
            this.title_update_tb.Size = new System.Drawing.Size(100, 20);
            this.title_update_tb.TabIndex = 10;
            // 
            // author_update_tb
            // 
            this.author_update_tb.Location = new System.Drawing.Point(265, 461);
            this.author_update_tb.Name = "author_update_tb";
            this.author_update_tb.Size = new System.Drawing.Size(100, 20);
            this.author_update_tb.TabIndex = 12;
            // 
            // price_update_numeric
            // 
            this.price_update_numeric.Location = new System.Drawing.Point(265, 487);
            this.price_update_numeric.Name = "price_update_numeric";
            this.price_update_numeric.Size = new System.Drawing.Size(100, 20);
            this.price_update_numeric.TabIndex = 13;
            // 
            // id_update_numeric
            // 
            this.id_update_numeric.Location = new System.Drawing.Point(265, 409);
            this.id_update_numeric.Name = "id_update_numeric";
            this.id_update_numeric.Size = new System.Drawing.Size(100, 20);
            this.id_update_numeric.TabIndex = 14;
            // 
            // insert_price_numeric
            // 
            this.insert_price_numeric.Location = new System.Drawing.Point(265, 338);
            this.insert_price_numeric.Name = "insert_price_numeric";
            this.insert_price_numeric.Size = new System.Drawing.Size(100, 20);
            this.insert_price_numeric.TabIndex = 11;
            // 
            // insert_year
            // 
            this.insert_year.Location = new System.Drawing.Point(265, 364);
            this.insert_year.Name = "insert_year";
            this.insert_year.Size = new System.Drawing.Size(100, 20);
            this.insert_year.TabIndex = 15;
            // 
            // update_year
            // 
            this.update_year.Location = new System.Drawing.Point(265, 513);
            this.update_year.Name = "update_year";
            this.update_year.Size = new System.Drawing.Size(100, 20);
            this.update_year.TabIndex = 16;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(321, 31);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TITLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "AUTHOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "PRICE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "YEAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "YEAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "PRICE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "AUTHOR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "TITLE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(377, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.update_year);
            this.Controls.Add(this.insert_year);
            this.Controls.Add(this.id_update_numeric);
            this.Controls.Add(this.price_update_numeric);
            this.Controls.Add(this.author_update_tb);
            this.Controls.Add(this.insert_price_numeric);
            this.Controls.Add(this.title_update_tb);
            this.Controls.Add(this.author_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.delete_id_numeric);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.get_book_by_id_numeric);
            this.Controls.Add(this.GetGameById_btn);
            this.Controls.Add(this.GetAll_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.get_book_by_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_id_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_update_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_update_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_price_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetAll_btn;
        private System.Windows.Forms.Button GetGameById_btn;
        private System.Windows.Forms.NumericUpDown get_book_by_id_numeric;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.NumericUpDown delete_id_numeric;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox author_tb;
        private System.Windows.Forms.TextBox title_update_tb;
        private System.Windows.Forms.TextBox author_update_tb;
        private System.Windows.Forms.NumericUpDown price_update_numeric;
        private System.Windows.Forms.NumericUpDown id_update_numeric;
        private System.Windows.Forms.NumericUpDown insert_price_numeric;
        private System.Windows.Forms.TextBox insert_year;
        private System.Windows.Forms.TextBox update_year;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

