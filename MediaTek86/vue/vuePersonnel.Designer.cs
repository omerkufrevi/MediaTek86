namespace MediaTek86.vue
{
    /// <summary>
    /// Interface permettant d'afficher la liste des personnels, et de les modifier, ajouter ou supprimer.
    /// </summary>
    partial class vuePersonnel
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
            this.components = new System.ComponentModel.Container();
            this.grpboxListPrsnl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ListPrsnl = new System.Windows.Forms.ListBox();
            this.mdlPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpboxListPrsnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdlPersonnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxListPrsnl
            // 
            this.grpboxListPrsnl.Controls.Add(this.ListPrsnl);
            this.grpboxListPrsnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxListPrsnl.Location = new System.Drawing.Point(29, 60);
            this.grpboxListPrsnl.Name = "grpboxListPrsnl";
            this.grpboxListPrsnl.Size = new System.Drawing.Size(361, 399);
            this.grpboxListPrsnl.TabIndex = 1;
            this.grpboxListPrsnl.TabStop = false;
            this.grpboxListPrsnl.Text = "Liste du Personnel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter un personnel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modifier un personnel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 85);
            this.button3.TabIndex = 4;
            this.button3.Text = "Supprimer un personnel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 85);
            this.button4.TabIndex = 5;
            this.button4.Text = "Gérer l\'absence";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListPrsnl
            // 
            this.ListPrsnl.FormattingEnabled = true;
            this.ListPrsnl.HorizontalScrollbar = true;
            this.ListPrsnl.ItemHeight = 20;
            this.ListPrsnl.Location = new System.Drawing.Point(6, 25);
            this.ListPrsnl.Name = "ListPrsnl";
            this.ListPrsnl.Size = new System.Drawing.Size(349, 364);
            this.ListPrsnl.TabIndex = 6;
            // 
            // mdlPersonnelBindingSource
            // 
            this.mdlPersonnelBindingSource.DataSource = typeof(MediaTek86.modele.mdlPersonnel);
            // 
            // vuePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 564);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpboxListPrsnl);
            this.Name = "vuePersonnel";
            this.Text = "Personnel";
            this.grpboxListPrsnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdlPersonnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxListPrsnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource mdlPersonnelBindingSource;
        private System.Windows.Forms.ListBox ListPrsnl;
    }
}