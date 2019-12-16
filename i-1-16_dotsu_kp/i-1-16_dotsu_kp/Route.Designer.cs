namespace i_1_16_dotsu_kp
{
    partial class Route
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
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbTrainDriver = new System.Windows.Forms.ComboBox();
            this.lblTrainDriver = new System.Windows.Forms.Label();
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.tbTimeDeparture = new System.Windows.Forms.TextBox();
            this.lblTimeDeparture = new System.Windows.Forms.Label();
            this.tbTimeArrival = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblTimeArrival = new System.Windows.Forms.Label();
            this.tbNaznachStatiopn = new System.Windows.Forms.TextBox();
            this.lblNaznachStation = new System.Windows.Forms.Label();
            this.tbNumRoute = new System.Windows.Forms.TextBox();
            this.lblNumRoute = new System.Windows.Forms.Label();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.btnRouteList = new System.Windows.Forms.Button();
            this.gbSearchFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gpManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(488, 20);
            this.tbSearchFlitration.TabIndex = 0;
            this.tbSearchFlitration.Text = "Введите данные маршрута...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(200, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(600, 43);
            this.gbSearchFiltration.TabIndex = 15;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(491, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(106, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(200, 329);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(600, 35);
            this.pnCancel.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(528, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(72, 35);
            this.btnErrors.TabIndex = 12;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // gpManipulation
            // 
            this.gpManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpManipulation.Controls.Add(this.btnRouteList);
            this.gpManipulation.Controls.Add(this.tbPrice);
            this.gpManipulation.Controls.Add(this.lblPrice);
            this.gpManipulation.Controls.Add(this.cbTrainDriver);
            this.gpManipulation.Controls.Add(this.lblTrainDriver);
            this.gpManipulation.Controls.Add(this.cbTrain);
            this.gpManipulation.Controls.Add(this.lblTrain);
            this.gpManipulation.Controls.Add(this.tbTimeDeparture);
            this.gpManipulation.Controls.Add(this.lblTimeDeparture);
            this.gpManipulation.Controls.Add(this.tbTimeArrival);
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.lblTimeArrival);
            this.gpManipulation.Controls.Add(this.tbNaznachStatiopn);
            this.gpManipulation.Controls.Add(this.lblNaznachStation);
            this.gpManipulation.Controls.Add(this.tbNumRoute);
            this.gpManipulation.Controls.Add(this.lblNumRoute);
            this.gpManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpManipulation.Location = new System.Drawing.Point(0, 0);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.Size = new System.Drawing.Size(200, 364);
            this.gpManipulation.TabIndex = 13;
            this.gpManipulation.TabStop = false;
            this.gpManipulation.Text = "Манипулирование данными";
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(3, 229);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(194, 20);
            this.tbPrice.TabIndex = 38;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(3, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "Цена";
            // 
            // cbTrainDriver
            // 
            this.cbTrainDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTrainDriver.FormattingEnabled = true;
            this.cbTrainDriver.Location = new System.Drawing.Point(3, 195);
            this.cbTrainDriver.Name = "cbTrainDriver";
            this.cbTrainDriver.Size = new System.Drawing.Size(194, 21);
            this.cbTrainDriver.TabIndex = 36;
            // 
            // lblTrainDriver
            // 
            this.lblTrainDriver.AutoSize = true;
            this.lblTrainDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainDriver.Location = new System.Drawing.Point(3, 182);
            this.lblTrainDriver.Name = "lblTrainDriver";
            this.lblTrainDriver.Size = new System.Drawing.Size(59, 13);
            this.lblTrainDriver.TabIndex = 37;
            this.lblTrainDriver.Text = "Машинист";
            // 
            // cbTrain
            // 
            this.cbTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(3, 161);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(194, 21);
            this.cbTrain.TabIndex = 33;
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrain.Location = new System.Drawing.Point(3, 148);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(39, 13);
            this.lblTrain.TabIndex = 35;
            this.lblTrain.Text = "Поезд";
            // 
            // tbTimeDeparture
            // 
            this.tbTimeDeparture.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTimeDeparture.Location = new System.Drawing.Point(3, 128);
            this.tbTimeDeparture.Name = "tbTimeDeparture";
            this.tbTimeDeparture.Size = new System.Drawing.Size(194, 20);
            this.tbTimeDeparture.TabIndex = 4;
            // 
            // lblTimeDeparture
            // 
            this.lblTimeDeparture.AutoSize = true;
            this.lblTimeDeparture.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimeDeparture.Location = new System.Drawing.Point(3, 115);
            this.lblTimeDeparture.Name = "lblTimeDeparture";
            this.lblTimeDeparture.Size = new System.Drawing.Size(108, 13);
            this.lblTimeDeparture.TabIndex = 13;
            this.lblTimeDeparture.Text = "Время отправления";
            // 
            // tbTimeArrival
            // 
            this.tbTimeArrival.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTimeArrival.Location = new System.Drawing.Point(3, 95);
            this.tbTimeArrival.Name = "tbTimeArrival";
            this.tbTimeArrival.Size = new System.Drawing.Size(194, 20);
            this.tbTimeArrival.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить маршрута";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(0, 276);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Добавить маршрут";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // lblTimeArrival
            // 
            this.lblTimeArrival.AutoSize = true;
            this.lblTimeArrival.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimeArrival.Location = new System.Drawing.Point(3, 82);
            this.lblTimeArrival.Name = "lblTimeArrival";
            this.lblTimeArrival.Size = new System.Drawing.Size(92, 13);
            this.lblTimeArrival.TabIndex = 5;
            this.lblTimeArrival.Text = "Время прибытия";
            // 
            // tbNaznachStatiopn
            // 
            this.tbNaznachStatiopn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNaznachStatiopn.Location = new System.Drawing.Point(3, 62);
            this.tbNaznachStatiopn.Name = "tbNaznachStatiopn";
            this.tbNaznachStatiopn.Size = new System.Drawing.Size(194, 20);
            this.tbNaznachStatiopn.TabIndex = 2;
            // 
            // lblNaznachStation
            // 
            this.lblNaznachStation.AutoSize = true;
            this.lblNaznachStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNaznachStation.Location = new System.Drawing.Point(3, 49);
            this.lblNaznachStation.Name = "lblNaznachStation";
            this.lblNaznachStation.Size = new System.Drawing.Size(111, 13);
            this.lblNaznachStation.TabIndex = 3;
            this.lblNaznachStation.Text = "Станция назначения";
            // 
            // tbNumRoute
            // 
            this.tbNumRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumRoute.Location = new System.Drawing.Point(3, 29);
            this.tbNumRoute.Name = "tbNumRoute";
            this.tbNumRoute.Size = new System.Drawing.Size(194, 20);
            this.tbNumRoute.TabIndex = 1;
            // 
            // lblNumRoute
            // 
            this.lblNumRoute.AutoSize = true;
            this.lblNumRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumRoute.Location = new System.Drawing.Point(3, 16);
            this.lblNumRoute.Name = "lblNumRoute";
            this.lblNumRoute.Size = new System.Drawing.Size(94, 13);
            this.lblNumRoute.TabIndex = 1;
            this.lblNumRoute.Text = "Номер маршрута";
            // 
            // dgvRoute
            // 
            this.dgvRoute.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoute.Location = new System.Drawing.Point(200, 43);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.Size = new System.Drawing.Size(600, 286);
            this.dgvRoute.TabIndex = 18;
            // 
            // btnRouteList
            // 
            this.btnRouteList.Location = new System.Drawing.Point(0, 338);
            this.btnRouteList.Name = "btnRouteList";
            this.btnRouteList.Size = new System.Drawing.Size(200, 23);
            this.btnRouteList.TabIndex = 40;
            this.btnRouteList.Text = "Список маршрутов";
            this.btnRouteList.UseVisualStyleBackColor = true;
            this.btnRouteList.Click += new System.EventHandler(this.btnRouteList_Click);
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.dgvRoute);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gpManipulation);
            this.Name = "Route";
            this.Text = "Справочник Маршруты";
            this.Load += new System.EventHandler(this.Route_Load);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gpManipulation.ResumeLayout(false);
            this.gpManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchFlitration;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.GroupBox gpManipulation;
        private System.Windows.Forms.TextBox tbTimeDeparture;
        private System.Windows.Forms.Label lblTimeDeparture;
        private System.Windows.Forms.TextBox tbTimeArrival;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblTimeArrival;
        private System.Windows.Forms.TextBox tbNaznachStatiopn;
        private System.Windows.Forms.Label lblNaznachStation;
        private System.Windows.Forms.TextBox tbNumRoute;
        private System.Windows.Forms.Label lblNumRoute;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbTrainDriver;
        private System.Windows.Forms.Label lblTrainDriver;
        private System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.Label lblTrain;
        public System.Windows.Forms.DataGridView dgvRoute;
        public System.Windows.Forms.Button btnRouteList;
    }
}