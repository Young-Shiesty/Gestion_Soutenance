namespace AppSenSoutenance.views.parametre
{
    partial class frmDepartement
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
            this.dgDepartement = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.Label();
            this.txtNomDepartement = new System.Windows.Forms.TextBox();
            this.txtCodeDepartement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDepartement
            // 
            this.dgDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartement.Location = new System.Drawing.Point(373, 3);
            this.dgDepartement.Name = "dgDepartement";
            this.dgDepartement.RowHeadersWidth = 51;
            this.dgDepartement.RowTemplate.Height = 24;
            this.dgDepartement.Size = new System.Drawing.Size(309, 475);
            this.dgDepartement.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(12, 81);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(117, 16);
            this.Code.TabIndex = 1;
            this.Code.Text = "Nom Departement";
            // 
            // txtNomDepartement
            // 
            this.txtNomDepartement.Location = new System.Drawing.Point(15, 114);
            this.txtNomDepartement.Name = "txtNomDepartement";
            this.txtNomDepartement.Size = new System.Drawing.Size(274, 22);
            this.txtNomDepartement.TabIndex = 1;
            // 
            // txtCodeDepartement
            // 
            this.txtCodeDepartement.Location = new System.Drawing.Point(15, 198);
            this.txtCodeDepartement.Name = "txtCodeDepartement";
            this.txtCodeDepartement.Size = new System.Drawing.Size(274, 22);
            this.txtCodeDepartement.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code Departement";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(132, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 402);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCodeDepartement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomDepartement);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.dgDepartement);
            this.Name = "frmDepartement";
            this.Text = "Departement";
            this.Load += new System.EventHandler(this.frmDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDepartement;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox txtNomDepartement;
        private System.Windows.Forms.TextBox txtCodeDepartement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}