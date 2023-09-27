namespace Angencia
{
    partial class Menu
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
            this.Barraherramientas = new System.Windows.Forms.ToolStrip();
            this.LblTaller = new System.Windows.Forms.ToolStripLabel();
            this.BtnTaller = new System.Windows.Forms.ToolStripButton();
            this.LblHerramientas = new System.Windows.Forms.ToolStripLabel();
            this.BtnHerramientas = new System.Windows.Forms.ToolStripButton();
            this.LblAdministrador = new System.Windows.Forms.ToolStripLabel();
            this.BtnAdmin = new System.Windows.Forms.ToolStripButton();
            this.Barraherramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barraherramientas
            // 
            this.Barraherramientas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Barraherramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblTaller,
            this.BtnTaller,
            this.LblHerramientas,
            this.BtnHerramientas,
            this.LblAdministrador,
            this.BtnAdmin});
            this.Barraherramientas.Location = new System.Drawing.Point(0, 0);
            this.Barraherramientas.Name = "Barraherramientas";
            this.Barraherramientas.Size = new System.Drawing.Size(836, 33);
            this.Barraherramientas.TabIndex = 1;
            this.Barraherramientas.Text = "toolStrip1";
            // 
            // LblTaller
            // 
            this.LblTaller.Name = "LblTaller";
            this.LblTaller.Size = new System.Drawing.Size(51, 28);
            this.LblTaller.Text = "Taller";
            this.LblTaller.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // BtnTaller
            // 
            this.BtnTaller.BackColor = System.Drawing.Color.Transparent;
            this.BtnTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnTaller.Image = global::Angencia.Properties.Resources.configuracion;
            this.BtnTaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTaller.Name = "BtnTaller";
            this.BtnTaller.Size = new System.Drawing.Size(34, 28);
            this.BtnTaller.Text = "toolStripButton1";
            // 
            // LblHerramientas
            // 
            this.LblHerramientas.Name = "LblHerramientas";
            this.LblHerramientas.Size = new System.Drawing.Size(117, 28);
            this.LblHerramientas.Text = "Herramientas";
            // 
            // BtnHerramientas
            // 
            this.BtnHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnHerramientas.Image = global::Angencia.Properties.Resources.caja_de_herramientas;
            this.BtnHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHerramientas.Name = "BtnHerramientas";
            this.BtnHerramientas.Size = new System.Drawing.Size(34, 28);
            this.BtnHerramientas.Text = "toolStripButton2";
            // 
            // LblAdministrador
            // 
            this.LblAdministrador.Name = "LblAdministrador";
            this.LblAdministrador.Size = new System.Drawing.Size(126, 28);
            this.LblAdministrador.Text = "Administrador";
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdmin.Image = global::Angencia.Properties.Resources.corona;
            this.BtnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(34, 28);
            this.BtnAdmin.Text = "toolStripButton3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Angencia.Properties.Resources.Fondo_Morado2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 622);
            this.Controls.Add(this.Barraherramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Barraherramientas.ResumeLayout(false);
            this.Barraherramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Barraherramientas;
        private System.Windows.Forms.ToolStripLabel LblTaller;
        private System.Windows.Forms.ToolStripButton BtnTaller;
        private System.Windows.Forms.ToolStripLabel LblHerramientas;
        private System.Windows.Forms.ToolStripButton BtnHerramientas;
        private System.Windows.Forms.ToolStripLabel LblAdministrador;
        private System.Windows.Forms.ToolStripButton BtnAdmin;
    }
}