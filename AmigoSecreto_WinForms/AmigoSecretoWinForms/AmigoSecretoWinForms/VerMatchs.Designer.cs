namespace AmigoSecretoWinForms
{
    partial class VerMatchs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMatchs));
            this.listViewMatchsDeNomes = new System.Windows.Forms.ListView();
            this.ColumnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderTirou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelQuemTirouQuem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewMatchsDeNomes
            // 
            this.listViewMatchsDeNomes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNome,
            this.ColumnHeaderTirou});
            this.listViewMatchsDeNomes.HideSelection = false;
            this.listViewMatchsDeNomes.Location = new System.Drawing.Point(40, 100);
            this.listViewMatchsDeNomes.Name = "listViewMatchsDeNomes";
            this.listViewMatchsDeNomes.Size = new System.Drawing.Size(443, 372);
            this.listViewMatchsDeNomes.TabIndex = 0;
            this.listViewMatchsDeNomes.UseCompatibleStateImageBehavior = false;
            this.listViewMatchsDeNomes.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderNome
            // 
            this.ColumnHeaderNome.Text = "Esta pessoa";
            this.ColumnHeaderNome.Width = 196;
            // 
            // ColumnHeaderTirou
            // 
            this.ColumnHeaderTirou.Text = "Tirou";
            this.ColumnHeaderTirou.Width = 338;
            // 
            // labelQuemTirouQuem
            // 
            this.labelQuemTirouQuem.AutoSize = true;
            this.labelQuemTirouQuem.BackColor = System.Drawing.Color.Transparent;
            this.labelQuemTirouQuem.Font = new System.Drawing.Font("Monument Extended Ultrabold", 18F, System.Drawing.FontStyle.Bold);
            this.labelQuemTirouQuem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelQuemTirouQuem.Location = new System.Drawing.Point(64, 48);
            this.labelQuemTirouQuem.Name = "labelQuemTirouQuem";
            this.labelQuemTirouQuem.Size = new System.Drawing.Size(397, 36);
            this.labelQuemTirouQuem.TabIndex = 1;
            this.labelQuemTirouQuem.Text = "Quem tirou quem?";
            // 
            // VerMatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 484);
            this.Controls.Add(this.labelQuemTirouQuem);
            this.Controls.Add(this.listViewMatchsDeNomes);
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.Name = "VerMatchs";
            this.Text = "VerMatchs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMatchsDeNomes;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNome;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTirou;
        private System.Windows.Forms.Label labelQuemTirouQuem;
    }
}