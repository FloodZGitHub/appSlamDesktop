namespace appSlam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse mail";
            // 
            // mailInput
            // 
            this.mailInput.Location = new System.Drawing.Point(479, 94);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(125, 27);
            this.mailInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(479, 219);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(125, 27);
            this.passwordInput.TabIndex = 2;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(498, 287);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(94, 29);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connexion";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox mailInput;
        private TextBox passwordInput;
        private Button btConnect;
        private Label label2;
    }
}