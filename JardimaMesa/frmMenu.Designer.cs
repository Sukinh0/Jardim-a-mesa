
namespace JardimaMesa
{
    partial class frmMenu
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
            this.lblMenuClientes = new System.Windows.Forms.Label();
            this.lblMenuServicos = new System.Windows.Forms.Label();
            this.lblMenuReservas = new System.Windows.Forms.Label();
            this.btnMCadCli = new System.Windows.Forms.Button();
            this.btnMConsCli = new System.Windows.Forms.Button();
            this.btnMCadRes = new System.Windows.Forms.Button();
            this.btnMConsRes = new System.Windows.Forms.Button();
            this.btnMCadServ = new System.Windows.Forms.Button();
            this.btnMConsServ = new System.Windows.Forms.Button();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARCLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARCLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAZERRESERVASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARRESERVASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARSERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARSERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMenuLogo = new System.Windows.Forms.PictureBox();
            this.lblLusty = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuClientes
            // 
            this.lblMenuClientes.AutoSize = true;
            this.lblMenuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuClientes.Location = new System.Drawing.Point(337, 99);
            this.lblMenuClientes.Name = "lblMenuClientes";
            this.lblMenuClientes.Size = new System.Drawing.Size(85, 16);
            this.lblMenuClientes.TabIndex = 0;
            this.lblMenuClientes.Text = "CLIENTES:";
            // 
            // lblMenuServicos
            // 
            this.lblMenuServicos.AutoSize = true;
            this.lblMenuServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuServicos.Location = new System.Drawing.Point(334, 299);
            this.lblMenuServicos.Name = "lblMenuServicos";
            this.lblMenuServicos.Size = new System.Drawing.Size(88, 16);
            this.lblMenuServicos.TabIndex = 1;
            this.lblMenuServicos.Text = "SERVIÇOS:";
            // 
            // lblMenuReservas
            // 
            this.lblMenuReservas.AutoSize = true;
            this.lblMenuReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuReservas.Location = new System.Drawing.Point(328, 199);
            this.lblMenuReservas.Name = "lblMenuReservas";
            this.lblMenuReservas.Size = new System.Drawing.Size(94, 16);
            this.lblMenuReservas.TabIndex = 2;
            this.lblMenuReservas.Text = "RESERVAS:";
            // 
            // btnMCadCli
            // 
            this.btnMCadCli.BackColor = System.Drawing.SystemColors.Control;
            this.btnMCadCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCadCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMCadCli.Location = new System.Drawing.Point(427, 82);
            this.btnMCadCli.Name = "btnMCadCli";
            this.btnMCadCli.Size = new System.Drawing.Size(120, 50);
            this.btnMCadCli.TabIndex = 3;
            this.btnMCadCli.Text = "CADASTRAR CLIENTES";
            this.btnMCadCli.UseVisualStyleBackColor = false;
            this.btnMCadCli.Click += new System.EventHandler(this.btnMCadCli_Click);
            // 
            // btnMConsCli
            // 
            this.btnMConsCli.BackColor = System.Drawing.SystemColors.Control;
            this.btnMConsCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMConsCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMConsCli.Location = new System.Drawing.Point(588, 82);
            this.btnMConsCli.Name = "btnMConsCli";
            this.btnMConsCli.Size = new System.Drawing.Size(120, 50);
            this.btnMConsCli.TabIndex = 4;
            this.btnMConsCli.Text = "CONSULTAR CLIENTES";
            this.btnMConsCli.UseVisualStyleBackColor = false;
            this.btnMConsCli.Click += new System.EventHandler(this.btnMConsCli_Click);
            // 
            // btnMCadRes
            // 
            this.btnMCadRes.BackColor = System.Drawing.SystemColors.Control;
            this.btnMCadRes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMCadRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCadRes.Location = new System.Drawing.Point(427, 182);
            this.btnMCadRes.Name = "btnMCadRes";
            this.btnMCadRes.Size = new System.Drawing.Size(120, 50);
            this.btnMCadRes.TabIndex = 5;
            this.btnMCadRes.Text = "FAZER RESERVAS";
            this.btnMCadRes.UseVisualStyleBackColor = false;
            this.btnMCadRes.Click += new System.EventHandler(this.btnMCadRes_Click);
            // 
            // btnMConsRes
            // 
            this.btnMConsRes.BackColor = System.Drawing.SystemColors.Control;
            this.btnMConsRes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMConsRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMConsRes.Location = new System.Drawing.Point(588, 182);
            this.btnMConsRes.Name = "btnMConsRes";
            this.btnMConsRes.Size = new System.Drawing.Size(120, 50);
            this.btnMConsRes.TabIndex = 6;
            this.btnMConsRes.Text = "CONSULTAR RESERVAS";
            this.btnMConsRes.UseVisualStyleBackColor = false;
            this.btnMConsRes.Click += new System.EventHandler(this.btnMConsRes_Click);
            // 
            // btnMCadServ
            // 
            this.btnMCadServ.BackColor = System.Drawing.SystemColors.Control;
            this.btnMCadServ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMCadServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCadServ.Location = new System.Drawing.Point(427, 282);
            this.btnMCadServ.Name = "btnMCadServ";
            this.btnMCadServ.Size = new System.Drawing.Size(120, 50);
            this.btnMCadServ.TabIndex = 7;
            this.btnMCadServ.Text = "ADICIONAR EXPERIÊNCIA";
            this.btnMCadServ.UseVisualStyleBackColor = false;
            this.btnMCadServ.Click += new System.EventHandler(this.btnMCadServ_Click);
            // 
            // btnMConsServ
            // 
            this.btnMConsServ.BackColor = System.Drawing.SystemColors.Control;
            this.btnMConsServ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMConsServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMConsServ.Location = new System.Drawing.Point(588, 282);
            this.btnMConsServ.Name = "btnMConsServ";
            this.btnMConsServ.Size = new System.Drawing.Size(120, 50);
            this.btnMConsServ.TabIndex = 8;
            this.btnMConsServ.Text = "CONSULTAR EXPERIÊNCIA";
            this.btnMConsServ.UseVisualStyleBackColor = false;
            this.btnMConsServ.Click += new System.EventHandler(this.btnMConsServ_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.rESERVASToolStripMenuItem,
            this.sERVIÇOSToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(784, 24);
            this.mnsMenu.TabIndex = 9;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARCLIENTESToolStripMenuItem,
            this.cONSULTARCLIENTESToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // cADASTRARCLIENTESToolStripMenuItem
            // 
            this.cADASTRARCLIENTESToolStripMenuItem.Name = "cADASTRARCLIENTESToolStripMenuItem";
            this.cADASTRARCLIENTESToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cADASTRARCLIENTESToolStripMenuItem.Text = "CADASTRAR CLIENTES";
            this.cADASTRARCLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARCLIENTESToolStripMenuItem_Click);
            // 
            // cONSULTARCLIENTESToolStripMenuItem
            // 
            this.cONSULTARCLIENTESToolStripMenuItem.Name = "cONSULTARCLIENTESToolStripMenuItem";
            this.cONSULTARCLIENTESToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cONSULTARCLIENTESToolStripMenuItem.Text = "CONSULTAR CLIENTES";
            this.cONSULTARCLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARCLIENTESToolStripMenuItem_Click);
            // 
            // rESERVASToolStripMenuItem
            // 
            this.rESERVASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAZERRESERVASToolStripMenuItem,
            this.cONSULTARRESERVASToolStripMenuItem});
            this.rESERVASToolStripMenuItem.Name = "rESERVASToolStripMenuItem";
            this.rESERVASToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.rESERVASToolStripMenuItem.Text = "RESERVAS";
            // 
            // fAZERRESERVASToolStripMenuItem
            // 
            this.fAZERRESERVASToolStripMenuItem.Name = "fAZERRESERVASToolStripMenuItem";
            this.fAZERRESERVASToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.fAZERRESERVASToolStripMenuItem.Text = "FAZER RESERVAS";
            this.fAZERRESERVASToolStripMenuItem.Click += new System.EventHandler(this.fAZERRESERVASToolStripMenuItem_Click);
            // 
            // cONSULTARRESERVASToolStripMenuItem
            // 
            this.cONSULTARRESERVASToolStripMenuItem.Name = "cONSULTARRESERVASToolStripMenuItem";
            this.cONSULTARRESERVASToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cONSULTARRESERVASToolStripMenuItem.Text = "CONSULTAR RESERVAS";
            this.cONSULTARRESERVASToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARRESERVASToolStripMenuItem_Click);
            // 
            // sERVIÇOSToolStripMenuItem
            // 
            this.sERVIÇOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARSERVIÇOSToolStripMenuItem,
            this.cONSULTARSERVIÇOSToolStripMenuItem});
            this.sERVIÇOSToolStripMenuItem.Name = "sERVIÇOSToolStripMenuItem";
            this.sERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sERVIÇOSToolStripMenuItem.Text = "SERVIÇOS";
            // 
            // cADASTRARSERVIÇOSToolStripMenuItem
            // 
            this.cADASTRARSERVIÇOSToolStripMenuItem.Name = "cADASTRARSERVIÇOSToolStripMenuItem";
            this.cADASTRARSERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cADASTRARSERVIÇOSToolStripMenuItem.Text = "CADASTRAR SERVIÇOS";
            this.cADASTRARSERVIÇOSToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARSERVIÇOSToolStripMenuItem_Click);
            // 
            // cONSULTARSERVIÇOSToolStripMenuItem
            // 
            this.cONSULTARSERVIÇOSToolStripMenuItem.Name = "cONSULTARSERVIÇOSToolStripMenuItem";
            this.cONSULTARSERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cONSULTARSERVIÇOSToolStripMenuItem.Text = "CONSULTAR SERVIÇOS";
            this.cONSULTARSERVIÇOSToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARSERVIÇOSToolStripMenuItem_Click);
            // 
            // imgMenuLogo
            // 
            this.imgMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.imgMenuLogo.Image = global::JardimaMesa.Properties.Resources.logo_escuro;
            this.imgMenuLogo.Location = new System.Drawing.Point(62, 82);
            this.imgMenuLogo.Name = "imgMenuLogo";
            this.imgMenuLogo.Size = new System.Drawing.Size(250, 250);
            this.imgMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMenuLogo.TabIndex = 10;
            this.imgMenuLogo.TabStop = false;
            // 
            // lblLusty
            // 
            this.lblLusty.AutoSize = true;
            this.lblLusty.BackColor = System.Drawing.Color.Transparent;
            this.lblLusty.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLusty.Location = new System.Drawing.Point(723, 400);
            this.lblLusty.Name = "lblLusty";
            this.lblLusty.Size = new System.Drawing.Size(59, 9);
            this.lblLusty.TabIndex = 11;
            this.lblLusty.Text = "LUSTYCODE©";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(724, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 20);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblLusty);
            this.Controls.Add(this.imgMenuLogo);
            this.Controls.Add(this.btnMConsServ);
            this.Controls.Add(this.btnMCadServ);
            this.Controls.Add(this.btnMConsRes);
            this.Controls.Add(this.btnMCadRes);
            this.Controls.Add(this.btnMConsCli);
            this.Controls.Add(this.btnMCadCli);
            this.Controls.Add(this.lblMenuReservas);
            this.Controls.Add(this.lblMenuServicos);
            this.Controls.Add(this.lblMenuClientes);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuClientes;
        private System.Windows.Forms.Label lblMenuServicos;
        private System.Windows.Forms.Label lblMenuReservas;
        private System.Windows.Forms.Button btnMCadCli;
        private System.Windows.Forms.Button btnMConsCli;
        private System.Windows.Forms.Button btnMCadRes;
        private System.Windows.Forms.Button btnMConsRes;
        private System.Windows.Forms.Button btnMCadServ;
        private System.Windows.Forms.Button btnMConsServ;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARCLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARCLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESERVASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAZERRESERVASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARRESERVASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARSERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARSERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgMenuLogo;
        private System.Windows.Forms.Label lblLusty;
        private System.Windows.Forms.Button btnSair;
    }
}