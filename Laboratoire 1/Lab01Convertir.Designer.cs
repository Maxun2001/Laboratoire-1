namespace Laboratoire_1
{
    partial class FrmConvertir
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gr01 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConDecimal = new System.Windows.Forms.TextBox();
            this.txtConHexadecimal = new System.Windows.Forms.TextBox();
            this.txtConBinaire = new System.Windows.Forms.TextBox();
            this.btnSortie = new System.Windows.Forms.Button();
            this.Gr02 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValeurAConvertir = new System.Windows.Forms.TextBox();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnHexadécimal = new System.Windows.Forms.Button();
            this.Gr01.SuspendLayout();
            this.Gr02.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSIONS DE VALEURS NON SIGNÉES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binaire";
            // 
            // Gr01
            // 
            this.Gr01.BackColor = System.Drawing.Color.DarkSalmon;
            this.Gr01.Controls.Add(this.label4);
            this.Gr01.Controls.Add(this.label3);
            this.Gr01.Controls.Add(this.txtConDecimal);
            this.Gr01.Controls.Add(this.txtConHexadecimal);
            this.Gr01.Controls.Add(this.txtConBinaire);
            this.Gr01.Controls.Add(this.btnSortie);
            this.Gr01.Controls.Add(this.Gr02);
            this.Gr01.Controls.Add(this.label1);
            this.Gr01.Controls.Add(this.label2);
            this.Gr01.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gr01.ForeColor = System.Drawing.Color.Black;
            this.Gr01.Location = new System.Drawing.Point(12, 12);
            this.Gr01.Name = "Gr01";
            this.Gr01.Size = new System.Drawing.Size(758, 426);
            this.Gr01.TabIndex = 2;
            this.Gr01.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Décimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hexadécimal";
            // 
            // txtConDecimal
            // 
            this.txtConDecimal.Location = new System.Drawing.Point(493, 137);
            this.txtConDecimal.Name = "txtConDecimal";
            this.txtConDecimal.Size = new System.Drawing.Size(100, 21);
            this.txtConDecimal.TabIndex = 9;
            // 
            // txtConHexadecimal
            // 
            this.txtConHexadecimal.Location = new System.Drawing.Point(301, 137);
            this.txtConHexadecimal.Name = "txtConHexadecimal";
            this.txtConHexadecimal.Size = new System.Drawing.Size(100, 21);
            this.txtConHexadecimal.TabIndex = 8;
            // 
            // txtConBinaire
            // 
            this.txtConBinaire.Location = new System.Drawing.Point(119, 137);
            this.txtConBinaire.Name = "txtConBinaire";
            this.txtConBinaire.Size = new System.Drawing.Size(100, 21);
            this.txtConBinaire.TabIndex = 7;
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(645, 352);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(75, 23);
            this.btnSortie.TabIndex = 6;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.button4_Click);
            // 
            // Gr02
            // 
            this.Gr02.Controls.Add(this.label5);
            this.Gr02.Controls.Add(this.txtValeurAConvertir);
            this.Gr02.Controls.Add(this.btnBinaire);
            this.Gr02.Controls.Add(this.btnDecimal);
            this.Gr02.Controls.Add(this.btnHexadécimal);
            this.Gr02.Location = new System.Drawing.Point(54, 221);
            this.Gr02.Name = "Gr02";
            this.Gr02.Size = new System.Drawing.Size(539, 199);
            this.Gr02.TabIndex = 2;
            this.Gr02.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valeur à Convertir";
            // 
            // txtValeurAConvertir
            // 
            this.txtValeurAConvertir.Location = new System.Drawing.Point(129, 72);
            this.txtValeurAConvertir.Name = "txtValeurAConvertir";
            this.txtValeurAConvertir.Size = new System.Drawing.Size(254, 21);
            this.txtValeurAConvertir.TabIndex = 10;
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(401, 131);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(75, 23);
            this.btnBinaire.TabIndex = 5;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(35, 131);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = "Décimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnHexadécimal
            // 
            this.btnHexadécimal.Location = new System.Drawing.Point(203, 131);
            this.btnHexadécimal.Name = "btnHexadécimal";
            this.btnHexadécimal.Size = new System.Drawing.Size(112, 23);
            this.btnHexadécimal.TabIndex = 4;
            this.btnHexadécimal.Text = "Hexadécimal";
            this.btnHexadécimal.UseVisualStyleBackColor = true;
            this.btnHexadécimal.Click += new System.EventHandler(this.btnHexadécimal_Click);
            // 
            // FrmConvertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 440);
            this.Controls.Add(this.Gr01);
            this.Name = "FrmConvertir";
            this.Text = "Programme Conversion";
            this.Gr01.ResumeLayout(false);
            this.Gr01.PerformLayout();
            this.Gr02.ResumeLayout(false);
            this.Gr02.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gr01;
        private System.Windows.Forms.Button btnSortie;
        private System.Windows.Forms.GroupBox Gr02;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnHexadécimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConDecimal;
        private System.Windows.Forms.TextBox txtConHexadecimal;
        private System.Windows.Forms.TextBox txtConBinaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValeurAConvertir;
    }
}

