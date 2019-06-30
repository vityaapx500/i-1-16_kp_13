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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_registr = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_login.Location = new System.Drawing.Point(0, 54);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(128, 20);
            this.lbl_login.TabIndex = 13;
            this.lbl_login.Text = "Введите логин:";
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(241, 54);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Авторизация";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_login
            // 
            this.tb_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(0, 74);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(241, 26);
            this.tb_login.TabIndex = 18;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(0, 100);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(139, 20);
            this.lbl_password.TabIndex = 22;
            this.lbl_password.Text = "Введете пароль:";
            // 
            // tb_password
            // 
            this.tb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(0, 120);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(241, 26);
            this.tb_password.TabIndex = 23;
            // 
            // btn_registr
            // 
            this.btn_registr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_registr.Location = new System.Drawing.Point(0, 190);
            this.btn_registr.Name = "btn_registr";
            this.btn_registr.Size = new System.Drawing.Size(241, 23);
            this.btn_registr.TabIndex = 26;
            this.btn_registr.Text = "Зарегистрироваться";
            this.btn_registr.UseVisualStyleBackColor = true;
            // 
            // btn_enter
            // 
            this.btn_enter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_enter.Location = new System.Drawing.Point(0, 167);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(241, 23);
            this.btn_enter.TabIndex = 27;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 213);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_registr);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_title);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_registr;
        private System.Windows.Forms.Button btn_enter;
    }
}