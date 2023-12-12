
namespace JardimaMesa
{
    partial class frmConsReserva
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
            this.btnConsResVoltar = new System.Windows.Forms.Button();
            this.btnResConsultar = new System.Windows.Forms.Button();
            this.ltbConsReservas = new System.Windows.Forms.ListBox();
            this.imgLogoReserva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoReserva)).BeginInit();
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
            // btnConsResVoltar
            // 
            this.btnConsResVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsResVoltar.Location = new System.Drawing.Point(550, 310);
            this.btnConsResVoltar.Name = "btnConsResVoltar";
            this.btnConsResVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnConsResVoltar.TabIndex = 13;
            this.btnConsResVoltar.Text = "VOLTAR";
            this.btnConsResVoltar.UseVisualStyleBackColor = true;
            this.btnConsResVoltar.Click += new System.EventHandler(this.btnConsResVoltar_Click);
            // 
            // btnResConsultar
            // 
            this.btnResConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResConsultar.Location = new System.Drawing.Point(390, 310);
            this.btnResConsultar.Name = "btnResConsultar";
            this.btnResConsultar.Size = new System.Drawing.Size(120, 50);
            this.btnResConsultar.TabIndex = 12;
            this.btnResConsultar.Text = "CONSULTAR RESERVAS";
            this.btnResConsultar.UseVisualStyleBackColor = true;
            this.btnResConsultar.Click += new System.EventHandler(this.btnResConsultar_Click);
            // 
            // ltbConsReservas
            // 
            this.ltbConsReservas.FormattingEnabled = true;
            this.ltbConsReservas.Location = new System.Drawing.Point(310, 30);
            this.ltbConsReservas.Name = "ltbConsReservas";
            this.ltbConsReservas.Size = new System.Drawing.Size(440, 251);
            this.ltbConsReservas.TabIndex = 38;
            // 
            // imgLogoReserva
            // 
            this.imgLogoReserva.Image = global::JardimaMesa.Properties.Resources.logo_escuro1;
            this.imgLogoReserva.Location = new System.Drawing.Point(30, 30);
            this.imgLogoReserva.Name = "imgLogoReserva";
            this.imgLogoReserva.Size = new System.Drawing.Size(250, 250);
            this.imgLogoReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoReserva.TabIndex = 37;
            this.imgLogoReserva.TabStop = false;
            // 
            // frmConsReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.ltbConsReservas);
            this.Controls.Add(this.imgLogoReserva);
            this.Controls.Add(this.btnConsResVoltar);
            this.Controls.Add(this.btnResConsultar);
            this.Controls.Add(this.lblLusty);
            this.Name = "frmConsReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR RESERVAS";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLusty;
        private System.Windows.Forms.Button btnConsResVoltar;
        private System.Windows.Forms.Button btnResConsultar;
        private System.Windows.Forms.ListBox ltbConsReservas;
        private System.Windows.Forms.PictureBox imgLogoReserva;
    }
}