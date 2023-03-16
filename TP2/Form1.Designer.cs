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
            lblDeviner = new Label();
            lblMOT = new Label();
            gbxProposition = new GroupBox();
            txtbxPropo = new TextBox();
            btnTester = new Button();
            gbxEssais = new GroupBox();
            lblEssaisPrecedents = new Label();
            lblEssaisRestants = new Label();
            lbxEssais = new ListBox();
            lblEssais = new Label();
            lblNbRestants = new Label();
            gbxHistorique = new GroupBox();
            lbxHistorique = new ListBox();
            btnRejouer = new Button();
            btnQuitter = new Button();
            vScrollBar1 = new VScrollBar();
            gbxProposition.SuspendLayout();
            gbxEssais.SuspendLayout();
            gbxHistorique.SuspendLayout();
            SuspendLayout();
            // 
            // lblDeviner
            // 
            lblDeviner.AutoSize = true;
            lblDeviner.Location = new Point(12, 9);
            lblDeviner.Name = "lblDeviner";
            lblDeviner.Size = new Size(86, 15);
            lblDeviner.TabIndex = 0;
            lblDeviner.Text = "Mot à deviner :";
            // 
            // lblMOT
            // 
            lblMOT.AutoSize = true;
            lblMOT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMOT.Location = new Point(12, 24);
            lblMOT.Name = "lblMOT";
            lblMOT.Size = new Size(78, 37);
            lblMOT.TabIndex = 1;
            lblMOT.Text = "MOT";
            // 
            // gbxProposition
            // 
            gbxProposition.Controls.Add(txtbxPropo);
            gbxProposition.Controls.Add(btnTester);
            gbxProposition.Location = new Point(12, 72);
            gbxProposition.Name = "gbxProposition";
            gbxProposition.Size = new Size(393, 84);
            gbxProposition.TabIndex = 2;
            gbxProposition.TabStop = false;
            gbxProposition.Text = "Proposition";
            // 
            // txtbxPropo
            // 
            txtbxPropo.Location = new Point(17, 34);
            txtbxPropo.Name = "txtbxPropo";
            txtbxPropo.Size = new Size(244, 23);
            txtbxPropo.TabIndex = 1;
            // 
            // btnTester
            // 
            btnTester.Location = new Point(278, 22);
            btnTester.Name = "btnTester";
            btnTester.Size = new Size(95, 48);
            btnTester.TabIndex = 0;
            btnTester.Text = "Tester";
            btnTester.UseVisualStyleBackColor = true;
            btnTester.Click += btnTester_Click;
            // 
            // gbxEssais
            // 
            gbxEssais.Controls.Add(lblEssaisPrecedents);
            gbxEssais.Controls.Add(lblEssaisRestants);
            gbxEssais.Controls.Add(lbxEssais);
            gbxEssais.Controls.Add(lblEssais);
            gbxEssais.Controls.Add(lblNbRestants);
            gbxEssais.Location = new Point(12, 175);
            gbxEssais.Name = "gbxEssais";
            gbxEssais.Size = new Size(393, 222);
            gbxEssais.TabIndex = 3;
            gbxEssais.TabStop = false;
            gbxEssais.Text = "Essais";
            // 
            // lblEssaisPrecedents
            // 
            lblEssaisPrecedents.AutoSize = true;
            lblEssaisPrecedents.Location = new Point(119, 65);
            lblEssaisPrecedents.Name = "lblEssaisPrecedents";
            lblEssaisPrecedents.Size = new Size(13, 15);
            lblEssaisPrecedents.TabIndex = 4;
            lblEssaisPrecedents.Text = "0";
            // 
            // lblEssaisRestants
            // 
            lblEssaisRestants.AutoSize = true;
            lblEssaisRestants.Location = new Point(158, 35);
            lblEssaisRestants.Name = "lblEssaisRestants";
            lblEssaisRestants.Size = new Size(13, 15);
            lblEssaisRestants.TabIndex = 3;
            lblEssaisRestants.Text = "0";
            // 
            // lbxEssais
            // 
            lbxEssais.FormattingEnabled = true;
            lbxEssais.ItemHeight = 15;
            lbxEssais.Location = new Point(17, 93);
            lbxEssais.Name = "lbxEssais";
            lbxEssais.Size = new Size(356, 109);
            lbxEssais.TabIndex = 2;
            // 
            // lblEssais
            // 
            lblEssais.AutoSize = true;
            lblEssais.Location = new Point(14, 64);
            lblEssais.Name = "lblEssais";
            lblEssais.Size = new Size(104, 15);
            lblEssais.TabIndex = 1;
            lblEssais.Text = "Essais précédents :";
            // 
            // lblNbRestants
            // 
            lblNbRestants.AutoSize = true;
            lblNbRestants.Location = new Point(14, 34);
            lblNbRestants.Name = "lblNbRestants";
            lblNbRestants.Size = new Size(147, 15);
            lblNbRestants.TabIndex = 0;
            lblNbRestants.Text = "Nombre d'essais restants : ";
            // 
            // gbxHistorique
            // 
            gbxHistorique.Controls.Add(lbxHistorique);
            gbxHistorique.Location = new Point(433, 72);
            gbxHistorique.Name = "gbxHistorique";
            gbxHistorique.Size = new Size(339, 164);
            gbxHistorique.TabIndex = 4;
            gbxHistorique.TabStop = false;
            gbxHistorique.Text = "Historique";
            // 
            // lbxHistorique
            // 
            lbxHistorique.FormattingEnabled = true;
            lbxHistorique.ItemHeight = 15;
            lbxHistorique.Location = new Point(15, 22);
            lbxHistorique.Name = "lbxHistorique";
            lbxHistorique.Size = new Size(308, 124);
            lbxHistorique.TabIndex = 0;
            // 
            // btnRejouer
            // 
            btnRejouer.Location = new Point(464, 315);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(105, 48);
            btnRejouer.TabIndex = 5;
            btnRejouer.Text = "Rejouer";
            btnRejouer.UseVisualStyleBackColor = true;
            btnRejouer.Click += btnRejouer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(620, 315);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(105, 48);
            btnQuitter.TabIndex = 6;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(775, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 432);
            vScrollBar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vScrollBar1);
            Controls.Add(btnQuitter);
            Controls.Add(btnRejouer);
            Controls.Add(gbxHistorique);
            Controls.Add(gbxEssais);
            Controls.Add(gbxProposition);
            Controls.Add(lblMOT);
            Controls.Add(lblDeviner);
            Name = "Form1";
            Text = "Anagramme";
            Load += Form1_Load;
            gbxProposition.ResumeLayout(false);
            gbxProposition.PerformLayout();
            gbxEssais.ResumeLayout(false);
            gbxEssais.PerformLayout();
            gbxHistorique.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private VScrollBar vScrollBar1;
    }
}