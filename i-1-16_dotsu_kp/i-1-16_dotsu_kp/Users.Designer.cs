namespace i_1_16_dotsu_kp
{
    partial class Users
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
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_flitration = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.gp_manipulation = new System.Windows.Forms.GroupBox();
            this.cb_dolj = new System.Windows.Forms.ComboBox();
            this.lbl_dolj = new System.Windows.Forms.Label();
            this.tb_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tb_otchestvo = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_otchestvo = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.tb_second_name = new System.Windows.Forms.TextBox();
            this.lbl_second_name = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.gb_search_filtration.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.gp_manipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_flitration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(200, 0);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Size = new System.Drawing.Size(600, 43);
            this.gb_search_filtration.TabIndex = 15;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(491, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(106, 17);
            this.chb_filtration.TabIndex = 1;
            this.chb_filtration.Text = "Отфильтровать";
            this.chb_filtration.UseVisualStyleBackColor = true;
            // 
            // tb_search_flitration
            // 
            this.tb_search_flitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_search_flitration.Location = new System.Drawing.Point(3, 16);
            this.tb_search_flitration.Name = "tb_search_flitration";
            this.tb_search_flitration.Size = new System.Drawing.Size(488, 20);
            this.tb_search_flitration.TabIndex = 0;
            this.tb_search_flitration.Text = "Введите данные поезда...";
            this.tb_search_flitration.WordWrap = false;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Location = new System.Drawing.Point(528, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 35);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_errors
            // 
            this.btn_errors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_errors.Location = new System.Drawing.Point(0, 0);
            this.btn_errors.Name = "btn_errors";
            this.btn_errors.Size = new System.Drawing.Size(72, 35);
            this.btn_errors.TabIndex = 12;
            this.btn_errors.Text = "Ошибки";
            this.btn_errors.UseVisualStyleBackColor = true;
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_close);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(200, 289);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(600, 35);
            this.pn_cancel.TabIndex = 16;
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tickets.Location = new System.Drawing.Point(200, 0);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.Size = new System.Drawing.Size(600, 324);
            this.dgv_tickets.TabIndex = 18;
            // 
            // gp_manipulation
            // 
            this.gp_manipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gp_manipulation.Controls.Add(this.btn_insert);
            this.gp_manipulation.Controls.Add(this.btn_update);
            this.gp_manipulation.Controls.Add(this.cb_dolj);
            this.gp_manipulation.Controls.Add(this.lbl_dolj);
            this.gp_manipulation.Controls.Add(this.tb_confirm_password);
            this.gp_manipulation.Controls.Add(this.lbl_confirm_password);
            this.gp_manipulation.Controls.Add(this.tb_password);
            this.gp_manipulation.Controls.Add(this.lbl_password);
            this.gp_manipulation.Controls.Add(this.tb_login);
            this.gp_manipulation.Controls.Add(this.lbl_login);
            this.gp_manipulation.Controls.Add(this.tb_otchestvo);
            this.gp_manipulation.Controls.Add(this.btn_delete);
            this.gp_manipulation.Controls.Add(this.lbl_otchestvo);
            this.gp_manipulation.Controls.Add(this.tb_first_name);
            this.gp_manipulation.Controls.Add(this.lbl_first_name);
            this.gp_manipulation.Controls.Add(this.tb_second_name);
            this.gp_manipulation.Controls.Add(this.lbl_second_name);
            this.gp_manipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gp_manipulation.Location = new System.Drawing.Point(0, 0);
            this.gp_manipulation.Name = "gp_manipulation";
            this.gp_manipulation.Size = new System.Drawing.Size(200, 324);
            this.gp_manipulation.TabIndex = 17;
            this.gp_manipulation.TabStop = false;
            this.gp_manipulation.Text = "Манипулирование данными";
            // 
            // cb_dolj
            // 
            this.cb_dolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_dolj.FormattingEnabled = true;
            this.cb_dolj.Location = new System.Drawing.Point(3, 227);
            this.cb_dolj.Name = "cb_dolj";
            this.cb_dolj.Size = new System.Drawing.Size(194, 21);
            this.cb_dolj.TabIndex = 26;
            // 
            // lbl_dolj
            // 
            this.lbl_dolj.AutoSize = true;
            this.lbl_dolj.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_dolj.Location = new System.Drawing.Point(3, 214);
            this.lbl_dolj.Name = "lbl_dolj";
            this.lbl_dolj.Size = new System.Drawing.Size(65, 13);
            this.lbl_dolj.TabIndex = 25;
            this.lbl_dolj.Text = "Должность";
            // 
            // tb_confirm_password
            // 
            this.tb_confirm_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_confirm_password.Location = new System.Drawing.Point(3, 194);
            this.tb_confirm_password.Name = "tb_confirm_password";
            this.tb_confirm_password.Size = new System.Drawing.Size(194, 20);
            this.tb_confirm_password.TabIndex = 18;
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_confirm_password.Location = new System.Drawing.Point(3, 181);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(94, 13);
            this.lbl_confirm_password.TabIndex = 17;
            this.lbl_confirm_password.Text = "Повторте пароль";
            // 
            // tb_password
            // 
            this.tb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_password.Location = new System.Drawing.Point(3, 161);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(194, 20);
            this.tb_password.TabIndex = 16;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_password.Location = new System.Drawing.Point(3, 148);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(45, 13);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_login.Location = new System.Drawing.Point(3, 128);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(194, 20);
            this.tb_login.TabIndex = 14;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_login.Location = new System.Drawing.Point(3, 115);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(38, 13);
            this.lbl_login.TabIndex = 13;
            this.lbl_login.Text = "Логин";
            // 
            // tb_otchestvo
            // 
            this.tb_otchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_otchestvo.Location = new System.Drawing.Point(3, 95);
            this.tb_otchestvo.Name = "tb_otchestvo";
            this.tb_otchestvo.Size = new System.Drawing.Size(194, 20);
            this.tb_otchestvo.TabIndex = 12;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(3, 298);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(194, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Удалить билет";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lbl_otchestvo
            // 
            this.lbl_otchestvo.AutoSize = true;
            this.lbl_otchestvo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_otchestvo.Location = new System.Drawing.Point(3, 82);
            this.lbl_otchestvo.Name = "lbl_otchestvo";
            this.lbl_otchestvo.Size = new System.Drawing.Size(128, 13);
            this.lbl_otchestvo.TabIndex = 5;
            this.lbl_otchestvo.Text = "Отчество пользователя";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_first_name.Location = new System.Drawing.Point(3, 62);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(194, 20);
            this.tb_first_name.TabIndex = 4;
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_first_name.Location = new System.Drawing.Point(3, 49);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(103, 13);
            this.lbl_first_name.TabIndex = 3;
            this.lbl_first_name.Text = "Имя пользователя";
            // 
            // tb_second_name
            // 
            this.tb_second_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_second_name.Location = new System.Drawing.Point(3, 29);
            this.tb_second_name.Name = "tb_second_name";
            this.tb_second_name.Size = new System.Drawing.Size(194, 20);
            this.tb_second_name.TabIndex = 2;
            // 
            // lbl_second_name
            // 
            this.lbl_second_name.AutoSize = true;
            this.lbl_second_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_second_name.Location = new System.Drawing.Point(3, 16);
            this.lbl_second_name.Name = "lbl_second_name";
            this.lbl_second_name.Size = new System.Drawing.Size(130, 13);
            this.lbl_second_name.TabIndex = 1;
            this.lbl_second_name.Text = "Фамилия пользователя";
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_update.Location = new System.Drawing.Point(3, 275);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 23);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Изменить данные";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_insert.Location = new System.Drawing.Point(3, 252);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(194, 23);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "Добавить билет";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.gb_search_filtration);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.dgv_tickets);
            this.Controls.Add(this.gp_manipulation);
            this.Name = "Users";
            this.Text = "Users";
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.pn_cancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.gp_manipulation.ResumeLayout(false);
            this.gp_manipulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_flitration;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.GroupBox gp_manipulation;
        private System.Windows.Forms.ComboBox cb_dolj;
        private System.Windows.Forms.Label lbl_dolj;
        private System.Windows.Forms.TextBox tb_confirm_password;
        private System.Windows.Forms.Label lbl_confirm_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox tb_otchestvo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_otchestvo;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.TextBox tb_second_name;
        private System.Windows.Forms.Label lbl_second_name;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
    }
}