
namespace JardimaMesa
{
    partial class frmConsCliente
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
            this.btnConsCliVoltar = new System.Windows.Forms.Button();
            this.btnCliConsultar = new System.Windows.Forms.Button();
            this.ltbConsClientes = new System.Windows.Forms.ListBox();
            this.imgLogoClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoClientes)).BeginInit();
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
            // btnConsCliVoltar
            // 
            this.btnConsCliVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsCliVoltar.Location = new System.Drawing.Point(550, 310);
            this.btnConsCliVoltar.Name = "btnConsCliVoltar";
            this.btnConsCliVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnConsCliVoltar.TabIndex = 13;
            this.btnConsCliVoltar.Text = "VOLTAR";
            this.btnConsCliVoltar.UseVisualStyleBackColor = true;
            this.btnConsCliVoltar.Click += new System.EventHandler(this.btnConsCliVoltar_Click);
            // 
            // btnCliConsultar
            // 
            this.btnCliConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliConsultar.Location = new System.Drawing.Point(390, 310);
            this.btnCliConsultar.Name = "btnCliConsultar";
            this.btnCliConsultar.Size = new System.Drawing.Size(120, 50);
            this.btnCliConsultar.TabIndex = 12;
            this.btnCliConsultar.Text = "CONSULTAR CLIENTES";
            this.btnCliConsultar.UseVisualStyleBackColor = true;
            this.btnCliConsultar.Click += new System.EventHandler(this.btnCliConsultar_Click);
            // 
            // ltbConsClientes
            // 
            this.ltbConsClientes.FormattingEnabled = true;
            this.ltbConsClientes.Location = new System.Drawing.Point(310, 30);
            this.ltbConsClientes.Name = "ltbConsClientes";
            this.ltbConsClientes.Size = new System.Drawing.Size(440, 251);
            this.ltbConsClientes.TabIndex = 38;
            // 
            // imgLogoClientes
            // 
            this.imgLogoClientes.Image = global::JardimaMesa.Properties.Resources.logo_escuro1;
            this.imgLogoClientes.Location = new System.Drawing.Point(30, 30);
            this.imgLogoClientes.Name = "imgLogoClientes";
            this.imgLogoClientes.Size = new System.Drawing.Size(250, 250);
            this.imgLogoClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoClientes.TabIndex = 37;
            this.imgLogoClientes.TabStop = false;
            // 
            // frmConsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.ltbConsClientes);
            this.Controls.Add(this.imgLogoClientes);
            this.Controls.Add(this.btnConsCliVoltar);
            this.Controls.Add(this.btnCliConsultar);
            this.Controls.Add(this.lblLusty);
            this.Name = "frmConsCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLusty;
        private System.Windows.Forms.Button btnConsCliVoltar;
        private System.Windows.Forms.Button btnCliConsultar;
        private System.Windows.Forms.ListBox ltbConsClientes;
        private System.Windows.Forms.PictureBox imgLogoClientes;
    }
}