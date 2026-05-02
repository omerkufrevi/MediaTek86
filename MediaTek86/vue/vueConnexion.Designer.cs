namespace MediaTek86.vue
{
    /// <summary>
    /// Interface permettant à l'utilisateur de se connecter à l'application.
    /// </summary>
    partial class vueConnexion
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
            this.grpboxConnexion = new System.Windows.Forms.GroupBox();
            this.txtboxPwd = new System.Windows.Forms.TextBox();
            this.txtboxLogin = new System.Windows.Forms.RichTextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.grpboxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxConnexion
            // 
            this.grpboxConnexion.Controls.Add(this.txtboxPwd);
            this.grpboxConnexion.Controls.Add(this.txtboxLogin);
            this.grpboxConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxConnexion.Location = new System.Drawing.Point(75, 52);
            this.grpboxConnexion.Name = "grpboxConnexion";
            this.grpboxConnexion.Size = new System.Drawing.Size(303, 181);
            this.grpboxConnexion.TabIndex = 1;
            this.grpboxConnexion.TabStop = false;
            this.grpboxConnexion.Text = "Connexion";
            // 
            // txtboxPwd
            // 
            this.txtboxPwd.Location = new System.Drawing.Point(35, 100);
            this.txtboxPwd.Name = "txtboxPwd";
            this.txtboxPwd.PasswordChar = '*';
            this.txtboxPwd.Size = new System.Drawing.Size(227, 26);
            this.txtboxPwd.TabIndex = 1;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(35, 42);
            this.txtboxLogin.Multiline = false;
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(227, 30);
            this.txtboxLogin.TabIndex = 0;
            this.txtboxLogin.Text = "";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(110, 267);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(227, 64);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // vueConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 387);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.grpboxConnexion);
            this.Name = "vueConnexion";
            this.Text = "vueConnexion";
            this.grpboxConnexion.ResumeLayout(false);
            this.grpboxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxConnexion;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.RichTextBox txtboxLogin;
        private System.Windows.Forms.TextBox txtboxPwd;
    }
}