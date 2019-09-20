namespace i_1_16_dotsu_kp
{
    partial class TrainsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainsForm));
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbTrainDriver = new System.Windows.Forms.ComboBox();
            this.lblTrainDriver = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.pnCancel, "pnCancel");
            this.pnCancel.Name = "pnCancel";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnErrors
            // 
            resources.ApplyResources(this.btnErrors, "btnErrors");
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // gpManipulation
            // 
            resources.ApplyResources(this.gpManipulation, "gpManipulation");
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.cbTrainDriver);
            this.gpManipulation.Controls.Add(this.lblTrainDriver);
            this.gpManipulation.Controls.Add(this.tbKol_voWagon);
            this.gpManipulation.Controls.Add(this.lblKol_voWagon);
            this.gpManipulation.Controls.Add(this.tbNomerTrain);
            this.gpManipulation.Controls.Add(this.lblNomerTrain);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.TabStop = false;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbTrainDriver
            // 
            resources.ApplyResources(this.cbTrainDriver, "cbTrainDriver");
            this.cbTrainDriver.FormattingEnabled = true;
            this.cbTrainDriver.Name = "cbTrainDriver";
            // 
            // lblTrainDriver
            // 
            resources.ApplyResources(this.lblTrainDriver, "lblTrainDriver");
            this.lblTrainDriver.Name = "lblTrainDriver";
            // 
            // tbKol_voWagon
            // 
            resources.ApplyResources(this.tbKol_voWagon, "tbKol_voWagon");
            this.tbKol_voWagon.Name = "tbKol_voWagon";
            // 
            // lblKol_voWagon
            // 
            resources.ApplyResources(this.lblKol_voWagon, "lblKol_voWagon");
            this.lblKol_voWagon.Name = "lblKol_voWagon";
            // 
            // tbNomerTrain
            // 
            resources.ApplyResources(this.tbNomerTrain, "tbNomerTrain");
            this.tbNomerTrain.Name = "tbNomerTrain";
            // 
            // lblNomerTrain
            // 
            resources.ApplyResources(this.lblNomerTrain, "lblNomerTrain");
            this.lblNomerTrain.Name = "lblNomerTrain";
            // 
            // dgvTrains
            // 
            this.dgvTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvTrains, "dgvTrains");
            this.dgvTrains.Name = "dgvTrains";
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            resources.ApplyResources(this.gbSearchFiltration, "gbSearchFiltration");
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.TabStop = false;
            // 
            // chbFiltration
            // 
            resources.ApplyResources(this.chbFiltration, "chbFiltration");
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            resources.ApplyResources(this.tbSearchFlitration, "tbSearchFlitration");
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            // 
            // TrainsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.dgvTrains);
            this.Controls.Add(this.gpManipulation);
            this.Controls.Add(this.pnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainsForm";
            this.Load += new System.EventHandler(this.Trains_Load);
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
        private System.Windows.Forms.ComboBox cbTrainDriver;
        private System.Windows.Forms.Label lblTrainDriver;
        private System.Windows.Forms.TextBox tbKol_voWagon;
        private System.Windows.Forms.Label lblKol_voWagon;
        private System.Windows.Forms.TextBox tbNomerTrain;
        private System.Windows.Forms.Label lblNomerTrain;
        private System.Windows.Forms.DataGridView dgvTrains;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnInsert;
    }
}