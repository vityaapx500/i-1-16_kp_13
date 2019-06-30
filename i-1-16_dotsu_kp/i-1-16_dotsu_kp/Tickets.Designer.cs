namespace i_1_16_dotsu_kp
{
    partial class Tickets
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
            this.cb_passenger = new System.Windows.Forms.ComboBox();
            this.lbl_passenger = new System.Windows.Forms.Label();
            this.tb_place_status = new System.Windows.Forms.TextBox();
            this.lbl_place_status = new System.Windows.Forms.Label();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.lbl_place = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_date_departure = new System.Windows.Forms.TextBox();
            this.lbl_date_departure = new System.Windows.Forms.Label();
            this.tb_time_departure = new System.Windows.Forms.TextBox();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.gp_manipulation = new System.Windows.Forms.GroupBox();
            this.cb_employee = new System.Windows.Forms.ComboBox();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.cb_route = new System.Windows.Forms.ComboBox();
            this.lbl_route = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lbl_time_departure = new System.Windows.Forms.Label();
            this.tb_time_registry = new System.Windows.Forms.TextBox();
            this.lbl_time_registry = new System.Windows.Forms.Label();
            this.tb_num_ticket = new System.Windows.Forms.TextBox();
            this.lbl_num_ticket = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_errors = new System.Windows.Forms.Button();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.gb_search_filtration = new System.Windows.Forms.GroupBox();
            this.chb_filtration = new System.Windows.Forms.CheckBox();
            this.tb_search_flitration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.gp_manipulation.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            this.gb_search_filtration.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_passenger
            // 
            this.cb_passenger.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_passenger.FormattingEnabled = true;
            this.cb_passenger.Location = new System.Drawing.Point(3, 260);
            this.cb_passenger.Name = "cb_passenger";
            this.cb_passenger.Size = new System.Drawing.Size(194, 21);
            this.cb_passenger.TabIndex = 26;
            // 
            // lbl_passenger
            // 
            this.lbl_passenger.AutoSize = true;
            this.lbl_passenger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_passenger.Location = new System.Drawing.Point(3, 247);
            this.lbl_passenger.Name = "lbl_passenger";
            this.lbl_passenger.Size = new System.Drawing.Size(59, 13);
            this.lbl_passenger.TabIndex = 25;
            this.lbl_passenger.Text = "Пассажир";
            // 
            // tb_place_status
            // 
            this.tb_place_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_place_status.Location = new System.Drawing.Point(3, 227);
            this.tb_place_status.Name = "tb_place_status";
            this.tb_place_status.Size = new System.Drawing.Size(194, 20);
            this.tb_place_status.TabIndex = 20;
            // 
            // lbl_place_status
            // 
            this.lbl_place_status.AutoSize = true;
            this.lbl_place_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_place_status.Location = new System.Drawing.Point(3, 214);
            this.lbl_place_status.Name = "lbl_place_status";
            this.lbl_place_status.Size = new System.Drawing.Size(75, 13);
            this.lbl_place_status.TabIndex = 19;
            this.lbl_place_status.Text = "Статус места";
            // 
            // tb_place
            // 
            this.tb_place.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_place.Location = new System.Drawing.Point(3, 194);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(194, 20);
            this.tb_place.TabIndex = 18;
            // 
            // lbl_place
            // 
            this.lbl_place.AutoSize = true;
            this.lbl_place.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_place.Location = new System.Drawing.Point(3, 181);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(39, 13);
            this.lbl_place.TabIndex = 17;
            this.lbl_place.Text = "Место";
            // 
            // tb_price
            // 
            this.tb_price.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_price.Location = new System.Drawing.Point(3, 161);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(194, 20);
            this.tb_price.TabIndex = 16;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_price.Location = new System.Drawing.Point(3, 148);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(62, 13);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "Стоимость";
            // 
            // tb_date_departure
            // 
            this.tb_date_departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_date_departure.Location = new System.Drawing.Point(3, 128);
            this.tb_date_departure.Name = "tb_date_departure";
            this.tb_date_departure.Size = new System.Drawing.Size(194, 20);
            this.tb_date_departure.TabIndex = 14;
            // 
            // lbl_date_departure
            // 
            this.lbl_date_departure.AutoSize = true;
            this.lbl_date_departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_date_departure.Location = new System.Drawing.Point(3, 115);
            this.lbl_date_departure.Name = "lbl_date_departure";
            this.lbl_date_departure.Size = new System.Drawing.Size(101, 13);
            this.lbl_date_departure.TabIndex = 13;
            this.lbl_date_departure.Text = "Дата отправления";
            // 
            // tb_time_departure
            // 
            this.tb_time_departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_time_departure.Location = new System.Drawing.Point(3, 95);
            this.tb_time_departure.Name = "tb_time_departure";
            this.tb_time_departure.Size = new System.Drawing.Size(194, 20);
            this.tb_time_departure.TabIndex = 12;
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tickets.Location = new System.Drawing.Point(200, 0);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.Size = new System.Drawing.Size(601, 478);
            this.dgv_tickets.TabIndex = 14;
            // 
            // gp_manipulation
            // 
            this.gp_manipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gp_manipulation.Controls.Add(this.cb_employee);
            this.gp_manipulation.Controls.Add(this.lbl_employee);
            this.gp_manipulation.Controls.Add(this.cb_route);
            this.gp_manipulation.Controls.Add(this.lbl_route);
            this.gp_manipulation.Controls.Add(this.cb_passenger);
            this.gp_manipulation.Controls.Add(this.lbl_passenger);
            this.gp_manipulation.Controls.Add(this.tb_place_status);
            this.gp_manipulation.Controls.Add(this.lbl_place_status);
            this.gp_manipulation.Controls.Add(this.tb_place);
            this.gp_manipulation.Controls.Add(this.lbl_place);
            this.gp_manipulation.Controls.Add(this.tb_price);
            this.gp_manipulation.Controls.Add(this.lbl_price);
            this.gp_manipulation.Controls.Add(this.tb_date_departure);
            this.gp_manipulation.Controls.Add(this.lbl_date_departure);
            this.gp_manipulation.Controls.Add(this.tb_time_departure);
            this.gp_manipulation.Controls.Add(this.btn_delete);
            this.gp_manipulation.Controls.Add(this.btn_update);
            this.gp_manipulation.Controls.Add(this.btn_insert);
            this.gp_manipulation.Controls.Add(this.lbl_time_departure);
            this.gp_manipulation.Controls.Add(this.tb_time_registry);
            this.gp_manipulation.Controls.Add(this.lbl_time_registry);
            this.gp_manipulation.Controls.Add(this.tb_num_ticket);
            this.gp_manipulation.Controls.Add(this.lbl_num_ticket);
            this.gp_manipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gp_manipulation.Location = new System.Drawing.Point(0, 0);
            this.gp_manipulation.Name = "gp_manipulation";
            this.gp_manipulation.Size = new System.Drawing.Size(200, 478);
            this.gp_manipulation.TabIndex = 13;
            this.gp_manipulation.TabStop = false;
            this.gp_manipulation.Text = "Манипулирование данными";
            // 
            // cb_employee
            // 
            this.cb_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(3, 328);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(194, 21);
            this.cb_employee.TabIndex = 30;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_employee.Location = new System.Drawing.Point(3, 315);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(44, 13);
            this.lbl_employee.TabIndex = 29;
            this.lbl_employee.Text = "Кассир";
            // 
            // cb_route
            // 
            this.cb_route.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_route.FormattingEnabled = true;
            this.cb_route.Location = new System.Drawing.Point(3, 294);
            this.cb_route.Name = "cb_route";
            this.cb_route.Size = new System.Drawing.Size(194, 21);
            this.cb_route.TabIndex = 28;
            // 
            // lbl_route
            // 
            this.lbl_route.AutoSize = true;
            this.lbl_route.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_route.Location = new System.Drawing.Point(3, 281);
            this.lbl_route.Name = "lbl_route";
            this.lbl_route.Size = new System.Drawing.Size(52, 13);
            this.lbl_route.TabIndex = 27;
            this.lbl_route.Text = "Маршрут";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(0, 409);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(194, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Удалить билет";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(0, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Изменить данные";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(0, 363);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(194, 23);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Добавить билет";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // lbl_time_departure
            // 
            this.lbl_time_departure.AutoSize = true;
            this.lbl_time_departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_time_departure.Location = new System.Drawing.Point(3, 82);
            this.lbl_time_departure.Name = "lbl_time_departure";
            this.lbl_time_departure.Size = new System.Drawing.Size(108, 13);
            this.lbl_time_departure.TabIndex = 5;
            this.lbl_time_departure.Text = "Время отправления";
            // 
            // tb_time_registry
            // 
            this.tb_time_registry.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_time_registry.Location = new System.Drawing.Point(3, 62);
            this.tb_time_registry.Name = "tb_time_registry";
            this.tb_time_registry.Size = new System.Drawing.Size(194, 20);
            this.tb_time_registry.TabIndex = 4;
            // 
            // lbl_time_registry
            // 
            this.lbl_time_registry.AutoSize = true;
            this.lbl_time_registry.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_time_registry.Location = new System.Drawing.Point(3, 49);
            this.lbl_time_registry.Name = "lbl_time_registry";
            this.lbl_time_registry.Size = new System.Drawing.Size(107, 13);
            this.lbl_time_registry.TabIndex = 3;
            this.lbl_time_registry.Text = "Время оформления";
            // 
            // tb_num_ticket
            // 
            this.tb_num_ticket.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_num_ticket.Location = new System.Drawing.Point(3, 29);
            this.tb_num_ticket.Name = "tb_num_ticket";
            this.tb_num_ticket.Size = new System.Drawing.Size(194, 20);
            this.tb_num_ticket.TabIndex = 2;
            // 
            // lbl_num_ticket
            // 
            this.lbl_num_ticket.AutoSize = true;
            this.lbl_num_ticket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_num_ticket.Location = new System.Drawing.Point(3, 16);
            this.lbl_num_ticket.Name = "lbl_num_ticket";
            this.lbl_num_ticket.Size = new System.Drawing.Size(79, 13);
            this.lbl_num_ticket.TabIndex = 1;
            this.lbl_num_ticket.Text = "Номер билета";
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
            // pn_cancel
            // 
            this.pn_cancel.Controls.Add(this.btn_close);
            this.pn_cancel.Controls.Add(this.btn_errors);
            this.pn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_cancel.Location = new System.Drawing.Point(0, 478);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(801, 35);
            this.pn_cancel.TabIndex = 12;
            // 
            // gb_search_filtration
            // 
            this.gb_search_filtration.Controls.Add(this.chb_filtration);
            this.gb_search_filtration.Controls.Add(this.tb_search_flitration);
            this.gb_search_filtration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_search_filtration.Location = new System.Drawing.Point(200, 0);
            this.gb_search_filtration.Name = "gb_search_filtration";
            this.gb_search_filtration.Size = new System.Drawing.Size(601, 43);
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
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 513);
            this.Controls.Add(this.gb_search_filtration);
            this.Controls.Add(this.dgv_tickets);
            this.Controls.Add(this.gp_manipulation);
            this.Controls.Add(this.pn_cancel);
            this.Name = "Tickets";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.gp_manipulation.ResumeLayout(false);
            this.gp_manipulation.PerformLayout();
            this.pn_cancel.ResumeLayout(false);
            this.gb_search_filtration.ResumeLayout(false);
            this.gb_search_filtration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_passenger;
        private System.Windows.Forms.Label lbl_passenger;
        private System.Windows.Forms.TextBox tb_place_status;
        private System.Windows.Forms.Label lbl_place_status;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_date_departure;
        private System.Windows.Forms.Label lbl_date_departure;
        private System.Windows.Forms.TextBox tb_time_departure;
        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.GroupBox gp_manipulation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_time_departure;
        private System.Windows.Forms.TextBox tb_time_registry;
        private System.Windows.Forms.Label lbl_time_registry;
        private System.Windows.Forms.TextBox tb_num_ticket;
        private System.Windows.Forms.Label lbl_num_ticket;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_errors;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.ComboBox cb_route;
        private System.Windows.Forms.Label lbl_route;
        private System.Windows.Forms.GroupBox gb_search_filtration;
        private System.Windows.Forms.CheckBox chb_filtration;
        private System.Windows.Forms.TextBox tb_search_flitration;
    }
}