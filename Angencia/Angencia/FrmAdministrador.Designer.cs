namespace Angencia
{
    partial class FrmAdministrador
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
            this.DgUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupoDatos = new System.Windows.Forms.GroupBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.TxtApP = new System.Windows.Forms.TextBox();
            this.TxtApM = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CBEliminar = new System.Windows.Forms.CheckBox();
            this.CBCrearyEditar = new System.Windows.Forms.CheckBox();
            this.CBLeer = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgUsuarios)).BeginInit();
            this.GrupoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgUsuarios
            // 
            this.DgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgUsuarios.Location = new System.Drawing.Point(17, 61);
            this.DgUsuarios.Name = "DgUsuarios";
            this.DgUsuarios.RowHeadersWidth = 62;
            this.DgUsuarios.RowTemplate.Height = 28;
            this.DgUsuarios.Size = new System.Drawing.Size(447, 590);
            this.DgUsuarios.TabIndex = 0;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.BackgroundImage = global::Angencia.Properties.Resources.agregar_usuario;
            this.BtnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(129, 22);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(36, 33);
            this.BtnAgregarUsuario.TabIndex = 2;
            this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackgroundImage = global::Angencia.Properties.Resources.borrar;
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrar.Location = new System.Drawing.Point(73, 22);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(37, 33);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackgroundImage = global::Angencia.Properties.Resources.editar;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Location = new System.Drawing.Point(17, 22);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(37, 33);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(524, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Control de Usuarios";
            // 
            // GrupoDatos
            // 
            this.GrupoDatos.BackColor = System.Drawing.Color.AliceBlue;
            this.GrupoDatos.Controls.Add(this.checkBox1);
            this.GrupoDatos.Controls.Add(this.textBox1);
            this.GrupoDatos.Controls.Add(this.label9);
            this.GrupoDatos.Controls.Add(this.TxtPass);
            this.GrupoDatos.Controls.Add(this.label8);
            this.GrupoDatos.Controls.Add(this.TxtNombre);
            this.GrupoDatos.Controls.Add(this.BtnGuardar);
            this.GrupoDatos.Controls.Add(this.TxtRFC);
            this.GrupoDatos.Controls.Add(this.TxtApP);
            this.GrupoDatos.Controls.Add(this.TxtApM);
            this.GrupoDatos.Controls.Add(this.TxtUsuario);
            this.GrupoDatos.Controls.Add(this.TxtID);
            this.GrupoDatos.Controls.Add(this.CBEliminar);
            this.GrupoDatos.Controls.Add(this.CBCrearyEditar);
            this.GrupoDatos.Controls.Add(this.CBLeer);
            this.GrupoDatos.Controls.Add(this.label7);
            this.GrupoDatos.Controls.Add(this.label6);
            this.GrupoDatos.Controls.Add(this.label5);
            this.GrupoDatos.Controls.Add(this.label4);
            this.GrupoDatos.Controls.Add(this.label3);
            this.GrupoDatos.Controls.Add(this.label1);
            this.GrupoDatos.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoDatos.Location = new System.Drawing.Point(470, 61);
            this.GrupoDatos.Name = "GrupoDatos";
            this.GrupoDatos.Size = new System.Drawing.Size(430, 590);
            this.GrupoDatos.TabIndex = 7;
            this.GrupoDatos.TabStop = false;
            this.GrupoDatos.Text = "Datos y Permisos";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(103, 402);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(222, 36);
            this.TxtPass.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contraseña";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(120, 111);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(282, 36);
            this.TxtNombre.TabIndex = 15;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Location = new System.Drawing.Point(157, 542);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 42);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // TxtRFC
            // 
            this.TxtRFC.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRFC.Location = new System.Drawing.Point(61, 255);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(222, 36);
            this.TxtRFC.TabIndex = 13;
            // 
            // TxtApP
            // 
            this.TxtApP.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApP.Location = new System.Drawing.Point(14, 160);
            this.TxtApP.Name = "TxtApP";
            this.TxtApP.Size = new System.Drawing.Size(186, 36);
            this.TxtApP.TabIndex = 12;
            // 
            // TxtApM
            // 
            this.TxtApM.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApM.Location = new System.Drawing.Point(216, 160);
            this.TxtApM.Name = "TxtApM";
            this.TxtApM.Size = new System.Drawing.Size(186, 36);
            this.TxtApM.TabIndex = 11;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(148, 337);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(146, 36);
            this.TxtUsuario.TabIndex = 10;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(40, 31);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(117, 36);
            this.TxtID.TabIndex = 9;
            // 
            // CBEliminar
            // 
            this.CBEliminar.AutoSize = true;
            this.CBEliminar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEliminar.Location = new System.Drawing.Point(14, 480);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(105, 27);
            this.CBEliminar.TabIndex = 8;
            this.CBEliminar.Text = "Eliminar";
            this.CBEliminar.UseVisualStyleBackColor = true;
            // 
            // CBCrearyEditar
            // 
            this.CBCrearyEditar.AutoSize = true;
            this.CBCrearyEditar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCrearyEditar.Location = new System.Drawing.Point(14, 513);
            this.CBCrearyEditar.Name = "CBCrearyEditar";
            this.CBCrearyEditar.Size = new System.Drawing.Size(150, 27);
            this.CBCrearyEditar.TabIndex = 7;
            this.CBCrearyEditar.Text = "Crear y Editar";
            this.CBCrearyEditar.UseVisualStyleBackColor = true;
            // 
            // CBLeer
            // 
            this.CBLeer.AutoSize = true;
            this.CBLeer.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLeer.Location = new System.Drawing.Point(14, 447);
            this.CBLeer.Name = "CBLeer";
            this.CBLeer.Size = new System.Drawing.Size(74, 27);
            this.CBLeer.TabIndex = 6;
            this.CBLeer.Text = "Leer";
            this.CBLeer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "RFC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellito Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre (s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(258, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 36);
            this.textBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de Nacimiento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(258, 480);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 27);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Administrador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Angencia.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 684);
            this.Controls.Add(this.GrupoDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnAgregarUsuario);
            this.Controls.Add(this.DgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.DgUsuarios)).EndInit();
            this.GrupoDatos.ResumeLayout(false);
            this.GrupoDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgUsuarios;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrupoDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBEliminar;
        private System.Windows.Forms.CheckBox CBCrearyEditar;
        private System.Windows.Forms.CheckBox CBLeer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtApP;
        private System.Windows.Forms.TextBox TxtApM;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}