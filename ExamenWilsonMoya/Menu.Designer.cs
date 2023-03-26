namespace ExamenWilsonMoya
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reparacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamarTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reparacionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reparacionToolStripMenuItem1
            // 
            this.reparacionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reclamarTicketToolStripMenuItem});
            this.reparacionToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reparacionToolStripMenuItem1.Image = global::ExamenWilsonMoya.Properties.Resources.herramienta_de_reparacion;
            this.reparacionToolStripMenuItem1.Name = "reparacionToolStripMenuItem1";
            this.reparacionToolStripMenuItem1.Size = new System.Drawing.Size(154, 20);
            this.reparacionToolStripMenuItem1.Text = "Servicio de Reparacion";
            // 
            // reclamarTicketToolStripMenuItem
            // 
            this.reclamarTicketToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reclamarTicketToolStripMenuItem.Image = global::ExamenWilsonMoya.Properties.Resources.boleto__1_;
            this.reclamarTicketToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reclamarTicketToolStripMenuItem.Name = "reclamarTicketToolStripMenuItem";
            this.reclamarTicketToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.reclamarTicketToolStripMenuItem.Text = "Solicitar Ticket";
            this.reclamarTicketToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.reclamarTicketToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.reclamarTicketToolStripMenuItem.Click += new System.EventHandler(this.reclamarTicketToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 487);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reparacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reclamarTicketToolStripMenuItem;
    }
}