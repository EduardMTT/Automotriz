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
            this.components = new System.ComponentModel.Container();
            this.Barraherramientas = new System.Windows.Forms.ToolStrip();
            this.BtnTaller = new System.Windows.Forms.ToolStripButton();
            this.BtnHerramientas = new System.Windows.Forms.ToolStripButton();
            this.BtnAdmin = new System.Windows.Forms.ToolStripButton();
            this.PanelShow = new System.Windows.Forms.Panel();
            this.Verificar = new System.Windows.Forms.Timer(this.components);
            this.UserName = new System.Windows.Forms.Label();
            this.Barraherramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barraherramientas
            // 
            this.Barraherramientas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Barraherramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTaller,
            this.BtnHerramientas,
            this.BtnAdmin});
            this.Barraherramientas.Location = new System.Drawing.Point(0, 0);
            this.Barraherramientas.Name = "Barraherramientas";
            this.Barraherramientas.Size = new System.Drawing.Size(1165, 34);
            this.Barraherramientas.TabIndex = 1;
            this.Barraherramientas.Text = "toolStrip1";
            // 
            // BtnTaller
            // 
            this.BtnTaller.BackColor = System.Drawing.Color.Transparent;
            this.BtnTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTaller.Image = global::Angencia.Properties.Resources.configuracion;
            this.BtnTaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTaller.Name = "BtnTaller";
            this.BtnTaller.Size = new System.Drawing.Size(79, 29);
            this.BtnTaller.Text = "Taller";
            this.BtnTaller.ToolTipText = "Registro de herramientas en el taller";
            this.BtnTaller.Click += new System.EventHandler(this.BtnTaller_Click);
            // 
            // BtnHerramientas
            // 
            this.BtnHerramientas.Image = global::Angencia.Properties.Resources.caja_de_herramientas;
            this.BtnHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHerramientas.Name = "BtnHerramientas";
            this.BtnHerramientas.Size = new System.Drawing.Size(132, 29);
            this.BtnHerramientas.Text = "Refacciones";
            this.BtnHerramientas.ToolTipText = "Información de las refacciones existentes";
            this.BtnHerramientas.Click += new System.EventHandler(this.BtnHerramientas_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Image = global::Angencia.Properties.Resources.corona;
            this.BtnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(154, 29);
            this.BtnAdmin.Text = "Administrador";
            this.BtnAdmin.ToolTipText = "Creacion de usuarios y control de modulos";
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // PanelShow
            // 
            this.PanelShow.Location = new System.Drawing.Point(12, 64);
            this.PanelShow.Name = "PanelShow";
            this.PanelShow.Size = new System.Drawing.Size(1141, 630);
            this.PanelShow.TabIndex = 2;
            this.PanelShow.Visible = false;
            // 
            // Verificar
            // 
            this.Verificar.Enabled = true;
            this.Verificar.Tick += new System.EventHandler(this.Verificar_Tick);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.White;
            this.UserName.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(921, 5);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(119, 29);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Angencia.Properties.Resources.Fondo_Morado2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 716);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PanelShow);
            this.Controls.Add(this.Barraherramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Barraherramientas.ResumeLayout(false);
            this.Barraherramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Barraherramientas;
        private System.Windows.Forms.ToolStripButton BtnTaller;
        private System.Windows.Forms.ToolStripButton BtnHerramientas;
        private System.Windows.Forms.ToolStripButton BtnAdmin;
        private System.Windows.Forms.Panel PanelShow;
        private System.Windows.Forms.Timer Verificar;
        private System.Windows.Forms.Label UserName;
    }
}