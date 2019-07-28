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
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbStewardEmployee = new System.Windows.Forms.ComboBox();
            this.lblStewardEmployee = new System.Windows.Forms.Label();
            this.cbMachEmployee = new System.Windows.Forms.ComboBox();
            this.lblMachEmployee = new System.Windows.Forms.Label();
            this.tbKol_voWagon = new System.Windows.Forms.TextBox();
            this.lblKol_voWagon = new System.Windows.Forms.Label();
            this.tbNomerTrain = new System.Windows.Forms.TextBox();
            this.lblNomerTrain = new System.Windows.Forms.Label();
            this.dgvTrains = new System.Windows.Forms.DataGridView();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            this.pnCancel.SuspendLayout();
            this.gpManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).BeginInit();
            this.gbSearchFiltration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 262);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(801, 35);
            this.pnCancel.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(729, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.cbStewardEmployee);
            this.gpManipulation.Controls.Add(this.lblStewardEmployee);
            this.gpManipulation.Controls.Add(this.cbMachEmployee);
            this.gpManipulation.Controls.Add(this.lblMachEmployee);
            this.gpManipulation.Controls.Add(this.tbKol_voWagon);
            this.gpManipulation.Controls.Add(this.lblKol_voWagon);
            this.gpManipulation.Controls.Add(this.tbNomerTrain);
            this.gpManipulation.Controls.Add(this.lblNomerTrain);
            this.gpManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpManipulation.Location = new System.Drawing.Point(0, 0);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.Size = new System.Drawing.Size(200, 262);
            this.gpManipulation.TabIndex = 5;
            this.gpManipulation.TabStop = false;
            this.gpManipulation.Text = "Манипулирование данными";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(3, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить поезд";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(3, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(3, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(194, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Добавить поезд";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // cbStewardEmployee
            // 
            this.cbStewardEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbStewardEmployee.FormattingEnabled = true;
            this.cbStewardEmployee.Location = new System.Drawing.Point(3, 129);
            this.cbStewardEmployee.Name = "cbStewardEmployee";
            this.cbStewardEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbStewardEmployee.TabIndex = 8;
            // 
            // lblStewardEmployee
            // 
            this.lblStewardEmployee.AutoSize = true;
            this.lblStewardEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStewardEmployee.Location = new System.Drawing.Point(3, 116);
            this.lblStewardEmployee.Name = "lblStewardEmployee";
            this.lblStewardEmployee.Size = new System.Drawing.Size(80, 13);
            this.lblStewardEmployee.TabIndex = 7;
            this.lblStewardEmployee.Text = "Номер поезда";
            // 
            // cbMachEmployee
            // 
            this.cbMachEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMachEmployee.FormattingEnabled = true;
            this.cbMachEmployee.Location = new System.Drawing.Point(3, 95);
            this.cbMachEmployee.Name = "cbMachEmployee";
            this.cbMachEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbMachEmployee.TabIndex = 6;
            // 
            // lblMachEmployee
            // 
            this.lblMachEmployee.AutoSize = true;
            this.lblMachEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMachEmployee.Location = new System.Drawing.Point(3, 82);
            this.lblMachEmployee.Name = "lblMachEmployee";
            this.lblMachEmployee.Size = new System.Drawing.Size(59, 13);
            this.lblMachEmployee.TabIndex = 5;
            this.lblMachEmployee.Text = "Машинист";
            // 
            // tbKol_voWagon
            // 
            this.tbKol_voWagon.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbKol_voWagon.Location = new System.Drawing.Point(3, 62);
            this.tbKol_voWagon.Name = "tbKol_voWagon";
            this.tbKol_voWagon.Size = new System.Drawing.Size(194, 20);
            this.tbKol_voWagon.TabIndex = 4;
            // 
            // lblKol_voWagon
            // 
            this.lblKol_voWagon.AutoSize = true;
            this.lblKol_voWagon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKol_voWagon.Location = new System.Drawing.Point(3, 49);
            this.lblKol_voWagon.Name = "lblKol_voWagon";
            this.lblKol_voWagon.Size = new System.Drawing.Size(110, 13);
            this.lblKol_voWagon.TabIndex = 3;
            this.lblKol_voWagon.Text = "Количество вагонов";
            // 
            // tbNomerTrain
            // 
            this.tbNomerTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNomerTrain.Location = new System.Drawing.Point(3, 29);
            this.tbNomerTrain.Name = "tbNomerTrain";
            this.tbNomerTrain.Size = new System.Drawing.Size(194, 20);
            this.tbNomerTrain.TabIndex = 2;
            // 
            // lblNomerTrain
            // 
            this.lblNomerTrain.AutoSize = true;
            this.lblNomerTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomerTrain.Location = new System.Drawing.Point(3, 16);
            this.lblNomerTrain.Name = "lblNomerTrain";
            this.lblNomerTrain.Size = new System.Drawing.Size(80, 13);
            this.lblNomerTrain.TabIndex = 1;
            this.lblNomerTrain.Text = "Номер поезда";
            // 
            // dgvTrains
            // 
            this.dgvTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrains.Location = new System.Drawing.Point(200, 0);
            this.dgvTrains.Name = "dgvTrains";
            this.dgvTrains.Size = new System.Drawing.Size(601, 262);
            this.dgvTrains.TabIndex = 6;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(200, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(601, 43);
            this.gbSearchFiltration.TabIndex = 7;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(491, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(107, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(488, 20);
            this.tbSearchFlitration.TabIndex = 0;
            this.tbSearchFlitration.Text = "Введите данные поезда...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 297);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.dgvTrains);
            this.Controls.Add(this.gpManipulation);
            this.Controls.Add(this.pnCancel);
            this.Name = "Trains";
            this.Text = "Справочник Поезда";
            this.pnCancel.ResumeLayout(false);
            this.gpManipulation.ResumeLayout(false);
            this.gpManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrains)).EndInit();
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.GroupBox gpManipulation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbStewardEmployee;
        private System.Windows.Forms.Label lblStewardEmployee;
        private System.Windows.Forms.ComboBox cbMachEmployee;
        private System.Windows.Forms.Label lblMachEmployee;
        private System.Windows.Forms.TextBox tbKol_voWagon;
        private System.Windows.Forms.Label lblKol_voWagon;
        private System.Windows.Forms.TextBox tbNomerTrain;
        private System.Windows.Forms.Label lblNomerTrain;
        private System.Windows.Forms.DataGridView dgvTrains;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
    }
}