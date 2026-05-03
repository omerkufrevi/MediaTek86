namespace MediaTek86.vue
{
    /// <summary>
    /// Interface permettant d'ajouter un personnel.
    /// </summary>
    partial class vueAjout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbboxService = new System.Windows.Forms.ComboBox();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.txtboxTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPrenom = new System.Windows.Forms.TextBox();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbboxService);
            this.groupBox1.Controls.Add(this.txtboxMail);
            this.groupBox1.Controls.Add(this.txtboxTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxPrenom);
            this.groupBox1.Controls.Add(this.txtboxNom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les informations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Service";
            // 
            // cmbboxService
            // 
            this.cmbboxService.FormattingEnabled = true;
            this.cmbboxService.Location = new System.Drawing.Point(127, 177);
            this.cmbboxService.Name = "cmbboxService";
            this.cmbboxService.Size = new System.Drawing.Size(196, 28);
            this.cmbboxService.TabIndex = 8;
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(253, 112);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(157, 26);
            this.txtboxMail.TabIndex = 7;
            // 
            // txtboxTel
            // 
            this.txtboxTel.Location = new System.Drawing.Point(42, 112);
            this.txtboxTel.Name = "txtboxTel";
            this.txtboxTel.Size = new System.Drawing.Size(157, 26);
            this.txtboxTel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(253, 54);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(157, 26);
            this.txtboxPrenom.TabIndex = 1;
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(42, 54);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(157, 26);
            this.txtboxNom.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(54, 256);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(167, 43);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(255, 256);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(167, 43);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // vueAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 331);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.groupBox1);
            this.Name = "vueAjout";
            this.Text = "Ajouter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.TextBox txtboxTel;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbboxService;
    }
}