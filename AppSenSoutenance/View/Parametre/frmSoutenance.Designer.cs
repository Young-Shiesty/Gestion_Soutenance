namespace AppSenSoutenance.views.parametre
{
    partial class frmSoutenance
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
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSoutenance
            // 
            this.dgSoutenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoutenance.Location = new System.Drawing.Point(392, -2);
            this.dgSoutenance.Name = "dgSoutenance";
            this.dgSoutenance.RowHeadersWidth = 51;
            this.dgSoutenance.RowTemplate.Height = 24;
            this.dgSoutenance.Size = new System.Drawing.Size(905, 579);
            this.dgSoutenance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Soutenance";
            // 
            // txtDateSoutenance
            // 
            this.txtDateSoutenance.Location = new System.Drawing.Point(43, 127);
            this.txtDateSoutenance.Name = "txtDateSoutenance";
            this.txtDateSoutenance.Size = new System.Drawing.Size(283, 22);
            this.txtDateSoutenance.TabIndex = 1;
            // 
            // txtLieuSoutenance
            // 
            this.txtLieuSoutenance.Location = new System.Drawing.Point(43, 201);
            this.txtLieuSoutenance.Name = "txtLieuSoutenance";
            this.txtLieuSoutenance.Size = new System.Drawing.Size(283, 22);
            this.txtLieuSoutenance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lieu Soutenance";

            // 
            // txtResultatSoutenance
            // 
            this.txtResultatSoutenance.Location = new System.Drawing.Point(43, 295);
            this.txtResultatSoutenance.Name = "txtResultatSoutenance";
            this.txtResultatSoutenance.Size = new System.Drawing.Size(283, 22);
            this.txtResultatSoutenance.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultat Soutenance";
            // 
            // txtMentionSoutenance
            // 
            this.txtMentionSoutenance.Location = new System.Drawing.Point(43, 361);
            this.txtMentionSoutenance.Name = "txtMentionSoutenance";
            this.txtMentionSoutenance.Size = new System.Drawing.Size(283, 22);
            this.txtMentionSoutenance.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mention Soutenance";
            // 
            // txtObservationSoutenance
            // 
            this.txtObservationSoutenance.Location = new System.Drawing.Point(43, 460);
            this.txtObservationSoutenance.Name = "txtObservationSoutenance";
            this.txtObservationSoutenance.Size = new System.Drawing.Size(283, 22);
            this.txtObservationSoutenance.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observation Soutenance";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(43, 529);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(82, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(164, 529);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(81, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(293, 529);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(81, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(43, 31);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(230, 23);
            this.btnSelectionner.TabIndex = 9;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // frmSoutenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1231, 575);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtObservationSoutenance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMentionSoutenance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultatSoutenance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLieuSoutenance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateSoutenance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSoutenance);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmSoutenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}