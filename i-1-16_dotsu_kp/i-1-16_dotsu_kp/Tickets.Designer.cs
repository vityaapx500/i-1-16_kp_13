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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbSearchFiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1008, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 15;
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
            this.btnErrors.TabIndex = 16;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 434);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1080, 35);
            this.pnCancel.TabIndex = 12;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(1080, 43);
            this.gbSearchFiltration.TabIndex = 16;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(971, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(106, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(968, 20);
            this.tbSearchFlitration.TabIndex = 1;
            this.tbSearchFlitration.Text = "Введите данные поезда...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(0, 43);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.Size = new System.Drawing.Size(1080, 391);
            this.dgvTickets.TabIndex = 17;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 469);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.pnCancel);
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Билеты";
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
        private System.Windows.Forms.DataGridView dgvTickets;
    }
}