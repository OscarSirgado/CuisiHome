namespace CuisiHome
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutIngrédientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterIngrédientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutIngrédientToolStripMenuItem,
            this.recetteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutIngrédientToolStripMenuItem
            // 
            this.ajoutIngrédientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterIngrédientToolStripMenuItem});
            this.ajoutIngrédientToolStripMenuItem.Name = "ajoutIngrédientToolStripMenuItem";
            this.ajoutIngrédientToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.ajoutIngrédientToolStripMenuItem.Text = "Ingrédient";
            this.ajoutIngrédientToolStripMenuItem.Click += new System.EventHandler(this.ajoutIngrédientToolStripMenuItem_Click);
            // 
            // ajouterIngrédientToolStripMenuItem
            // 
            this.ajouterIngrédientToolStripMenuItem.Name = "ajouterIngrédientToolStripMenuItem";
            this.ajouterIngrédientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ajouterIngrédientToolStripMenuItem.Text = "Ajouter ou modifier";
            // 
            // recetteToolStripMenuItem
            // 
            this.recetteToolStripMenuItem.Name = "recetteToolStripMenuItem";
            this.recetteToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.recetteToolStripMenuItem.Text = "Recette";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 550);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "CuisiHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajoutIngrédientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterIngrédientToolStripMenuItem;
    }
}