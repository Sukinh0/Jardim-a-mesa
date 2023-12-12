
namespace JardimaMesa
{
    partial class frmCadServico
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
            this.btnServVoltar = new System.Windows.Forms.Button();
            this.btnServCadastrar = new System.Windows.Forms.Button();
            this.imgLogoCadExp = new System.Windows.Forms.PictureBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbExp = new System.Windows.Forms.TextBox();
            this.lblCadValor = new System.Windows.Forms.Label();
            this.lblCadDesc = new System.Windows.Forms.Label();
            this.lblCadExp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoCadExp)).BeginInit();
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
            // btnServVoltar
            // 
            this.btnServVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServVoltar.Location = new System.Drawing.Point(550, 275);
            this.btnServVoltar.Name = "btnServVoltar";
            this.btnServVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnServVoltar.TabIndex = 13;
            this.btnServVoltar.Text = "VOLTAR";
            this.btnServVoltar.UseVisualStyleBackColor = true;
            this.btnServVoltar.Click += new System.EventHandler(this.btnServVoltar_Click);
            // 
            // btnServCadastrar
            // 
            this.btnServCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServCadastrar.Location = new System.Drawing.Point(390, 275);
            this.btnServCadastrar.Name = "btnServCadastrar";
            this.btnServCadastrar.Size = new System.Drawing.Size(120, 50);
            this.btnServCadastrar.TabIndex = 12;
            this.btnServCadastrar.Text = "CADASTRAR EXPERIÊNCIA";
            this.btnServCadastrar.UseVisualStyleBackColor = true;
            this.btnServCadastrar.Click += new System.EventHandler(this.btnServCadastrar_Click);
            // 
            // imgLogoCadExp
            // 
            this.imgLogoCadExp.Image = global::JardimaMesa.Properties.Resources.logo_escuro1;
            this.imgLogoCadExp.Location = new System.Drawing.Point(30, 75);
            this.imgLogoCadExp.Name = "imgLogoCadExp";
            this.imgLogoCadExp.Size = new System.Drawing.Size(250, 250);
            this.imgLogoCadExp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoCadExp.TabIndex = 35;
            this.imgLogoCadExp.TabStop = false;
            // 
            // txbValor
            // 
            this.txbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.Location = new System.Drawing.Point(430, 115);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(300, 21);
            this.txbValor.TabIndex = 32;
            // 
            // txbDesc
            // 
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(430, 155);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(300, 100);
            this.txbDesc.TabIndex = 31;
            // 
            // txbExp
            // 
            this.txbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExp.Location = new System.Drawing.Point(430, 75);
            this.txbExp.Name = "txbExp";
            this.txbExp.Size = new System.Drawing.Size(300, 21);
            this.txbExp.TabIndex = 30;
            // 
            // lblCadValor
            // 
            this.lblCadValor.AutoSize = true;
            this.lblCadValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadValor.Location = new System.Drawing.Point(353, 118);
            this.lblCadValor.Name = "lblCadValor";
            this.lblCadValor.Size = new System.Drawing.Size(62, 16);
            this.lblCadValor.TabIndex = 27;
            this.lblCadValor.Text = "VALOR:";
            // 
            // lblCadDesc
            // 
            this.lblCadDesc.AutoSize = true;
            this.lblCadDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDesc.Location = new System.Drawing.Point(316, 158);
            this.lblCadDesc.Name = "lblCadDesc";
            this.lblCadDesc.Size = new System.Drawing.Size(99, 16);
            this.lblCadDesc.TabIndex = 26;
            this.lblCadDesc.Text = "DESCRIÇÃO:";
            // 
            // lblCadExp
            // 
            this.lblCadExp.AutoSize = true;
            this.lblCadExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadExp.Location = new System.Drawing.Point(304, 78);
            this.lblCadExp.Name = "lblCadExp";
            this.lblCadExp.Size = new System.Drawing.Size(111, 16);
            this.lblCadExp.TabIndex = 25;
            this.lblCadExp.Text = "EXPERIÊNCIA:";
            // 
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.imgLogoCadExp);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbExp);
            this.Controls.Add(this.lblCadValor);
            this.Controls.Add(this.lblCadDesc);
            this.Controls.Add(this.lblCadExp);
            this.Controls.Add(this.btnServVoltar);
            this.Controls.Add(this.btnServCadastrar);
            this.Controls.Add(this.lblLusty);
            this.Name = "frmCadServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR EXPERIÊNCIAS";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoCadExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLusty;
        private System.Windows.Forms.Button btnServVoltar;
        private System.Windows.Forms.Button btnServCadastrar;
        private System.Windows.Forms.PictureBox imgLogoCadExp;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbExp;
        private System.Windows.Forms.Label lblCadValor;
        private System.Windows.Forms.Label lblCadDesc;
        private System.Windows.Forms.Label lblCadExp;
    }
}