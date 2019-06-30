namespace i_1_16_dotsu_kp
{
    partial class Trains
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
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.gp_manipulation = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cb_steward_employee = new System.Windows.Forms.ComboBox();
            this.lbl_steward_employee = new System.Windows.Forms.Label();
            this.cb_mach_employee = new System.Windows.Forms.ComboBox();
            this.lbl_mach_employee = new System.Windows.Forms.Label();
            this.tb_kol_vo_wagon = new System.Windows.Forms.TextBox();
            this.lbl_kol_vo_wagon = new System.Windows.Forms.Label();
            this.tb_nomer_train = new System.Windows.Forms.TextBox();
            this.lbl_nomer_train = new System.Windows.Forms.Label();
            this.dgv_trains = new System.Windows.Forms.DataGridView();
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_flitration = new System.Windows.Forms.TextBox();
            this.pn_cancel.SuspendLayout();
            this.gp_manipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trains)).BeginInit();
            this.gb_search_filtration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_close);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 262);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(801, 35);
            this.pn_cancel.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Location = new System.Drawing.Point(729, 0);
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
            // gp_manipulation
            // 
            this.gp_manipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gp_manipulation.Controls.Add(this.btn_delete);
            this.gp_manipulation.Controls.Add(this.btn_update);
            this.gp_manipulation.Controls.Add(this.btn_insert);
            this.gp_manipulation.Controls.Add(this.cb_steward_employee);
            this.gp_manipulation.Controls.Add(this.lbl_steward_employee);
            this.gp_manipulation.Controls.Add(this.cb_mach_employee);
            this.gp_manipulation.Controls.Add(this.lbl_mach_employee);
            this.gp_manipulation.Controls.Add(this.tb_kol_vo_wagon);
            this.gp_manipulation.Controls.Add(this.lbl_kol_vo_wagon);
            this.gp_manipulation.Controls.Add(this.tb_nomer_train);
            this.gp_manipulation.Controls.Add(this.lbl_nomer_train);
            this.gp_manipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gp_manipulation.Location = new System.Drawing.Point(0, 0);
            this.gp_manipulation.Name = "gp_manipulation";
            this.gp_manipulation.Size = new System.Drawing.Size(200, 262);
            this.gp_manipulation.TabIndex = 5;
            this.gp_manipulation.TabStop = false;
            this.gp_manipulation.Text = "Манипулирование данными";
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delete.Location = new System.Drawing.Point(3, 196);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(194, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Удалить поезд";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.Location = new System.Drawing.Point(3, 173);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Изменить данные";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_insert.Location = new System.Drawing.Point(3, 150);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(194, 23);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Добавить поезд";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // cb_steward_employee
            // 
            this.cb_steward_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_steward_employee.FormattingEnabled = true;
            this.cb_steward_employee.Location = new System.Drawing.Point(3, 129);
            this.cb_steward_employee.Name = "cb_steward_employee";
            this.cb_steward_employee.Size = new System.Drawing.Size(194, 21);
            this.cb_steward_employee.TabIndex = 8;
            // 
            // lbl_steward_employee
            // 
            this.lbl_steward_employee.AutoSize = true;
            this.lbl_steward_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_steward_employee.Location = new System.Drawing.Point(3, 116);
            this.lbl_steward_employee.Name = "lbl_steward_employee";
            this.lbl_steward_employee.Size = new System.Drawing.Size(80, 13);
            this.lbl_steward_employee.TabIndex = 7;
            this.lbl_steward_employee.Text = "Номер поезда";
            // 
            // cb_mach_employee
            // 
            this.cb_mach_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_mach_employee.FormattingEnabled = true;
            this.cb_mach_employee.Location = new System.Drawing.Point(3, 95);
            this.cb_mach_employee.Name = "cb_mach_employee";
            this.cb_mach_employee.Size = new System.Drawing.Size(194, 21);
            this.cb_mach_employee.TabIndex = 6;
            // 
            // lbl_mach_employee
            // 
            this.lbl_mach_employee.AutoSize = true;
            this.lbl_mach_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_mach_employee.Location = new System.Drawing.Point(3, 82);
            this.lbl_mach_employee.Name = "lbl_mach_employee";
            this.lbl_mach_employee.Size = new System.Drawing.Size(59, 13);
            this.lbl_mach_employee.TabIndex = 5;
            this.lbl_mach_employee.Text = "Машинист";
            // 
            // tb_kol_vo_wagon
            // 
            this.tb_kol_vo_wagon.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_kol_vo_wagon.Location = new System.Drawing.Point(3, 62);
            this.tb_kol_vo_wagon.Name = "tb_kol_vo_wagon";
            this.tb_kol_vo_wagon.Size = new System.Drawing.Size(194, 20);
            this.tb_kol_vo_wagon.TabIndex = 4;
            // 
            // lbl_kol_vo_wagon
            // 
            this.lbl_kol_vo_wagon.AutoSize = true;
            this.lbl_kol_vo_wagon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_kol_vo_wagon.Location = new System.Drawing.Point(3, 49);
            this.lbl_kol_vo_wagon.Name = "lbl_kol_vo_wagon";
            this.lbl_kol_vo_wagon.Size = new System.Drawing.Size(110, 13);
            this.lbl_kol_vo_wagon.TabIndex = 3;
            this.lbl_kol_vo_wagon.Text = "Количество вагонов";
            // 
            // tb_nomer_train
            // 
            this.tb_nomer_train.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_nomer_train.Location = new System.Drawing.Point(3, 29);
            this.tb_nomer_train.Name = "tb_nomer_train";
            this.tb_nomer_train.Size = new System.Drawing.Size(194, 20);
            this.tb_nomer_train.TabIndex = 2;
            // 
            // lbl_nomer_train
            // 
            this.lbl_nomer_train.AutoSize = true;
            this.lbl_nomer_train.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nomer_train.Location = new System.Drawing.Point(3, 16);
            this.lbl_nomer_train.Name = "lbl_nomer_train";
            this.lbl_nomer_train.Size = new System.Drawing.Size(80, 13);
            this.lbl_nomer_train.TabIndex = 1;
            this.lbl_nomer_train.Text = "Номер поезда";
            // 
            // dgv_trains
            // 
            this.dgv_trains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_trains.Location = new System.Drawing.Point(200, 0);
            this.dgv_trains.Name = "dgv_trains";
            this.dgv_trains.Size = new System.Drawing.Size(601, 262);
            this.dgv_trains.TabIndex = 6;
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_flitration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(200, 0);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Size = new System.Drawing.Size(601, 43);
            this.gb_search_filtration.TabIndex = 7;
            this.gb_search_filtration.TabStop = false;
            this.gb_search_filtration.Text = "Поиск и фильтрация";
            // 
            // chb_filtration
            // 
            this.chb_filtration.AutoSize = true;
            this.chb_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb_filtration.Location = new System.Drawing.Point(491, 16);
            this.chb_filtration.Name = "chb_filtration";
            this.chb_filtration.Size = new System.Drawing.Size(107, 17);
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
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 297);
            this.Controls.Add(this.gb_search_filtration);
            this.Controls.Add(this.dgv_trains);
            this.Controls.Add(this.gp_manipulation);
            this.Controls.Add(this.pn_cancel);
            this.Name = "Trains";
            this.Text = "Справочник Поезда";
            this.pn_cancel.ResumeLayout(false);
            this.gp_manipulation.ResumeLayout(false);
            this.gp_manipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trains)).EndInit();
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.GroupBox gp_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox cb_steward_employee;
        private System.Windows.Forms.Label lbl_steward_employee;
        private System.Windows.Forms.ComboBox cb_mach_employee;
        private System.Windows.Forms.Label lbl_mach_employee;
        private System.Windows.Forms.TextBox tb_kol_vo_wagon;
        private System.Windows.Forms.Label lbl_kol_vo_wagon;
        private System.Windows.Forms.TextBox tb_nomer_train;
        private System.Windows.Forms.Label lbl_nomer_train;
        private System.Windows.Forms.DataGridView dgv_trains;
        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_flitration;
    }
}