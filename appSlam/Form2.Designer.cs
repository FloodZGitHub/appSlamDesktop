namespace appSlam
{
    partial class Form2
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
            this.btUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUsers
            // 
            this.btUsers.Location = new System.Drawing.Point(295, 257);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(131, 29);
            this.btUsers.TabIndex = 0;
            this.btUsers.Text = "Gérer les users";
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btUsers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btUsers;
        private Button button1;
    }
}