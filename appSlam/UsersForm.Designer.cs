namespace appSlam
{
    partial class UsersForm
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
            this.usersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idUtilisateurInput = new System.Windows.Forms.TextBox();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.labelResultatAction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(63, 70);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(119, 20);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Utilisateurs label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Effectuer une action";
            // 
            // idUtilisateurInput
            // 
            this.idUtilisateurInput.Location = new System.Drawing.Point(871, 215);
            this.idUtilisateurInput.Name = "idUtilisateurInput";
            this.idUtilisateurInput.PlaceholderText = "Id de l\'utilisateur";
            this.idUtilisateurInput.Size = new System.Drawing.Size(141, 27);
            this.idUtilisateurInput.TabIndex = 2;
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Afficher",
            "Modifier",
            "Supprimer"});
            this.comboBoxAction.Location = new System.Drawing.Point(871, 261);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(141, 28);
            this.comboBoxAction.TabIndex = 3;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(871, 316);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(141, 29);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // labelResultatAction
            // 
            this.labelResultatAction.AutoSize = true;
            this.labelResultatAction.Location = new System.Drawing.Point(871, 375);
            this.labelResultatAction.Name = "labelResultatAction";
            this.labelResultatAction.Size = new System.Drawing.Size(0, 20);
            this.labelResultatAction.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Deconnexion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResultatAction);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.idUtilisateurInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersLabel);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usersLabel;
        private Label label1;
        private TextBox idUtilisateurInput;
        private ComboBox comboBoxAction;
        private Button btOK;
        private Label labelResultatAction;
        private Button button1;
        private Button button2;
    }
}