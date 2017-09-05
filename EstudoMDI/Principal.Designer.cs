namespace EstudoMDI
{
    partial class Principal
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.op1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirMenuStripCel = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMenuStripCel = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaMenuStripCel = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarMenuStripCel = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // op1ToolStripMenuItem
            // 
            this.op1ToolStripMenuItem.Name = "op1ToolStripMenuItem";
            this.op1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirMenuStrip,
            this.alterarMenuStrip,
            this.buscaMenuStrip,
            this.deletarMenuStrip,
            this.sairDaAplicaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(115, 311);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirMenuStrip
            // 
            this.inserirMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirMenuStripCel});
            this.inserirMenuStrip.Name = "inserirMenuStrip";
            this.inserirMenuStrip.Size = new System.Drawing.Size(102, 19);
            this.inserirMenuStrip.Text = "Inserir";
            // 
            // inserirMenuStripCel
            // 
            this.inserirMenuStripCel.Name = "inserirMenuStripCel";
            this.inserirMenuStripCel.Size = new System.Drawing.Size(152, 22);
            this.inserirMenuStripCel.Text = "Inserir Usuario";
            this.inserirMenuStripCel.Click += new System.EventHandler(this.inserirMenuStripCel_Click);
            // 
            // alterarMenuStrip
            // 
            this.alterarMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarMenuStripCel});
            this.alterarMenuStrip.Name = "alterarMenuStrip";
            this.alterarMenuStrip.Size = new System.Drawing.Size(102, 19);
            this.alterarMenuStrip.Text = "Alterar";
            // 
            // alterarMenuStripCel
            // 
            this.alterarMenuStripCel.Name = "alterarMenuStripCel";
            this.alterarMenuStripCel.Size = new System.Drawing.Size(152, 22);
            this.alterarMenuStripCel.Text = "Alterar Usuario";
            this.alterarMenuStripCel.Click += new System.EventHandler(this.alterarMenuStripCel_Click);
            // 
            // buscaMenuStrip
            // 
            this.buscaMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaMenuStripCel});
            this.buscaMenuStrip.Name = "buscaMenuStrip";
            this.buscaMenuStrip.Size = new System.Drawing.Size(102, 19);
            this.buscaMenuStrip.Text = "Buscar";
            // 
            // buscaMenuStripCel
            // 
            this.buscaMenuStripCel.Name = "buscaMenuStripCel";
            this.buscaMenuStripCel.Size = new System.Drawing.Size(152, 22);
            this.buscaMenuStripCel.Text = "Buscar Usuario";
            this.buscaMenuStripCel.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // deletarMenuStrip
            // 
            this.deletarMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarMenuStripCel});
            this.deletarMenuStrip.Name = "deletarMenuStrip";
            this.deletarMenuStrip.Size = new System.Drawing.Size(102, 19);
            this.deletarMenuStrip.Text = "Deletar";
            // 
            // deletarMenuStripCel
            // 
            this.deletarMenuStripCel.Name = "deletarMenuStripCel";
            this.deletarMenuStripCel.Size = new System.Drawing.Size(154, 22);
            this.deletarMenuStripCel.Text = "Deletar Usuario";
            this.deletarMenuStripCel.Click += new System.EventHandler(this.deletarMenuStripCel_Click);
            // 
            // sairDaAplicaçãoToolStripMenuItem
            // 
            this.sairDaAplicaçãoToolStripMenuItem.Name = "sairDaAplicaçãoToolStripMenuItem";
            this.sairDaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(102, 19);
            this.sairDaAplicaçãoToolStripMenuItem.Text = "Sair da Aplicação";
            this.sairDaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.sairDaAplicaçãoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem op1ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inserirMenuStripCel;
        private System.Windows.Forms.ToolStripMenuItem alterarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem alterarMenuStripCel;
        private System.Windows.Forms.ToolStripMenuItem buscaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem buscaMenuStripCel;
        private System.Windows.Forms.ToolStripMenuItem deletarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deletarMenuStripCel;
        private System.Windows.Forms.ToolStripMenuItem sairDaAplicaçãoToolStripMenuItem;
    }
}

