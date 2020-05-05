namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.regSername = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regLastName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.regName = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.regSername);
            this.panel1.Controls.Add(this.regPassword);
            this.panel1.Controls.Add(this.regLastName);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.regName);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 639);
            this.panel1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(176, 509);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(186, 28);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Я - руководитель";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // regSername
            // 
            this.regSername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.regSername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.regSername.Location = new System.Drawing.Point(88, 69);
            this.regSername.Multiline = true;
            this.regSername.Name = "regSername";
            this.regSername.Size = new System.Drawing.Size(399, 74);
            this.regSername.TabIndex = 8;
            this.regSername.Text = "Фамилия";
            this.regSername.Enter += new System.EventHandler(this.regSername_Enter);
            this.regSername.Leave += new System.EventHandler(this.regSername_Leave);
            // 
            // regPassword
            // 
            this.regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.regPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.regPassword.Location = new System.Drawing.Point(88, 429);
            this.regPassword.Multiline = true;
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(399, 74);
            this.regPassword.TabIndex = 7;
            this.regPassword.Text = "Пароль";
            this.regPassword.Enter += new System.EventHandler(this.textBox2_Enter);
            this.regPassword.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // regLastName
            // 
            this.regLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.regLastName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.regLastName.Location = new System.Drawing.Point(88, 250);
            this.regLastName.Multiline = true;
            this.regLastName.Name = "regLastName";
            this.regLastName.Size = new System.Drawing.Size(399, 74);
            this.regLastName.TabIndex = 6;
            this.regLastName.Text = "Отчество";
            this.regLastName.Enter += new System.EventHandler(this.regLastName_Enter);
            this.regLastName.Leave += new System.EventHandler(this.regLastName_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(161, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Зарегистрироваться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // regName
            // 
            this.regName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.regName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.regName.Location = new System.Drawing.Point(88, 160);
            this.regName.Multiline = true;
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(399, 74);
            this.regName.TabIndex = 3;
            this.regName.Text = "Имя";
            this.regName.Enter += new System.EventHandler(this.regName_Enter);
            this.regName.Leave += new System.EventHandler(this.regName_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.loginField.Location = new System.Drawing.Point(88, 343);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(399, 68);
            this.loginField.TabIndex = 2;
            this.loginField.Text = "Логин";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 54);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(515, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "х";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regSername;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regLastName;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}