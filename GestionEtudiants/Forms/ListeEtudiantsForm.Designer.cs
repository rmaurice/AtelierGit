namespace GestionEtudiants.Forms
{
    partial class ListeEtudiantsForm
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
            this.lstEtudiants = new System.Windows.Forms.ListBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEtudiants
            // 
            this.lstEtudiants.FormattingEnabled = true;
            this.lstEtudiants.Location = new System.Drawing.Point(12, 12);
            this.lstEtudiants.Name = "lstEtudiants";
            this.lstEtudiants.Size = new System.Drawing.Size(311, 212);
            this.lstEtudiants.TabIndex = 0;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnRafraichir);
            this.gbActions.Controls.Add(this.btnSupprimer);
            this.gbActions.Controls.Add(this.btnModifier);
            this.gbActions.Controls.Add(this.btnAjouter);
            this.gbActions.Location = new System.Drawing.Point(355, 22);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(176, 186);
            this.gbActions.TabIndex = 2;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(6, 157);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(164, 23);
            this.btnRafraichir.TabIndex = 6;
            this.btnRafraichir.Text = "Rafraîchir la liste";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(6, 77);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(164, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer l\'étudiant sélectionné";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(6, 48);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(164, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier l\'étudiant sélectionné";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 19);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(164, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter un nouvel étudiant";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // ListeEtudiantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 243);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.lstEtudiants);
            this.Name = "ListeEtudiantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des étudiants";
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEtudiants;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
    }
}

