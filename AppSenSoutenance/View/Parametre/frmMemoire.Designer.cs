// Frmmemoire.designer
namespace AppSenSoutenance.Views.Parametre
{
    partial class frmMemoire
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgMemoire = new System.Windows.Forms.DataGridView();
            this.txtSujetMemoire = new System.Windows.Forms.TextBox();
            this.sujet = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.anneeacademique = new System.Windows.Forms.Label();
            this.cbbSession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // pnlHeader
            // ════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(980, 72);
            this.pnlHeader.TabIndex = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Gestion des M\u00e9moires";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(199, 219, 254);
            this.lblSubtitle.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Ajoutez et supprimez les m\u00e9moires de soutenance";

            // ════════════════════════════════════════════════════════════════
            // pnlForm  (white card — left side)
            // ════════════════════════════════════════════════════════════════
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.sujet);
            this.pnlForm.Controls.Add(this.txtSujetMemoire);
            this.pnlForm.Controls.Add(this.anneeacademique);
            this.pnlForm.Controls.Add(this.cbbAnneeAcademique);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.cbbSession);
            this.pnlForm.Controls.Add(this.btnSelect);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnRemove);
            this.pnlForm.Location = new System.Drawing.Point(16, 88);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(300, 480);
            this.pnlForm.TabIndex = 31;

            // sujet — Sujet Mémoire
            this.sujet.AutoSize = true;
            this.sujet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sujet.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.sujet.Location = new System.Drawing.Point(20, 20);
            this.sujet.Name = "sujet";
            this.sujet.TabIndex = 14;
            this.sujet.Text = "Sujet M\u00e9moire";
            // txtSujetMemoire
            this.txtSujetMemoire.BackColor = System.Drawing.Color.White;
            this.txtSujetMemoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSujetMemoire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSujetMemoire.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtSujetMemoire.Location = new System.Drawing.Point(20, 42);
            this.txtSujetMemoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(260, 30);
            this.txtSujetMemoire.TabIndex = 13;

            // anneeacademique — Année Académique
            this.anneeacademique.AutoSize = true;
            this.anneeacademique.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.anneeacademique.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.anneeacademique.Location = new System.Drawing.Point(20, 94);
            this.anneeacademique.Name = "anneeacademique";
            this.anneeacademique.TabIndex = 16;
            this.anneeacademique.Text = "Ann\u00e9e Acad\u00e9mique";
            // cbbAnneeAcademique
            this.cbbAnneeAcademique.BackColor = System.Drawing.Color.White;
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbAnneeAcademique.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(20, 116);
            this.cbbAnneeAcademique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(260, 30);
            this.cbbAnneeAcademique.TabIndex = 17;

            // label3 — Session
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.TabIndex = 18;
            this.label3.Text = "Session";
            // cbbSession
            this.cbbSession.BackColor = System.Drawing.Color.White;
            this.cbbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSession.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbbSession.FormattingEnabled = true;
            this.cbbSession.Location = new System.Drawing.Point(20, 190);
            this.cbbSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSession.Name = "cbbSession";
            this.cbbSession.Size = new System.Drawing.Size(260, 30);
            this.cbbSession.TabIndex = 19;

            // btnSelect
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(20, 246);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(260, 38);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "  S\u00e9lectionner";
            this.btnSelect.UseVisualStyleBackColor = false;

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 140, 60);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 298);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 38);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "  Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(20, 350);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(260, 38);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "  Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // ════════════════════════════════════════════════════════════════
            // dgMemoire
            // ════════════════════════════════════════════════════════════════
            this.dgMemoire.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgMemoire.BackgroundColor = System.Drawing.Color.White;
            this.dgMemoire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMemoire.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMemoire.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.dgMemoire.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgMemoire.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgMemoire.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgMemoire.ColumnHeadersHeight = 40;
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgMemoire.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgMemoire.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgMemoire.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgMemoire.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgMemoire.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgMemoire.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgMemoire.EnableHeadersVisualStyles = false;
            this.dgMemoire.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgMemoire.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgMemoire.Location = new System.Drawing.Point(336, 88);
            this.dgMemoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgMemoire.RowHeadersWidth = 40;
            this.dgMemoire.RowTemplate.Height = 32;
            this.dgMemoire.Size = new System.Drawing.Size(628, 480);
            this.dgMemoire.TabIndex = 1;

            // ════════════════════════════════════════════════════════════════
            // frmMemoire
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.ControlBox = false;
            this.Controls.Add(this.dgMemoire);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemoire";
            this.Text = "Gestion des M\u00e9moires";
            this.Load += new System.EventHandler(this.frmMemoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgMemoire;
        private System.Windows.Forms.TextBox txtSujetMemoire;
        private System.Windows.Forms.Label sujet;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Label anneeacademique;
        private System.Windows.Forms.ComboBox cbbSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlForm;
    }
}