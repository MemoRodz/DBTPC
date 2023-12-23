namespace appDBTPC
{
    partial class frmConfigura
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.txtAcceso = new System.Windows.Forms.TextBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtMensajero = new System.Windows.Forms.TextBox();
            this.btnCierra = new System.Windows.Forms.Button();
            this.tipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 28);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(49, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Servidor:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(59, 28);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServer.Size = new System.Drawing.Size(213, 39);
            this.txtServer.TabIndex = 1;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(59, 73);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(214, 20);
            this.txtBase.TabIndex = 3;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(12, 68);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(46, 26);
            this.lblDataBase.TabIndex = 2;
            this.lblDataBase.Text = "Base de\r\nDatos:";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(12, 120);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.Size = new System.Drawing.Size(261, 115);
            this.txtQuery.TabIndex = 5;
            this.tipAyuda.SetToolTip(this.txtQuery, "Las 2 primeras columnas deben ser:\r\nOrigen y Destino.");
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(12, 104);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(75, 13);
            this.lblQuery.TabIndex = 4;
            this.lblQuery.Text = "Consulta SQL:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(368, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(304, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Location = new System.Drawing.Point(295, 76);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(64, 13);
            this.lblAcceso.TabIndex = 8;
            this.lblAcceso.Text = "Contraseña:";
            // 
            // txtAcceso
            // 
            this.txtAcceso.Location = new System.Drawing.Point(368, 74);
            this.txtAcceso.Name = "txtAcceso";
            this.txtAcceso.PasswordChar = '*';
            this.txtAcceso.Size = new System.Drawing.Size(138, 20);
            this.txtAcceso.TabIndex = 9;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(381, 102);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(101, 13);
            this.lblVer.TabIndex = 10;
            this.lblVer.Text = "Verificar contraseña";
            // 
            // btnTest
            // 
            this.btnTest.AutoSize = true;
            this.btnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTest.Location = new System.Drawing.Point(298, 212);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(48, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Probar";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Location = new System.Drawing.Point(352, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtMensajero
            // 
            this.txtMensajero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajero.Location = new System.Drawing.Point(298, 120);
            this.txtMensajero.Multiline = true;
            this.txtMensajero.Name = "txtMensajero";
            this.txtMensajero.ReadOnly = true;
            this.txtMensajero.Size = new System.Drawing.Size(205, 86);
            this.txtMensajero.TabIndex = 14;
            this.txtMensajero.Text = "La consulta que introduzca debe tener como primeras dos columnas datos que refier" +
    "an a Origen y Destino.";
            // 
            // btnCierra
            // 
            this.btnCierra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCierra.Location = new System.Drawing.Point(431, 212);
            this.btnCierra.Name = "btnCierra";
            this.btnCierra.Size = new System.Drawing.Size(75, 23);
            this.btnCierra.TabIndex = 15;
            this.btnCierra.Text = "Cerrar";
            this.btnCierra.UseVisualStyleBackColor = true;
            this.btnCierra.Click += new System.EventHandler(this.btnCierra_Click);
            // 
            // frmConfigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 247);
            this.Controls.Add(this.btnCierra);
            this.Controls.Add(this.txtMensajero);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.txtAcceso);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfigura_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.TextBox txtAcceso;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtMensajero;
        private System.Windows.Forms.Button btnCierra;
        private System.Windows.Forms.ToolTip tipAyuda;
    }
}