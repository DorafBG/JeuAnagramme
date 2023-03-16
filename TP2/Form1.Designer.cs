namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeviner = new System.Windows.Forms.Label();
            this.lblMOT = new System.Windows.Forms.Label();
            this.gbxProposition = new System.Windows.Forms.GroupBox();
            this.txtbxPropo = new System.Windows.Forms.TextBox();
            this.btnTester = new System.Windows.Forms.Button();
            this.gbxEssais = new System.Windows.Forms.GroupBox();
            this.lblEssaisPrecedents = new System.Windows.Forms.Label();
            this.lblEssaisRestants = new System.Windows.Forms.Label();
            this.lbxEssais = new System.Windows.Forms.ListBox();
            this.lblEssais = new System.Windows.Forms.Label();
            this.lblNbRestants = new System.Windows.Forms.Label();
            this.gbxHistorique = new System.Windows.Forms.GroupBox();
            this.lbxHistorique = new System.Windows.Forms.ListBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxProposition.SuspendLayout();
            this.gbxEssais.SuspendLayout();
            this.gbxHistorique.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviner
            // 
            this.lblDeviner.AutoSize = true;
            this.lblDeviner.Location = new System.Drawing.Point(12, 9);
            this.lblDeviner.Name = "lblDeviner";
            this.lblDeviner.Size = new System.Drawing.Size(86, 15);
            this.lblDeviner.TabIndex = 0;
            this.lblDeviner.Text = "Mot à deviner :";
            // 
            // lblMOT
            // 
            this.lblMOT.AutoSize = true;
            this.lblMOT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMOT.Location = new System.Drawing.Point(12, 24);
            this.lblMOT.Name = "lblMOT";
            this.lblMOT.Size = new System.Drawing.Size(78, 37);
            this.lblMOT.TabIndex = 1;
            this.lblMOT.Text = "MOT";
            // 
            // gbxProposition
            // 
            this.gbxProposition.Controls.Add(this.txtbxPropo);
            this.gbxProposition.Controls.Add(this.btnTester);
            this.gbxProposition.Location = new System.Drawing.Point(12, 72);
            this.gbxProposition.Name = "gbxProposition";
            this.gbxProposition.Size = new System.Drawing.Size(393, 84);
            this.gbxProposition.TabIndex = 2;
            this.gbxProposition.TabStop = false;
            this.gbxProposition.Text = "Proposition";
            // 
            // txtbxPropo
            // 
            this.txtbxPropo.Location = new System.Drawing.Point(17, 34);
            this.txtbxPropo.Name = "txtbxPropo";
            this.txtbxPropo.Size = new System.Drawing.Size(244, 23);
            this.txtbxPropo.TabIndex = 1;
            // 
            // btnTester
            // 
            this.btnTester.Location = new System.Drawing.Point(278, 22);
            this.btnTester.Name = "btnTester";
            this.btnTester.Size = new System.Drawing.Size(95, 48);
            this.btnTester.TabIndex = 0;
            this.btnTester.Text = "Tester";
            this.btnTester.UseVisualStyleBackColor = true;
            this.btnTester.Click += new System.EventHandler(this.btnTester_Click);
            // 
            // gbxEssais
            // 
            this.gbxEssais.Controls.Add(this.lblEssaisPrecedents);
            this.gbxEssais.Controls.Add(this.lblEssaisRestants);
            this.gbxEssais.Controls.Add(this.lbxEssais);
            this.gbxEssais.Controls.Add(this.lblEssais);
            this.gbxEssais.Controls.Add(this.lblNbRestants);
            this.gbxEssais.Location = new System.Drawing.Point(12, 175);
            this.gbxEssais.Name = "gbxEssais";
            this.gbxEssais.Size = new System.Drawing.Size(393, 222);
            this.gbxEssais.TabIndex = 3;
            this.gbxEssais.TabStop = false;
            this.gbxEssais.Text = "Essais";
            // 
            // lblEssaisPrecedents
            // 
            this.lblEssaisPrecedents.AutoSize = true;
            this.lblEssaisPrecedents.Location = new System.Drawing.Point(119, 65);
            this.lblEssaisPrecedents.Name = "lblEssaisPrecedents";
            this.lblEssaisPrecedents.Size = new System.Drawing.Size(13, 15);
            this.lblEssaisPrecedents.TabIndex = 4;
            this.lblEssaisPrecedents.Text = "0";
            // 
            // lblEssaisRestants
            // 
            this.lblEssaisRestants.AutoSize = true;
            this.lblEssaisRestants.Location = new System.Drawing.Point(158, 35);
            this.lblEssaisRestants.Name = "lblEssaisRestants";
            this.lblEssaisRestants.Size = new System.Drawing.Size(13, 15);
            this.lblEssaisRestants.TabIndex = 3;
            this.lblEssaisRestants.Text = "0";
            // 
            // lbxEssais
            // 
            this.lbxEssais.FormattingEnabled = true;
            this.lbxEssais.ItemHeight = 15;
            this.lbxEssais.Location = new System.Drawing.Point(17, 93);
            this.lbxEssais.Name = "lbxEssais";
            this.lbxEssais.Size = new System.Drawing.Size(356, 109);
            this.lbxEssais.TabIndex = 2;
            // 
            // lblEssais
            // 
            this.lblEssais.AutoSize = true;
            this.lblEssais.Location = new System.Drawing.Point(14, 64);
            this.lblEssais.Name = "lblEssais";
            this.lblEssais.Size = new System.Drawing.Size(104, 15);
            this.lblEssais.TabIndex = 1;
            this.lblEssais.Text = "Essais précédents :";
            // 
            // lblNbRestants
            // 
            this.lblNbRestants.AutoSize = true;
            this.lblNbRestants.Location = new System.Drawing.Point(14, 34);
            this.lblNbRestants.Name = "lblNbRestants";
            this.lblNbRestants.Size = new System.Drawing.Size(147, 15);
            this.lblNbRestants.TabIndex = 0;
            this.lblNbRestants.Text = "Nombre d\'essais restants : ";
            // 
            // gbxHistorique
            // 
            this.gbxHistorique.Controls.Add(this.lbxHistorique);
            this.gbxHistorique.Location = new System.Drawing.Point(433, 72);
            this.gbxHistorique.Name = "gbxHistorique";
            this.gbxHistorique.Size = new System.Drawing.Size(339, 164);
            this.gbxHistorique.TabIndex = 4;
            this.gbxHistorique.TabStop = false;
            this.gbxHistorique.Text = "Historique";
            // 
            // lbxHistorique
            // 
            this.lbxHistorique.FormattingEnabled = true;
            this.lbxHistorique.ItemHeight = 15;
            this.lbxHistorique.Location = new System.Drawing.Point(15, 22);
            this.lbxHistorique.Name = "lbxHistorique";
            this.lbxHistorique.Size = new System.Drawing.Size(308, 124);
            this.lbxHistorique.TabIndex = 0;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(464, 315);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(105, 48);
            this.btnRejouer.TabIndex = 5;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(620, 315);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 48);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.gbxHistorique);
            this.Controls.Add(this.gbxEssais);
            this.Controls.Add(this.gbxProposition);
            this.Controls.Add(this.lblMOT);
            this.Controls.Add(this.lblDeviner);
            this.Name = "Form1";
            this.Text = "Anagramme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProposition.ResumeLayout(false);
            this.gbxProposition.PerformLayout();
            this.gbxEssais.ResumeLayout(false);
            this.gbxEssais.PerformLayout();
            this.gbxHistorique.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDeviner;
        private Label lblMOT;
        private GroupBox gbxProposition;
        private TextBox txtbxPropo;
        private Button btnTester;
        private GroupBox gbxEssais;
        private ListBox lbxEssais;
        private Label lblEssais;
        private Label lblNbRestants;
        private GroupBox gbxHistorique;
        private ListBox lbxHistorique;
        private Button btnRejouer;
        private Button btnQuitter;
        private Label lblEssaisPrecedents;
        private Label lblEssaisRestants;
    }
}