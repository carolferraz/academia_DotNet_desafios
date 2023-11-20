namespace AmigoSecretoWinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCadastradas = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonVerMatchs = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewNomes = new System.Windows.Forms.ListView();
            this.ColumnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCadastradas
            // 
            this.labelCadastradas.AutoSize = true;
            this.labelCadastradas.BackColor = System.Drawing.Color.Transparent;
            this.labelCadastradas.Location = new System.Drawing.Point(280, 256);
            this.labelCadastradas.Name = "labelCadastradas";
            this.labelCadastradas.Size = new System.Drawing.Size(211, 16);
            this.labelCadastradas.TabIndex = 2;
            this.labelCadastradas.Text = "Nome das amizades cadastradas";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCadastrar.BackgroundImage")));
            this.buttonCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCadastrar.Location = new System.Drawing.Point(182, 127);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(83, 76);
            this.buttonCadastrar.TabIndex = 4;
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // buttonMatch
            // 
            this.buttonMatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMatch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMatch.BackgroundImage")));
            this.buttonMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMatch.Location = new System.Drawing.Point(355, 127);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(80, 76);
            this.buttonMatch.TabIndex = 5;
            this.buttonMatch.UseVisualStyleBackColor = false;
            this.buttonMatch.Click += new System.EventHandler(this.ButtonMatch_Click);
            // 
            // buttonVerMatchs
            // 
            this.buttonVerMatchs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVerMatchs.BackgroundImage")));
            this.buttonVerMatchs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVerMatchs.Location = new System.Drawing.Point(507, 127);
            this.buttonVerMatchs.Name = "buttonVerMatchs";
            this.buttonVerMatchs.Size = new System.Drawing.Size(79, 76);
            this.buttonVerMatchs.TabIndex = 6;
            this.buttonVerMatchs.UseVisualStyleBackColor = true;
            this.buttonVerMatchs.Click += new System.EventHandler(this.ButtonVerMatchs_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonApagar.ForeColor = System.Drawing.Color.Snow;
            this.buttonApagar.Location = new System.Drawing.Point(315, 668);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(129, 32);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Apagar Tudo";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dar match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cadastrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monument Extended Ultrabold", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(192, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amizade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monument Extended Ultrabold", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(190, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 50);
            this.label4.TabIndex = 13;
            this.label4.Text = "Secreta";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cadastre e embaralhe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Open Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "suas amizades para";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Open Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "começar a brincadeira";
            // 
            // listViewNomes
            // 
            this.listViewNomes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNome,
            this.ColumnHeaderEmail});
            this.listViewNomes.HideSelection = false;
            this.listViewNomes.Location = new System.Drawing.Point(182, 275);
            this.listViewNomes.Name = "listViewNomes";
            this.listViewNomes.Size = new System.Drawing.Size(405, 378);
            this.listViewNomes.TabIndex = 17;
            this.listViewNomes.UseCompatibleStateImageBehavior = false;
            this.listViewNomes.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderNome
            // 
            this.ColumnHeaderNome.Text = "Nome";
            this.ColumnHeaderNome.Width = 200;
            // 
            // ColumnHeaderEmail
            // 
            this.ColumnHeaderEmail.Text = "Email";
            this.ColumnHeaderEmail.Width = 301;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ver quem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "tirou quem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(357, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "nos nomes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(195, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Amizade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewNomes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonVerMatchs);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelCadastradas);
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCadastradas;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Button buttonVerMatchs;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewNomes;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNome;
        private System.Windows.Forms.ColumnHeader ColumnHeaderEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

