
namespace Theatre_ARM
{
    partial class Regisrtacia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_but = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NumberField = new System.Windows.Forms.MaskedTextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_block = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_block = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(335, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(632, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "______________________________________________________________";
            // 
            // reg_but
            // 
            this.reg_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reg_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_but.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_but.ForeColor = System.Drawing.Color.White;
            this.reg_but.Location = new System.Drawing.Point(261, 747);
            this.reg_but.Name = "reg_but";
            this.reg_but.Size = new System.Drawing.Size(749, 93);
            this.reg_but.TabIndex = 10;
            this.reg_but.Text = "Зарегистрироваться";
            this.reg_but.UseVisualStyleBackColor = true;
            this.reg_but.Click += new System.EventHandler(this.reg_but_Click);
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(340, 194);
            this.NameField.Margin = new System.Windows.Forms.Padding(4);
            this.NameField.Multiline = true;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(592, 46);
            this.NameField.TabIndex = 35;
            // 
            // SurnameField
            // 
            this.SurnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameField.Location = new System.Drawing.Point(340, 276);
            this.SurnameField.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(592, 46);
            this.SurnameField.TabIndex = 34;
            // 
            // NumberField
            // 
            this.NumberField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberField.Location = new System.Drawing.Point(340, 366);
            this.NumberField.Margin = new System.Windows.Forms.Padding(4);
            this.NumberField.Mask = "+7(000)-000-00-00";
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(485, 22);
            this.NumberField.TabIndex = 33;
            // 
            // LoginField
            // 
            this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(340, 424);
            this.LoginField.Margin = new System.Windows.Forms.Padding(4);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(592, 46);
            this.LoginField.TabIndex = 32;
            // 
            // PassField
            // 
            this.PassField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PassField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(340, 506);
            this.PassField.Margin = new System.Windows.Forms.Padding(4);
            this.PassField.Multiline = true;
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(592, 46);
            this.PassField.TabIndex = 31;
            // 
            // EmailField
            // 
            this.EmailField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(340, 113);
            this.EmailField.Margin = new System.Windows.Forms.Padding(4);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(592, 46);
            this.EmailField.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(336, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(336, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(335, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(336, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "Логин";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(336, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(336, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 41;
            this.label8.Text = "Имя";
            // 
            // textBox_block
            // 
            this.textBox_block.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_block.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_block.Location = new System.Drawing.Point(581, 559);
            this.textBox_block.Multiline = true;
            this.textBox_block.Name = "textBox_block";
            this.textBox_block.Size = new System.Drawing.Size(351, 40);
            this.textBox_block.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(336, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "Проверочный код";
            // 
            // button_block
            // 
            this.button_block.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_block.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_block.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_block.Location = new System.Drawing.Point(581, 605);
            this.button_block.Name = "button_block";
            this.button_block.Size = new System.Drawing.Size(351, 40);
            this.button_block.TabIndex = 44;
            this.button_block.Text = "отправить";
            this.button_block.UseVisualStyleBackColor = true;
            this.button_block.Click += new System.EventHandler(this.button_block_Click);
            // 
            // Regisrtacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1275, 852);
            this.Controls.Add(this.button_block);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_block);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.reg_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Regisrtacia";
            this.Text = "Regisrtacia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regisrtacia_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reg_but;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.MaskedTextBox NumberField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_block;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_block;
    }
}