namespace MediaTek86.vue
{
    /// <summary>
    /// Interface permettant d'afficher la liste des absences d'un personnel, modifier, ajouter ou supprimer.
    /// </summary>
    partial class vueAbsence
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpboxListAbsence = new System.Windows.Forms.GroupBox();
            this.ListAbs = new System.Windows.Forms.ListBox();
            this.grpboxListAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(427, 411);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(184, 85);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(427, 275);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(184, 85);
            this.btnSupp.TabIndex = 9;
            this.btnSupp.Text = "Supprimer une absence";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(427, 184);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(184, 85);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier une absence";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(427, 93);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(184, 85);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter une absence";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // grpboxListAbsence
            // 
            this.grpboxListAbsence.Controls.Add(this.ListAbs);
            this.grpboxListAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxListAbsence.Location = new System.Drawing.Point(33, 69);
            this.grpboxListAbsence.Name = "grpboxListAbsence";
            this.grpboxListAbsence.Size = new System.Drawing.Size(361, 399);
            this.grpboxListAbsence.TabIndex = 6;
            this.grpboxListAbsence.TabStop = false;
            this.grpboxListAbsence.Text = "Liste des absences";
            // 
            // ListAbs
            // 
            this.ListAbs.FormattingEnabled = true;
            this.ListAbs.HorizontalScrollbar = true;
            this.ListAbs.ItemHeight = 20;
            this.ListAbs.Location = new System.Drawing.Point(23, 36);
            this.ListAbs.Name = "ListAbs";
            this.ListAbs.Size = new System.Drawing.Size(316, 344);
            this.ListAbs.TabIndex = 0;
            // 
            // vueAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 564);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grpboxListAbsence);
            this.Name = "vueAbsence";
            this.Text = "Absence";
            this.grpboxListAbsence.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grpboxListAbsence;
        private System.Windows.Forms.ListBox ListAbs;
    }
}