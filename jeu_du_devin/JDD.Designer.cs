namespace jeu_du_devin
{
    partial class FDevin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNbrEssai = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.MessageJeu = new System.Windows.Forms.RichTextBox();
            this.Rad10coups = new System.Windows.Forms.RadioButton();
            this.Rad15coups = new System.Windows.Forms.RadioButton();
            this.Rad20coups = new System.Windows.Forms.RadioButton();
            this.Rad25coups = new System.Windows.Forms.RadioButton();
            this.Rad30coups = new System.Windows.Forms.RadioButton();
            this.labelPropo = new System.Windows.Forms.Label();
            this.EditProposition = new System.Windows.Forms.TextBox();
            this.BoutonNewGame = new System.Windows.Forms.Button();
            this.BoutonQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNbrEssai
            // 
            this.labelNbrEssai.AutoSize = true;
            this.labelNbrEssai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrEssai.Location = new System.Drawing.Point(12, 103);
            this.labelNbrEssai.Name = "labelNbrEssai";
            this.labelNbrEssai.Size = new System.Drawing.Size(166, 24);
            this.labelNbrEssai.TabIndex = 0;
            this.labelNbrEssai.Text = "Nombre d\'essais";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.Location = new System.Drawing.Point(336, 102);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(126, 25);
            this.labelMsg.TabIndex = 1;
            this.labelMsg.Text = "Messages:";
            // 
            // MessageJeu
            // 
            this.MessageJeu.HideSelection = false;
            this.MessageJeu.Location = new System.Drawing.Point(260, 151);
            this.MessageJeu.Name = "MessageJeu";
            this.MessageJeu.Size = new System.Drawing.Size(289, 207);
            this.MessageJeu.TabIndex = 2;
            this.MessageJeu.Text = "";
            // 
            // Rad10coups
            // 
            this.Rad10coups.AutoSize = true;
            this.Rad10coups.Location = new System.Drawing.Point(16, 12);
            this.Rad10coups.Name = "Rad10coups";
            this.Rad10coups.Size = new System.Drawing.Size(72, 17);
            this.Rad10coups.TabIndex = 3;
            this.Rad10coups.TabStop = true;
            this.Rad10coups.Tag = "10";
            this.Rad10coups.Text = "10_essais";
            this.Rad10coups.UseVisualStyleBackColor = true;
            this.Rad10coups.CheckedChanged += new System.EventHandler(this.Rad10coups_CheckedChanged);
            // 
            // Rad15coups
            // 
            this.Rad15coups.AutoSize = true;
            this.Rad15coups.Location = new System.Drawing.Point(16, 49);
            this.Rad15coups.Name = "Rad15coups";
            this.Rad15coups.Size = new System.Drawing.Size(72, 17);
            this.Rad15coups.TabIndex = 4;
            this.Rad15coups.TabStop = true;
            this.Rad15coups.Tag = "15";
            this.Rad15coups.Text = "15_essais";
            this.Rad15coups.UseVisualStyleBackColor = true;
            this.Rad15coups.CheckedChanged += new System.EventHandler(this.Rad10coups_CheckedChanged);
            // 
            // Rad20coups
            // 
            this.Rad20coups.AutoSize = true;
            this.Rad20coups.Location = new System.Drawing.Point(16, 88);
            this.Rad20coups.Name = "Rad20coups";
            this.Rad20coups.Size = new System.Drawing.Size(72, 17);
            this.Rad20coups.TabIndex = 5;
            this.Rad20coups.TabStop = true;
            this.Rad20coups.Tag = "20";
            this.Rad20coups.Text = "20_essais";
            this.Rad20coups.UseVisualStyleBackColor = true;
            this.Rad20coups.CheckedChanged += new System.EventHandler(this.Rad10coups_CheckedChanged);
            // 
            // Rad25coups
            // 
            this.Rad25coups.AutoSize = true;
            this.Rad25coups.Location = new System.Drawing.Point(16, 124);
            this.Rad25coups.Name = "Rad25coups";
            this.Rad25coups.Size = new System.Drawing.Size(72, 17);
            this.Rad25coups.TabIndex = 6;
            this.Rad25coups.TabStop = true;
            this.Rad25coups.Tag = "25";
            this.Rad25coups.Text = "25_essais";
            this.Rad25coups.UseVisualStyleBackColor = true;
            this.Rad25coups.CheckedChanged += new System.EventHandler(this.Rad10coups_CheckedChanged);
            // 
            // Rad30coups
            // 
            this.Rad30coups.AutoSize = true;
            this.Rad30coups.Location = new System.Drawing.Point(16, 164);
            this.Rad30coups.Name = "Rad30coups";
            this.Rad30coups.Size = new System.Drawing.Size(72, 17);
            this.Rad30coups.TabIndex = 7;
            this.Rad30coups.TabStop = true;
            this.Rad30coups.Tag = "30";
            this.Rad30coups.Text = "30_essais";
            this.Rad30coups.UseVisualStyleBackColor = true;
            this.Rad30coups.CheckedChanged += new System.EventHandler(this.Rad10coups_CheckedChanged);
            // 
            // labelPropo
            // 
            this.labelPropo.AutoSize = true;
            this.labelPropo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPropo.Location = new System.Drawing.Point(145, 410);
            this.labelPropo.Name = "labelPropo";
            this.labelPropo.Size = new System.Drawing.Size(170, 24);
            this.labelPropo.TabIndex = 8;
            this.labelPropo.Text = "Votre proposition";
            // 
            // EditProposition
            // 
            this.EditProposition.AcceptsReturn = true;
            this.EditProposition.Location = new System.Drawing.Point(341, 414);
            this.EditProposition.Name = "EditProposition";
            this.EditProposition.Size = new System.Drawing.Size(142, 20);
            this.EditProposition.TabIndex = 9;
            this.EditProposition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditProposition_KeyPress);
            // 
            // BoutonNewGame
            // 
            this.BoutonNewGame.Location = new System.Drawing.Point(321, 469);
            this.BoutonNewGame.Name = "BoutonNewGame";
            this.BoutonNewGame.Size = new System.Drawing.Size(75, 23);
            this.BoutonNewGame.TabIndex = 10;
            this.BoutonNewGame.Text = "Nouveau";
            this.BoutonNewGame.UseVisualStyleBackColor = true;
            this.BoutonNewGame.Click += new System.EventHandler(this.BoutonNewGame_Click);
            // 
            // BoutonQuitter
            // 
            this.BoutonQuitter.Location = new System.Drawing.Point(431, 469);
            this.BoutonQuitter.Name = "BoutonQuitter";
            this.BoutonQuitter.Size = new System.Drawing.Size(75, 23);
            this.BoutonQuitter.TabIndex = 11;
            this.BoutonQuitter.Text = "Quitter";
            this.BoutonQuitter.UseVisualStyleBackColor = true;
            this.BoutonQuitter.Click += new System.EventHandler(this.BoutonQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Rad30coups);
            this.panel1.Controls.Add(this.Rad25coups);
            this.panel1.Controls.Add(this.Rad20coups);
            this.panel1.Controls.Add(this.Rad15coups);
            this.panel1.Controls.Add(this.Rad10coups);
            this.panel1.Location = new System.Drawing.Point(16, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 206);
            this.panel1.TabIndex = 12;
            // 
            // FDevin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BoutonQuitter);
            this.Controls.Add(this.BoutonNewGame);
            this.Controls.Add(this.EditProposition);
            this.Controls.Add(this.labelPropo);
            this.Controls.Add(this.MessageJeu);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.labelNbrEssai);
            this.Name = "FDevin";
            this.Text = "Jeu du devin";
            this.Load += new System.EventHandler(this.FDevin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNbrEssai;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.RichTextBox MessageJeu;
        private System.Windows.Forms.RadioButton Rad10coups;
        private System.Windows.Forms.RadioButton Rad15coups;
        private System.Windows.Forms.RadioButton Rad20coups;
        private System.Windows.Forms.RadioButton Rad25coups;
        private System.Windows.Forms.RadioButton Rad30coups;
        private System.Windows.Forms.Label labelPropo;
        private System.Windows.Forms.TextBox EditProposition;
        private System.Windows.Forms.Button BoutonNewGame;
        private System.Windows.Forms.Button BoutonQuitter;
        private System.Windows.Forms.Panel panel1;
    }
}

