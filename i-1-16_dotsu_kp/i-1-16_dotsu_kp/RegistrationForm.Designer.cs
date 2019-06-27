namespace i_1_16_dotsu_kp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_regist = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_configm_password = new System.Windows.Forms.Label();
            this.btn_authoriz = new System.Windows.Forms.Button();
            this.btn_registr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(72, 94);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(172, 29);
            this.tb_login.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(72, 161);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(172, 29);
            this.tb_password.TabIndex = 1;
            // 
            // tb_confirm_password
            // 
            this.tb_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_confirm_password.Location = new System.Drawing.Point(72, 225);
            this.tb_confirm_password.Name = "tb_confirm_password";
            this.tb_confirm_password.Size = new System.Drawing.Size(172, 29);
            this.tb_confirm_password.TabIndex = 2;
            // 
            // lbl_regist
            // 
            this.lbl_regist.AutoSize = true;
            this.lbl_regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_regist.Location = new System.Drawing.Point(65, 22);
            this.lbl_regist.Name = "lbl_regist";
            this.lbl_regist.Size = new System.Drawing.Size(194, 37);
            this.lbl_regist.TabIndex = 3;
            this.lbl_regist.Text = "Регистрация\r\n";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_login.Location = new System.Drawing.Point(68, 71);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(124, 20);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "Введите логин";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(68, 138);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(135, 20);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Введите пароль";
            // 
            // lbl_configm_password
            // 
            this.lbl_configm_password.AutoSize = true;
            this.lbl_configm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_configm_password.Location = new System.Drawing.Point(68, 202);
            this.lbl_configm_password.Name = "lbl_configm_password";
            this.lbl_configm_password.Size = new System.Drawing.Size(152, 20);
            this.lbl_configm_password.TabIndex = 6;
            this.lbl_configm_password.Text = "Повторите пароль";
            // 
            // btn_authoriz
            // 
            this.btn_authoriz.Location = new System.Drawing.Point(27, 270);
            this.btn_authoriz.Name = "btn_authoriz";
            this.btn_authoriz.Size = new System.Drawing.Size(130, 23);
            this.btn_authoriz.TabIndex = 7;
            this.btn_authoriz.Text = "Авторизироваться";
            this.btn_authoriz.UseVisualStyleBackColor = true;
            // 
            // btn_registr
            // 
            this.btn_registr.Location = new System.Drawing.Point(163, 270);
            this.btn_registr.Name = "btn_registr";
            this.btn_registr.Size = new System.Drawing.Size(130, 23);
            this.btn_registr.TabIndex = 8;
            this.btn_registr.Text = "Зарегистрироваться";
            this.btn_registr.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 314);
            this.Controls.Add(this.btn_registr);
            this.Controls.Add(this.btn_authoriz);
            this.Controls.Add(this.lbl_configm_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_regist);
            this.Controls.Add(this.tb_confirm_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_confirm_password;
        private System.Windows.Forms.Label lbl_regist;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_configm_password;
        private System.Windows.Forms.Button btn_authoriz;
        private System.Windows.Forms.Button btn_registr;
    }
}

