namespace ProiectEAV_Muzee
{
    partial class ManageFilesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lvDate = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Program = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PretCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RatingCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Utilizator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelRat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsers
            // 
            this.cmbUsers.Location = new System.Drawing.Point(140, 22);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(180, 24);
            this.cmbUsers.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(140, 62);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(180, 22);
            this.txtFileName.TabIndex = 3;
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(140, 102);
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(180, 22);
            this.txtLocalitate.TabIndex = 5;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(140, 142);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 22);
            this.txtPret.TabIndex = 7;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(140, 182);
            this.txtRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(120, 22);
            this.txtRating.TabIndex = 9;
            this.txtRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Adaugă";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Șterge";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(340, 230);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 35);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sortare A-Z";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lvDate
            // 
            this.lvDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Program,
            this.LocCol,
            this.PretCol,
            this.RatingCol,
            this.Utilizator});
            this.lvDate.FullRowSelect = true;
            this.lvDate.GridLines = true;
            this.lvDate.HideSelection = false;
            this.lvDate.Location = new System.Drawing.Point(25, 330);
            this.lvDate.Name = "lvDate";
            this.lvDate.Size = new System.Drawing.Size(850, 300);
            this.lvDate.TabIndex = 15;
            this.lvDate.UseCompatibleStateImageBehavior = false;
            this.lvDate.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume Muzeu";
            this.Nume.Width = 180;
            // 
            // Program
            // 
            this.Program.Text = "Program Vizitare";
            this.Program.Width = 120;
            // 
            // LocCol
            // 
            this.LocCol.Text = "Localitate";
            this.LocCol.Width = 120;
            // 
            // PretCol
            // 
            this.PretCol.Text = "Preț Bilet";
            this.PretCol.Width = 80;
            // 
            // RatingCol
            // 
            this.RatingCol.Text = "Rating";
            this.RatingCol.Width = 80;
            // 
            // Utilizator
            // 
            this.Utilizator.Text = "Utilizator";
            this.Utilizator.Width = 120;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 287);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 22);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege Utilizator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Muzeu:";
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Location = new System.Drawing.Point(25, 105);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(68, 16);
            this.labelLoc.TabIndex = 4;
            this.labelLoc.Text = "Localitate:";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(25, 145);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(63, 16);
            this.labelPret.TabIndex = 6;
            this.labelPret.Text = "Preț Bilet:";
            // 
            // labelRat
            // 
            this.labelRat.AutoSize = true;
            this.labelRat.Location = new System.Drawing.Point(25, 185);
            this.labelRat.Name = "labelRat";
            this.labelRat.Size = new System.Drawing.Size(78, 16);
            this.labelRat.TabIndex = 8;
            this.labelRat.Text = "Rating (1-5):";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "CAUTĂ:";
            // 
            // btnExportXML
            // 
            this.btnExportXML.Location = new System.Drawing.Point(459, 230);
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(139, 35);
            this.btnExportXML.TabIndex = 16;
            this.btnExportXML.Text = "Exportă în XML";
            this.btnExportXML.UseVisualStyleBackColor = true;
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // ManageFilesForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnExportXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.txtLocalitate);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.labelRat);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvDate);
            this.Name = "ManageFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune Muzee Oltenia - Versiune Extinsă";
            this.Load += new System.EventHandler(this.ManageFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.NumericUpDown txtRating;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListView lvDate;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Program;
        private System.Windows.Forms.ColumnHeader LocCol;
        private System.Windows.Forms.ColumnHeader PretCol;
        private System.Windows.Forms.ColumnHeader RatingCol;
        private System.Windows.Forms.ColumnHeader Utilizator;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelRat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportXML;
    }
}