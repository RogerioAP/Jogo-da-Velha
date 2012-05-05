namespace JogodaVelha
{
    partial class frmDificuldade
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoleza = new System.Windows.Forms.Button();
            this.btnSeraquevoceganha = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha um nível";
            // 
            // btnMoleza
            // 
            this.btnMoleza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoleza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoleza.Location = new System.Drawing.Point(76, 78);
            this.btnMoleza.Name = "btnMoleza";
            this.btnMoleza.Size = new System.Drawing.Size(93, 41);
            this.btnMoleza.TabIndex = 4;
            this.btnMoleza.Text = "Moleza";
            this.toolTip1.SetToolTip(this.btnMoleza, "Isso aqui é moleza!");
            this.btnMoleza.UseVisualStyleBackColor = false;
            this.btnMoleza.Click += new System.EventHandler(this.btnMoleza_Click);
            // 
            // btnSeraquevoceganha
            // 
            this.btnSeraquevoceganha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeraquevoceganha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeraquevoceganha.Location = new System.Drawing.Point(175, 78);
            this.btnSeraquevoceganha.Name = "btnSeraquevoceganha";
            this.btnSeraquevoceganha.Size = new System.Drawing.Size(93, 41);
            this.btnSeraquevoceganha.TabIndex = 5;
            this.btnSeraquevoceganha.Text = "Será que você ganha";
            this.toolTip1.SetToolTip(this.btnSeraquevoceganha, "Será que voce é capaz de ganhar?");
            this.btnSeraquevoceganha.UseVisualStyleBackColor = false;
            this.btnSeraquevoceganha.Click += new System.EventHandler(this.btnSeraquevoceganha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(126, 159);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 41);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Isso aqui é moleza!");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmDificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(344, 212);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSeraquevoceganha);
            this.Controls.Add(this.btnMoleza);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dificuldade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoleza;
        private System.Windows.Forms.Button btnSeraquevoceganha;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVoltar;
    }
}