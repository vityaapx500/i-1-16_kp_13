namespace i_1_16_dotsu_kp
{
    partial class AuthorizationForm
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
            this.btn_registr = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_authoriz = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_registr
            // 
            this.btn_registr.Location = new System.Drawing.Point(25, 234);
            this.btn_registr.Name = "btn_registr";
            this.btn_registr.Size = new System.Drawing.Size(130, 23);
            this.btn_registr.TabIndex = 17;
            this.btn_registr.Text = "Зарегистрироваться";
            this.btn_registr.UseVisualStyleBackColor = true;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(161, 234);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(130, 23);
            this.btn_enter.TabIndex = 16;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(77, 154);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(135, 20);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Введите пароль";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_login.Location = new System.Drawing.Point(77, 87);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(124, 20);
            this.lbl_login.TabIndex = 13;
            this.lbl_login.Text = "Введите логин";
            // 
            // lbl_authoriz
            // 
            this.lbl_authoriz.AutoSize = true;
            this.lbl_authoriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_authoriz.Location = new System.Drawing.Point(53, 19);
            this.lbl_authoriz.Name = "lbl_authoriz";
            this.lbl_authoriz.Size = new System.Drawing.Size(200, 37);
            this.lbl_authoriz.TabIndex = 12;
            this.lbl_authoriz.Text = "Авторизация";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(81, 177);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(172, 29);
            this.tb_password.TabIndex = 10;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(81, 110);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(172, 29);
            this.tb_login.TabIndex = 9;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 269);
            this.Controls.Add(this.btn_registr);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_authoriz);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registr;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_authoriz;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
    }
}