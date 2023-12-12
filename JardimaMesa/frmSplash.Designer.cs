
namespace JardimaMesa
{
    partial class frmSplash
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
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.imgSplashLogo = new System.Windows.Forms.PictureBox();
            this.lblLusty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSplashLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.pgbSplash.Location = new System.Drawing.Point(0, 267);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(289, 45);
            this.pgbSplash.TabIndex = 1;
            this.pgbSplash.Click += new System.EventHandler(this.pgbSplash_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // imgSplashLogo
            // 
            this.imgSplashLogo.Image = global::JardimaMesa.Properties.Resources.logo_claro;
            this.imgSplashLogo.Location = new System.Drawing.Point(0, 0);
            this.imgSplashLogo.Name = "imgSplashLogo";
            this.imgSplashLogo.Size = new System.Drawing.Size(289, 267);
            this.imgSplashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSplashLogo.TabIndex = 0;
            this.imgSplashLogo.TabStop = false;
            this.imgSplashLogo.Click += new System.EventHandler(this.imgSplashLogo_Click);
            // 
            // lblLusty
            // 
            this.lblLusty.AutoSize = true;
            this.lblLusty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(123)))));
            this.lblLusty.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLusty.Location = new System.Drawing.Point(225, 257);
            this.lblLusty.Name = "lblLusty";
            this.lblLusty.Size = new System.Drawing.Size(59, 9);
            this.lblLusty.TabIndex = 2;
            this.lblLusty.Text = "LUSTYCODE©";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lblLusty);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.imgSplashLogo);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JARDIM Á MESA";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSplashLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSplashLogo;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblLusty;
    }
}

