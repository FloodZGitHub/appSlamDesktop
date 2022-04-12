namespace appSlam
{
    partial class UsersModif
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomInput = new System.Windows.Forms.TextBox();
            this.idUtilisateurLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenomInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inscriptionDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equipageInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // nomInput
            // 
            this.nomInput.Location = new System.Drawing.Point(215, 146);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(336, 27);
            this.nomInput.TabIndex = 1;
            // 
            // idUtilisateurLabel
            // 
            this.idUtilisateurLabel.AutoSize = true;
            this.idUtilisateurLabel.Location = new System.Drawing.Point(197, 101);
            this.idUtilisateurLabel.Name = "idUtilisateurLabel";
            this.idUtilisateurLabel.Size = new System.Drawing.Size(0, 20);
            this.idUtilisateurLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "id :";
            // 
            // prenomInput
            // 
            this.prenomInput.Location = new System.Drawing.Point(215, 197);
            this.prenomInput.Name = "prenomInput";
            this.prenomInput.Size = new System.Drawing.Size(336, 27);
            this.prenomInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inscription :";
            // 
            // inscriptionDateLabel
            // 
            this.inscriptionDateLabel.AutoSize = true;
            this.inscriptionDateLabel.Location = new System.Drawing.Point(197, 250);
            this.inscriptionDateLabel.Name = "inscriptionDateLabel";
            this.inscriptionDateLabel.Size = new System.Drawing.Size(0, 20);
            this.inscriptionDateLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom équipage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom :";
            // 
            // equipageInput
            // 
            this.equipageInput.Location = new System.Drawing.Point(215, 299);
            this.equipageInput.Name = "equipageInput";
            this.equipageInput.Size = new System.Drawing.Size(336, 27);
            this.equipageInput.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Poster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsersModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equipageInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inscriptionDateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenomInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idUtilisateurLabel);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.label1);
            this.Name = "UsersModif";
            this.Text = "UsersModif";
            this.Load += new System.EventHandler(this.UsersModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nomInput;
        private Label idUtilisateurLabel;
        private Label label2;
        private TextBox prenomInput;
        private Label label4;
        private Label inscriptionDateLabel;
        private Label label5;
        private Label label3;
        private TextBox equipageInput;
        private Button button1;
        private Button button2;
    }
}