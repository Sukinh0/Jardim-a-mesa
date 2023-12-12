
namespace JardimaMesa
{
    partial class frmConsServico
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
            this.lblLusty = new System.Windows.Forms.Label();
            this.btnConsServVoltar = new System.Windows.Forms.Button();
            this.btnServConsultar = new System.Windows.Forms.Button();
            this.imgLogoexp = new System.Windows.Forms.PictureBox();
            this.ltbConsServico = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoexp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLusty
            // 
            this.lblLusty.AutoSize = true;
            this.lblLusty.BackColor = System.Drawing.Color.Transparent;
            this.lblLusty.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLusty.Location = new System.Drawing.Point(723, 400);
            this.lblLusty.Name = "lblLusty";
            this.lblLusty.Size = new System.Drawing.Size(59, 9);
            this.lblLusty.TabIndex = 3;
            this.lblLusty.Text = "LUSTYCODE©";
            // 
            // btnConsServVoltar
            // 
            this.btnConsServVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsServVoltar.Location = new System.Drawing.Point(550, 310);
            this.btnConsServVoltar.Name = "btnConsServVoltar";
            this.btnConsServVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnConsServVoltar.TabIndex = 13;
            this.btnConsServVoltar.Text = "VOLTAR";
            this.btnConsServVoltar.UseVisualStyleBackColor = true;
            this.btnConsServVoltar.Click += new System.EventHandler(this.btnConsServVoltar_Click);
            // 
            // btnServConsultar
            // 
            this.btnServConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServConsultar.Location = new System.Drawing.Point(390, 310);
            this.btnServConsultar.Name = "btnServConsultar";
            this.btnServConsultar.Size = new System.Drawing.Size(120, 50);
            this.btnServConsultar.TabIndex = 12;
            this.btnServConsultar.Text = "CONSULTAR EXPERIÊNCIA";
            this.btnServConsultar.UseVisualStyleBackColor = true;
            this.btnServConsultar.Click += new System.EventHandler(this.btnServConsultar_Click);
            // 
            // imgLogoexp
            // 
            this.imgLogoexp.Image = global::JardimaMesa.Properties.Resources.logo_escuro1;
            this.imgLogoexp.Location = new System.Drawing.Point(30, 30);
            this.imgLogoexp.Name = "imgLogoexp";
            this.imgLogoexp.Size = new System.Drawing.Size(250, 250);
            this.imgLogoexp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoexp.TabIndex = 35;
            this.imgLogoexp.TabStop = false;
            // 
            // ltbConsServico
            // 
            this.ltbConsServico.FormattingEnabled = true;
            this.ltbConsServico.Location = new System.Drawing.Point(310, 30);
            this.ltbConsServico.Name = "ltbConsServico";
            this.ltbConsServico.Size = new System.Drawing.Size(440, 251);
            this.ltbConsServico.TabIndex = 36;
            // 
            // frmConsServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.ltbConsServico);
            this.Controls.Add(this.imgLogoexp);
            this.Controls.Add(this.btnConsServVoltar);
            this.Controls.Add(this.btnServConsultar);
            this.Controls.Add(this.lblLusty);
            this.Name = "frmConsServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR EXPERIÊNCIAS";
            this.Load += new System.EventHandler(this.frmConsServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoexp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLusty;
        private System.Windows.Forms.Button btnConsServVoltar;
        private System.Windows.Forms.Button btnServConsultar;
        private System.Windows.Forms.PictureBox imgLogoexp;
        private System.Windows.Forms.ListBox ltbConsServico;
    }
}