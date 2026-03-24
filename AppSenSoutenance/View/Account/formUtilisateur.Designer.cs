// Formutilisateur.designer 
using System.Windows.Forms;

namespace AppSenSoutenance.View.Account
{
    partial class formUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.pnlCandidatButtons = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCandidatForm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.pnlProfesseurButtons = new System.Windows.Forms.Panel();
            this.btnPSelect = new System.Windows.Forms.Button();
            this.btnPsup = new System.Windows.Forms.Button();
            this.btnPmod = new System.Windows.Forms.Button();
            this.btnPadd = new System.Windows.Forms.Button();
            this.pnlProfesseurForm = new System.Windows.Forms.Panel();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPtel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPprenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPnom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabChefDepatrement = new System.Windows.Forms.TabPage();
            this.pnlChefButtons = new System.Windows.Forms.Panel();
            this.btnCsup = new System.Windows.Forms.Button();
            this.btnCmod = new System.Windows.Forms.Button();
            this.btnCadd = new System.Windows.Forms.Button();
            this.pnlChefForm = new System.Windows.Forms.Panel();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCtel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCprenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCnom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.pnlCandidatButtons.SuspendLayout();
            this.pnlCandidatForm.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.pnlProfesseurButtons.SuspendLayout();
            this.pnlProfesseurForm.SuspendLayout();
            this.tabChefDepatrement.SuspendLayout();
            this.pnlChefButtons.SuspendLayout();
            this.pnlChefForm.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepatrement);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(16, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabCandidat.Controls.Add(this.pnlCandidatButtons);
            this.tabCandidat.Controls.Add(this.pnlCandidatForm);
            this.tabCandidat.Location = new System.Drawing.Point(4, 34);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Size = new System.Drawing.Size(422, 550);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "  Candidat  ";
            // 
            // pnlCandidatButtons
            // 
            this.pnlCandidatButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlCandidatButtons.Controls.Add(this.btnRemove);
            this.pnlCandidatButtons.Controls.Add(this.btnEdit);
            this.pnlCandidatButtons.Controls.Add(this.btnAdd);
            this.pnlCandidatButtons.Location = new System.Drawing.Point(12, 500);
            this.pnlCandidatButtons.Name = "pnlCandidatButtons";
            this.pnlCandidatButtons.Size = new System.Drawing.Size(400, 52);
            this.pnlCandidatButtons.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(252, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 38);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "  Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(126, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 38);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "  Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 38);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "  Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlCandidatForm
            // 
            this.pnlCandidatForm.BackColor = System.Drawing.Color.White;
            this.pnlCandidatForm.Controls.Add(this.label5);
            this.pnlCandidatForm.Controls.Add(this.txtMatricule);
            this.pnlCandidatForm.Controls.Add(this.label16);
            this.pnlCandidatForm.Controls.Add(this.txtEmail);
            this.pnlCandidatForm.Controls.Add(this.label4);
            this.pnlCandidatForm.Controls.Add(this.txtTel);
            this.pnlCandidatForm.Controls.Add(this.label3);
            this.pnlCandidatForm.Controls.Add(this.txtPrenom);
            this.pnlCandidatForm.Controls.Add(this.label2);
            this.pnlCandidatForm.Controls.Add(this.txtNom);
            this.pnlCandidatForm.Controls.Add(this.label1);
            this.pnlCandidatForm.Location = new System.Drawing.Point(12, 12);
            this.pnlCandidatForm.Name = "pnlCandidatForm";
            this.pnlCandidatForm.Size = new System.Drawing.Size(400, 480);
            this.pnlCandidatForm.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 0);
            this.label5.TabIndex = 47;
            // 
            // txtMatricule
            // 
            this.txtMatricule.BackColor = System.Drawing.Color.White;
            this.txtMatricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtMatricule.Location = new System.Drawing.Point(24, 322);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(352, 34);
            this.txtMatricule.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label16.Location = new System.Drawing.Point(24, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 25);
            this.label16.TabIndex = 48;
            this.label16.Text = "Matricule";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtEmail.Location = new System.Drawing.Point(24, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 34);
            this.txtEmail.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(24, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtTel.Location = new System.Drawing.Point(24, 182);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(352, 34);
            this.txtTel.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Téléphone";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPrenom.Location = new System.Drawing.Point(24, 112);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(352, 34);
            this.txtPrenom.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNom.Location = new System.Drawing.Point(24, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(352, 34);
            this.txtNom.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nom";
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabProfesseur.Controls.Add(this.pnlProfesseurButtons);
            this.tabProfesseur.Controls.Add(this.pnlProfesseurForm);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 34);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Size = new System.Drawing.Size(422, 550);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "  Professeur  ";
            // 
            // pnlProfesseurButtons
            // 
            this.pnlProfesseurButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlProfesseurButtons.Controls.Add(this.btnPSelect);
            this.pnlProfesseurButtons.Controls.Add(this.btnPsup);
            this.pnlProfesseurButtons.Controls.Add(this.btnPmod);
            this.pnlProfesseurButtons.Controls.Add(this.btnPadd);
            this.pnlProfesseurButtons.Location = new System.Drawing.Point(12, 500);
            this.pnlProfesseurButtons.Name = "pnlProfesseurButtons";
            this.pnlProfesseurButtons.Size = new System.Drawing.Size(400, 52);
            this.pnlProfesseurButtons.TabIndex = 0;
            // 
            // btnPSelect
            // 
            this.btnPSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSelect.FlatAppearance.BorderSize = 0;
            this.btnPSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnPSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPSelect.ForeColor = System.Drawing.Color.White;
            this.btnPSelect.Location = new System.Drawing.Point(0, 7);
            this.btnPSelect.Name = "btnPSelect";
            this.btnPSelect.Size = new System.Drawing.Size(160, 38);
            this.btnPSelect.TabIndex = 60;
            this.btnPSelect.Text = "  Sélectionner";
            this.btnPSelect.UseVisualStyleBackColor = false;
            this.btnPSelect.Visible = false;
            // 
            // btnPsup
            // 
            this.btnPsup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPsup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPsup.FlatAppearance.BorderSize = 0;
            this.btnPsup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPsup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPsup.ForeColor = System.Drawing.Color.White;
            this.btnPsup.Location = new System.Drawing.Point(252, 7);
            this.btnPsup.Name = "btnPsup";
            this.btnPsup.Size = new System.Drawing.Size(118, 38);
            this.btnPsup.TabIndex = 49;
            this.btnPsup.Text = "  Supprimer";
            this.btnPsup.UseVisualStyleBackColor = false;
            // 
            // btnPmod
            // 
            this.btnPmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnPmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPmod.FlatAppearance.BorderSize = 0;
            this.btnPmod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnPmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPmod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPmod.ForeColor = System.Drawing.Color.White;
            this.btnPmod.Location = new System.Drawing.Point(126, 7);
            this.btnPmod.Name = "btnPmod";
            this.btnPmod.Size = new System.Drawing.Size(118, 38);
            this.btnPmod.TabIndex = 48;
            this.btnPmod.Text = "  Modifier";
            this.btnPmod.UseVisualStyleBackColor = false;
            // 
            // btnPadd
            // 
            this.btnPadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnPadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPadd.FlatAppearance.BorderSize = 0;
            this.btnPadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btnPadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPadd.ForeColor = System.Drawing.Color.White;
            this.btnPadd.Location = new System.Drawing.Point(0, 7);
            this.btnPadd.Name = "btnPadd";
            this.btnPadd.Size = new System.Drawing.Size(118, 38);
            this.btnPadd.TabIndex = 47;
            this.btnPadd.Text = "  Ajouter";
            this.btnPadd.UseVisualStyleBackColor = false;
            this.btnPadd.Click += new System.EventHandler(this.btnPadd_Click);
            // 
            // pnlProfesseurForm
            // 
            this.pnlProfesseurForm.BackColor = System.Drawing.Color.White;
            this.pnlProfesseurForm.Controls.Add(this.txtPSpecialite);
            this.pnlProfesseurForm.Controls.Add(this.label6);
            this.pnlProfesseurForm.Controls.Add(this.txtPemail);
            this.pnlProfesseurForm.Controls.Add(this.label7);
            this.pnlProfesseurForm.Controls.Add(this.txtPtel);
            this.pnlProfesseurForm.Controls.Add(this.label8);
            this.pnlProfesseurForm.Controls.Add(this.txtPprenom);
            this.pnlProfesseurForm.Controls.Add(this.label9);
            this.pnlProfesseurForm.Controls.Add(this.txtPnom);
            this.pnlProfesseurForm.Controls.Add(this.label10);
            this.pnlProfesseurForm.Location = new System.Drawing.Point(12, 12);
            this.pnlProfesseurForm.Name = "pnlProfesseurForm";
            this.pnlProfesseurForm.Size = new System.Drawing.Size(400, 480);
            this.pnlProfesseurForm.TabIndex = 1;
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.BackColor = System.Drawing.Color.White;
            this.txtPSpecialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPSpecialite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPSpecialite.Location = new System.Drawing.Point(24, 322);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(352, 34);
            this.txtPSpecialite.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(24, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Spécialité";
            // 
            // txtPemail
            // 
            this.txtPemail.BackColor = System.Drawing.Color.White;
            this.txtPemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPemail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPemail.Location = new System.Drawing.Point(24, 252);
            this.txtPemail.Name = "txtPemail";
            this.txtPemail.Size = new System.Drawing.Size(352, 34);
            this.txtPemail.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(24, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Email";
            // 
            // txtPtel
            // 
            this.txtPtel.BackColor = System.Drawing.Color.White;
            this.txtPtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPtel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPtel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPtel.Location = new System.Drawing.Point(24, 182);
            this.txtPtel.Name = "txtPtel";
            this.txtPtel.Size = new System.Drawing.Size(352, 34);
            this.txtPtel.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(24, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "Téléphone";
            // 
            // txtPprenom
            // 
            this.txtPprenom.BackColor = System.Drawing.Color.White;
            this.txtPprenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPprenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPprenom.Location = new System.Drawing.Point(24, 112);
            this.txtPprenom.Name = "txtPprenom";
            this.txtPprenom.Size = new System.Drawing.Size(352, 34);
            this.txtPprenom.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(24, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Prénom";
            // 
            // txtPnom
            // 
            this.txtPnom.BackColor = System.Drawing.Color.White;
            this.txtPnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPnom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPnom.Location = new System.Drawing.Point(24, 42);
            this.txtPnom.Name = "txtPnom";
            this.txtPnom.Size = new System.Drawing.Size(352, 34);
            this.txtPnom.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(24, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 64;
            this.label10.Text = "Nom";
            // 
            // tabChefDepatrement
            // 
            this.tabChefDepatrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabChefDepatrement.Controls.Add(this.pnlChefButtons);
            this.tabChefDepatrement.Controls.Add(this.pnlChefForm);
            this.tabChefDepatrement.Location = new System.Drawing.Point(4, 34);
            this.tabChefDepatrement.Name = "tabChefDepatrement";
            this.tabChefDepatrement.Size = new System.Drawing.Size(422, 550);
            this.tabChefDepatrement.TabIndex = 2;
            this.tabChefDepatrement.Text = "  Chef Département  ";
            // 
            // pnlChefButtons
            // 
            this.pnlChefButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlChefButtons.Controls.Add(this.btnCsup);
            this.pnlChefButtons.Controls.Add(this.btnCmod);
            this.pnlChefButtons.Controls.Add(this.btnCadd);
            this.pnlChefButtons.Location = new System.Drawing.Point(12, 500);
            this.pnlChefButtons.Name = "pnlChefButtons";
            this.pnlChefButtons.Size = new System.Drawing.Size(400, 52);
            this.pnlChefButtons.TabIndex = 0;
            // 
            // btnCsup
            // 
            this.btnCsup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCsup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCsup.FlatAppearance.BorderSize = 0;
            this.btnCsup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCsup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCsup.ForeColor = System.Drawing.Color.White;
            this.btnCsup.Location = new System.Drawing.Point(252, 7);
            this.btnCsup.Name = "btnCsup";
            this.btnCsup.Size = new System.Drawing.Size(118, 38);
            this.btnCsup.TabIndex = 49;
            this.btnCsup.Text = "  Supprimer";
            this.btnCsup.UseVisualStyleBackColor = false;
            this.btnCsup.Click += new System.EventHandler(this.btnCsup_Click);
            // 
            // btnCmod
            // 
            this.btnCmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnCmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCmod.FlatAppearance.BorderSize = 0;
            this.btnCmod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnCmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCmod.ForeColor = System.Drawing.Color.White;
            this.btnCmod.Location = new System.Drawing.Point(126, 7);
            this.btnCmod.Name = "btnCmod";
            this.btnCmod.Size = new System.Drawing.Size(118, 38);
            this.btnCmod.TabIndex = 48;
            this.btnCmod.Text = "  Modifier";
            this.btnCmod.UseVisualStyleBackColor = false;
            this.btnCmod.Click += new System.EventHandler(this.btnCmod_Click);
            // 
            // btnCadd
            // 
            this.btnCadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnCadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadd.FlatAppearance.BorderSize = 0;
            this.btnCadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btnCadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadd.ForeColor = System.Drawing.Color.White;
            this.btnCadd.Location = new System.Drawing.Point(0, 7);
            this.btnCadd.Name = "btnCadd";
            this.btnCadd.Size = new System.Drawing.Size(118, 38);
            this.btnCadd.TabIndex = 47;
            this.btnCadd.Text = "  Ajouter";
            this.btnCadd.UseVisualStyleBackColor = false;
            this.btnCadd.Click += new System.EventHandler(this.btnCadd_Click);
            // 
            // pnlChefForm
            // 
            this.pnlChefForm.BackColor = System.Drawing.Color.White;
            this.pnlChefForm.Controls.Add(this.txtDepartement);
            this.pnlChefForm.Controls.Add(this.label11);
            this.pnlChefForm.Controls.Add(this.txtCemail);
            this.pnlChefForm.Controls.Add(this.label12);
            this.pnlChefForm.Controls.Add(this.txtCtel);
            this.pnlChefForm.Controls.Add(this.label13);
            this.pnlChefForm.Controls.Add(this.txtCprenom);
            this.pnlChefForm.Controls.Add(this.label14);
            this.pnlChefForm.Controls.Add(this.txtCnom);
            this.pnlChefForm.Controls.Add(this.label15);
            this.pnlChefForm.Location = new System.Drawing.Point(12, 12);
            this.pnlChefForm.Name = "pnlChefForm";
            this.pnlChefForm.Size = new System.Drawing.Size(400, 480);
            this.pnlChefForm.TabIndex = 1;
            // 
            // txtDepartement
            // 
            this.txtDepartement.BackColor = System.Drawing.Color.White;
            this.txtDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtDepartement.Location = new System.Drawing.Point(24, 322);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(352, 34);
            this.txtDepartement.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label11.Location = new System.Drawing.Point(24, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 60;
            this.label11.Text = "Département";
            // 
            // txtCemail
            // 
            this.txtCemail.BackColor = System.Drawing.Color.White;
            this.txtCemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCemail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCemail.Location = new System.Drawing.Point(24, 252);
            this.txtCemail.Name = "txtCemail";
            this.txtCemail.Size = new System.Drawing.Size(352, 34);
            this.txtCemail.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label12.Location = new System.Drawing.Point(24, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 61;
            this.label12.Text = "Email";
            // 
            // txtCtel
            // 
            this.txtCtel.BackColor = System.Drawing.Color.White;
            this.txtCtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCtel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCtel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCtel.Location = new System.Drawing.Point(24, 182);
            this.txtCtel.Name = "txtCtel";
            this.txtCtel.Size = new System.Drawing.Size(352, 34);
            this.txtCtel.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label13.Location = new System.Drawing.Point(24, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 62;
            this.label13.Text = "Téléphone";
            // 
            // txtCprenom
            // 
            this.txtCprenom.BackColor = System.Drawing.Color.White;
            this.txtCprenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCprenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCprenom.Location = new System.Drawing.Point(24, 112);
            this.txtCprenom.Name = "txtCprenom";
            this.txtCprenom.Size = new System.Drawing.Size(352, 34);
            this.txtCprenom.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(24, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 25);
            this.label14.TabIndex = 63;
            this.label14.Text = "Prénom";
            // 
            // txtCnom
            // 
            this.txtCnom.BackColor = System.Drawing.Color.White;
            this.txtCnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCnom.Location = new System.Drawing.Point(24, 42);
            this.txtCnom.Name = "txtCnom";
            this.txtCnom.Size = new System.Drawing.Size(352, 34);
            this.txtCnom.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label15.Location = new System.Drawing.Point(24, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 25);
            this.label15.TabIndex = 64;
            this.label15.Text = "Nom";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlRight.Controls.Add(this.dgUtilisateur);
            this.pnlRight.Controls.Add(this.lblGridTitle);
            this.pnlRight.Location = new System.Drawing.Point(462, 88);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(532, 600);
            this.pnlRight.TabIndex = 2;
            // 
            // dgUtilisateur
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgUtilisateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUtilisateur.BackgroundColor = System.Drawing.Color.White;
            this.dgUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUtilisateur.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUtilisateur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUtilisateur.EnableHeadersVisualStyles = false;
            this.dgUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgUtilisateur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgUtilisateur.Location = new System.Drawing.Point(0, 36);
            this.dgUtilisateur.Name = "dgUtilisateur";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUtilisateur.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgUtilisateur.RowHeadersWidth = 40;
            this.dgUtilisateur.RowTemplate.Height = 32;
            this.dgUtilisateur.Size = new System.Drawing.Size(532, 558);
            this.dgUtilisateur.TabIndex = 0;
            this.dgUtilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUtilisateur_CellClick);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGridTitle.Location = new System.Drawing.Point(0, 4);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(224, 30);
            this.lblGridTitle.TabIndex = 1;
            this.lblGridTitle.Text = "Liste des utilisateurs";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1010, 72);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(26, 46);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(462, 25);
            this.lblFormSubtitle.TabIndex = 0;
            this.lblFormSubtitle.Text = "Gérez les candidats, professeurs et chefs de département";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(24, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(371, 45);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Gestion des Utilisateurs";
            // 
            // formUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 706);
            this.ControlBox = false;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "formUtilisateur";
            this.Text = "Gestion Des Utilisateurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formUtilisateur_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.pnlCandidatButtons.ResumeLayout(false);
            this.pnlCandidatForm.ResumeLayout(false);
            this.pnlCandidatForm.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.pnlProfesseurButtons.ResumeLayout(false);
            this.pnlProfesseurForm.ResumeLayout(false);
            this.pnlProfesseurForm.PerformLayout();
            this.tabChefDepatrement.ResumeLayout(false);
            this.pnlChefButtons.ResumeLayout(false);
            this.pnlChefForm.ResumeLayout(false);
            this.pnlChefForm.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepatrement;
        private System.Windows.Forms.Panel pnlCandidatForm;
        private System.Windows.Forms.Panel pnlCandidatButtons;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label16;
        private System.Windows.Forms.TextBox txtNom, txtPrenom, txtTel, txtEmail, txtMatricule;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnRemove;
        private System.Windows.Forms.Panel pnlProfesseurForm;
        private System.Windows.Forms.Panel pnlProfesseurButtons;
        private System.Windows.Forms.Label label6, label7, label8, label9, label10;
        private System.Windows.Forms.TextBox txtPnom, txtPprenom, txtPtel, txtPemail, txtPSpecialite;
        private System.Windows.Forms.Button btnPadd, btnPmod, btnPsup, btnPSelect;
        private System.Windows.Forms.Panel pnlChefForm;
        private System.Windows.Forms.Panel pnlChefButtons;
        private System.Windows.Forms.Label label11, label12, label13, label14, label15;
        private System.Windows.Forms.TextBox txtCnom, txtCprenom, txtCtel, txtCemail, txtDepartement;
        private System.Windows.Forms.Button btnCadd, btnCmod, btnCsup;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
    }
}