using System.Windows.Forms;

namespace appSlam
{
    partial class UsersAffiche
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
            this.btRetour = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.annoncesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(37, 22);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(94, 29);
            this.btRetour.TabIndex = 0;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(67, 83);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(81, 20);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Users label";
            // 
            // annoncesLabel
            // 
            this.annoncesLabel.AutoSize = true;
            this.annoncesLabel.Location = new System.Drawing.Point(459, 83);
            this.annoncesLabel.Name = "annoncesLabel";
            this.annoncesLabel.Size = new System.Drawing.Size(73, 20);
            this.annoncesLabel.TabIndex = 2;
            this.annoncesLabel.Text = "Annonces";
            // 
            // UsersAffiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.annoncesLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.btRetour);
            this.Name = "UsersAffiche";
            this.Text = "UsersAffiche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btRetour;
        private Label usersLabel;
        private Label annoncesLabel;
    }
}