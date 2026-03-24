// Frmsoutenance.designer 
namespace AppSenSoutenance.views.parametre
{
    partial class frmSoutenance
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
            this.dgSoutenance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateSoutenance = new System.Windows.Forms.TextBox();
            this.txtLieuSoutenance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultatSoutenance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMentionSoutenance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservationSoutenance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1060, 72);
            this.pnlHeader.TabIndex = 20;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Gestion des Soutenances";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(199, 219, 254);
            this.lblSubtitle.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Ajoutez, modifiez ou supprimez les soutenances";

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.btnSelectionner);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.txtDateSoutenance);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.txtLieuSoutenance);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.txtResultatSoutenance);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.txtMentionSoutenance);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.txtObservationSoutenance);
            this.pnlForm.Controls.Add(this.btnAjouter);
            this.pnlForm.Controls.Add(this.btnModifier);
            this.pnlForm.Controls.Add(this.btnSupprimer);
            this.pnlForm.Location = new System.Drawing.Point(16, 88);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(310, 630);
            this.pnlForm.TabIndex = 21;

            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSelectionner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(20, 20);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(270, 38);
            this.btnSelectionner.TabIndex = 9;
            this.btnSelectionner.Text = "  S\u00e9lectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Soutenance";

            this.txtDateSoutenance.BackColor = System.Drawing.Color.White;
            this.txtDateSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDateSoutenance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtDateSoutenance.Location = new System.Drawing.Point(20, 100);
            this.txtDateSoutenance.Name = "txtDateSoutenance";
            this.txtDateSoutenance.Size = new System.Drawing.Size(270, 30);
            this.txtDateSoutenance.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label2.Location = new System.Drawing.Point(20, 148);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Lieu Soutenance";

            this.txtLieuSoutenance.BackColor = System.Drawing.Color.White;
            this.txtLieuSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLieuSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLieuSoutenance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtLieuSoutenance.Location = new System.Drawing.Point(20, 170);
            this.txtLieuSoutenance.Name = "txtLieuSoutenance";
            this.txtLieuSoutenance.Size = new System.Drawing.Size(270, 30);
            this.txtLieuSoutenance.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label3.Location = new System.Drawing.Point(20, 218);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "R\u00e9sultat Soutenance";

            this.txtResultatSoutenance.BackColor = System.Drawing.Color.White;
            this.txtResultatSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultatSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResultatSoutenance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtResultatSoutenance.Location = new System.Drawing.Point(20, 240);
            this.txtResultatSoutenance.Name = "txtResultatSoutenance";
            this.txtResultatSoutenance.Size = new System.Drawing.Size(270, 30);
            this.txtResultatSoutenance.TabIndex = 3;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label4.Location = new System.Drawing.Point(20, 288);
            this.label4.Name = "label4";
            this.label4.TabIndex = 7;
            this.label4.Text = "Mention Soutenance";

            this.txtMentionSoutenance.BackColor = System.Drawing.Color.White;
            this.txtMentionSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMentionSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMentionSoutenance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtMentionSoutenance.Location = new System.Drawing.Point(20, 310);
            this.txtMentionSoutenance.Name = "txtMentionSoutenance";
            this.txtMentionSoutenance.Size = new System.Drawing.Size(270, 30);
            this.txtMentionSoutenance.TabIndex = 4;

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label5.Location = new System.Drawing.Point(20, 358);
            this.label5.Name = "label5";
            this.label5.TabIndex = 9;
            this.label5.Text = "Observation Soutenance";

            this.txtObservationSoutenance.BackColor = System.Drawing.Color.White;
            this.txtObservationSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservationSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservationSoutenance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtObservationSoutenance.Location = new System.Drawing.Point(20, 380);
            this.txtObservationSoutenance.Name = "txtObservationSoutenance";
            this.txtObservationSoutenance.Size = new System.Drawing.Size(270, 30);
            this.txtObservationSoutenance.TabIndex = 5;

            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 140, 60);
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(20, 434);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(270, 38);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "  Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(190, 100, 0);
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(20, 482);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(270, 38);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "  Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(20, 530);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(270, 38);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "  Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // dgSoutenance
            this.dgSoutenance.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgSoutenance.BackgroundColor = System.Drawing.Color.White;
            this.dgSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSoutenance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSoutenance.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.dgSoutenance.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgSoutenance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgSoutenance.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgSoutenance.ColumnHeadersHeight = 40;
            this.dgSoutenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSoutenance.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSoutenance.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgSoutenance.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgSoutenance.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgSoutenance.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgSoutenance.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgSoutenance.EnableHeadersVisualStyles = false;
            this.dgSoutenance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgSoutenance.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgSoutenance.Location = new System.Drawing.Point(346, 88);
            this.dgSoutenance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSoutenance.Name = "dgSoutenance";
            this.dgSoutenance.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgSoutenance.RowHeadersWidth = 40;
            this.dgSoutenance.RowTemplate.Height = 32;
            this.dgSoutenance.Size = new System.Drawing.Size(698, 630);
            this.dgSoutenance.TabIndex = 0;
            this.dgSoutenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoutenance_CellClick);

            // frmSoutenance
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1060, 736);
            this.ControlBox = false;
            this.Controls.Add(this.dgSoutenance);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmSoutenance";
            this.Text = "Gestion des Soutenances";
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgSoutenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateSoutenance;
        private System.Windows.Forms.TextBox txtLieuSoutenance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultatSoutenance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMentionSoutenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservationSoutenance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlForm;
    }
}