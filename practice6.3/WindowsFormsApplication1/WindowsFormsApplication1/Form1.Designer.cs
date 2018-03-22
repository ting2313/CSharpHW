namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_account = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_gender = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_lookup = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(141, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(141, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_account
            // 
            this.text_account.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_account.Location = new System.Drawing.Point(204, 258);
            this.text_account.Name = "text_account";
            this.text_account.Size = new System.Drawing.Size(100, 31);
            this.text_account.TabIndex = 2;
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_password.Location = new System.Drawing.Point(204, 300);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(100, 31);
            this.text_password.TabIndex = 3;
            this.text_password.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_in
            // 
            this.btn_in.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_in.FlatAppearance.BorderSize = 2;
            this.btn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in.Location = new System.Drawing.Point(185, 353);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(83, 35);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "登入";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "身分證字號";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(70, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "性別";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(70, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "電話";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(70, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "地址";
            this.label6.Visible = false;
            // 
            // text_ID
            // 
            this.text_ID.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_ID.Location = new System.Drawing.Point(127, 18);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(100, 31);
            this.text_ID.TabIndex = 9;
            this.text_ID.Visible = false;
            // 
            // text_gender
            // 
            this.text_gender.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_gender.Location = new System.Drawing.Point(127, 63);
            this.text_gender.Name = "text_gender";
            this.text_gender.Size = new System.Drawing.Size(100, 31);
            this.text_gender.TabIndex = 10;
            this.text_gender.Visible = false;
            // 
            // text_tel
            // 
            this.text_tel.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_tel.Location = new System.Drawing.Point(127, 107);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(100, 31);
            this.text_tel.TabIndex = 11;
            this.text_tel.Visible = false;
            // 
            // text_ad
            // 
            this.text_ad.Font = new System.Drawing.Font("新細明體", 12F);
            this.text_ad.Location = new System.Drawing.Point(127, 150);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(100, 31);
            this.text_ad.TabIndex = 12;
            this.text_ad.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(353, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 31);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_find
            // 
            this.btn_find.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_find.FlatAppearance.BorderSize = 2;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Location = new System.Drawing.Point(248, 19);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(84, 30);
            this.btn_find.TabIndex = 14;
            this.btn_find.Text = "搜尋";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Visible = false;
            this.btn_find.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_lookup
            // 
            this.btn_lookup.Location = new System.Drawing.Point(353, 63);
            this.btn_lookup.Name = "btn_lookup";
            this.btn_lookup.Size = new System.Drawing.Size(85, 31);
            this.btn_lookup.TabIndex = 15;
            this.btn_lookup.Text = "查詢";
            this.btn_lookup.UseVisualStyleBackColor = true;
            this.btn_lookup.Visible = false;
            this.btn_lookup.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(353, 107);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(85, 31);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "刪除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(353, 153);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(85, 28);
            this.btn_out.TabIndex = 17;
            this.btn_out.Text = "登出";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Visible = false;
            this.btn_out.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(248, 21);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(99, 28);
            this.btn_check.TabIndex = 18;
            this.btn_check.Text = "確認刪除?";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Visible = false;
            this.btn_check.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(248, 150);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(84, 31);
            this.btn_yes.TabIndex = 19;
            this.btn_yes.Text = "確認";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Visible = false;
            this.btn_yes.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_lookup);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.text_gender);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_account;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_gender;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_lookup;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

