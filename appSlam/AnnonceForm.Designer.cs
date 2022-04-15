namespace appSlam
{
    partial class AnnonceForm
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
            this.annonceLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.designation = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.prix = new System.Windows.Forms.ColumnHeader();
            this.nom = new System.Windows.Forms.ColumnHeader();
            this.annoncetext = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annonceLabel
            // 
            this.annonceLabel.AutoSize = true;
            this.annonceLabel.Location = new System.Drawing.Point(106, 63);
            this.annonceLabel.Name = "annonceLabel";
            this.annonceLabel.Size = new System.Drawing.Size(0, 15);
            this.annonceLabel.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.designation,
            this.description,
            this.prix,
            this.nom});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 278);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 40;
            // 
            // designation
            // 
            this.designation.Text = "designation";
            this.designation.Width = 120;
            // 
            // description
            // 
            this.description.Text = "description";
            this.description.Width = 240;
            // 
            // prix
            // 
            this.prix.Text = "prix";
            // 
            // nom
            // 
            this.nom.Text = "nom";
            this.nom.Width = 120;
            // 
            // annoncetext
            // 
            this.annoncetext.AutoSize = true;
            this.annoncetext.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annoncetext.ForeColor = System.Drawing.Color.Red;
            this.annoncetext.Location = new System.Drawing.Point(12, 302);
            this.annoncetext.Name = "annoncetext";
            this.annoncetext.Size = new System.Drawing.Size(110, 23);
            this.annoncetext.TabIndex = 2;
            this.annoncetext.Text = "annoncetext";
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(655, 12);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 3;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(655, 358);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 20;
            this.buttonAnnuler.Text = "Retour";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // AnnonceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.annoncetext);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.annonceLabel);
            this.Name = "AnnonceForm";
            this.Text = "AnnonceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label annonceLabel;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader designation;
        private ColumnHeader description;
        private ColumnHeader prix;
        private ColumnHeader nom;
        private Label annoncetext;
        private Button Modifier;
        private Button buttonAnnuler;
    }
}