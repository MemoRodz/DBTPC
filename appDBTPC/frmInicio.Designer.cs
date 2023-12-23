using System.Resources;

namespace appDBTPC
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        ///  Método necesario para admitir el Diseñador. No se puede modificar
        ///  el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            Mainmenu = new MenuStrip();
            toolArchivo = new ToolStripMenuItem();
            optionToolDirecto = new ToolStripMenuItem();
            optionToolporArchivo = new ToolStripMenuItem();
            optionToolporBase = new ToolStripMenuItem();
            toolSeparador1 = new ToolStripSeparator();
            optionToolSalir = new ToolStripMenuItem();
            toolHerramientas = new ToolStripMenuItem();
            optiontoolConfigurar = new ToolStripMenuItem();
            optionToolPlantilla = new ToolStripMenuItem();
            toolAyuda = new ToolStripMenuItem();
            optionToolAcercade = new ToolStripMenuItem();
            txtResult = new TextBox();
            lblOrigen = new Label();
            lblDestino = new Label();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            lblArchivo = new Label();
            txtArchivo = new TextBox();
            Mainmenu.SuspendLayout();
            SuspendLayout();
            // 
            // Mainmenu
            // 
            Mainmenu.ImageScalingSize = new Size(24, 24);
            Mainmenu.Items.AddRange(new ToolStripItem[] { toolArchivo, toolHerramientas, toolAyuda });
            Mainmenu.Location = new Point(0, 0);
            Mainmenu.Name = "Mainmenu";
            Mainmenu.Padding = new Padding(2, 2, 0, 2);
            Mainmenu.Size = new Size(819, 33);
            Mainmenu.TabIndex = 0;
            Mainmenu.Text = "Menú Principal";
            // 
            // toolArchivo
            // 
            toolArchivo.DropDownItems.AddRange(new ToolStripItem[] { optionToolDirecto, optionToolporArchivo, optionToolporBase, toolSeparador1, optionToolSalir });
            toolArchivo.Name = "toolArchivo";
            toolArchivo.Size = new Size(103, 29);
            toolArchivo.Text = "Opciones";
            // 
            // optionToolDirecto
            // 
            optionToolDirecto.Name = "optionToolDirecto";
            optionToolDirecto.Size = new Size(205, 34);
            optionToolDirecto.Text = "Directo";
            optionToolDirecto.Click += optionToolDirecto_Click;
            // 
            // optionToolporArchivo
            // 
            optionToolporArchivo.Name = "optionToolporArchivo";
            optionToolporArchivo.Size = new Size(205, 34);
            optionToolporArchivo.Text = "Por Archivo";
            optionToolporArchivo.Click += optionToolporArchivo_Click;
            // 
            // optionToolporBase
            // 
            optionToolporBase.Name = "optionToolporBase";
            optionToolporBase.Size = new Size(205, 34);
            optionToolporBase.Text = "Por Base";
            optionToolporBase.Click += optionToolporBase_Click;
            // 
            // toolSeparador1
            // 
            toolSeparador1.Name = "toolSeparador1";
            toolSeparador1.Size = new Size(202, 6);
            // 
            // optionToolSalir
            // 
            optionToolSalir.Name = "optionToolSalir";
            optionToolSalir.Size = new Size(205, 34);
            optionToolSalir.Text = "&Salir";
            optionToolSalir.Click += optionToolSalir_Click;
            // 
            // toolHerramientas
            // 
            toolHerramientas.DropDownItems.AddRange(new ToolStripItem[] { optiontoolConfigurar, optionToolPlantilla });
            toolHerramientas.Name = "toolHerramientas";
            toolHerramientas.Size = new Size(133, 29);
            toolHerramientas.Text = "Herramientas";
            // 
            // optiontoolConfigurar
            // 
            optiontoolConfigurar.Name = "optiontoolConfigurar";
            optiontoolConfigurar.Size = new Size(225, 34);
            optiontoolConfigurar.Text = "Configuración";
            // 
            // optionToolPlantilla
            // 
            optionToolPlantilla.Name = "optionToolPlantilla";
            optionToolPlantilla.Size = new Size(225, 34);
            optionToolPlantilla.Text = "Plantilla";
            optionToolPlantilla.Click += optionToolPlantilla_Click;
            // 
            // toolAyuda
            // 
            toolAyuda.DropDownItems.AddRange(new ToolStripItem[] { optionToolAcercade });
            toolAyuda.Name = "toolAyuda";
            toolAyuda.Size = new Size(79, 29);
            toolAyuda.Text = "A&yuda";
            // 
            // optionToolAcercade
            // 
            optionToolAcercade.Name = "optionToolAcercade";
            optionToolAcercade.Size = new Size(203, 34);
            optionToolAcercade.Text = "Acerca de...";
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.BackColor = SystemColors.Window;
            txtResult.Location = new Point(18, 200);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(781, 299);
            txtResult.TabIndex = 8;
            txtResult.Text = "\r\nPara un primer uso, favor de consultar la opción \"Acerca de\", del menú de \"Ayuda\".";
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(18, 62);
            lblOrigen.Margin = new Padding(4, 0, 4, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(70, 25);
            lblOrigen.TabIndex = 5;
            lblOrigen.Text = "Origen:";
            lblOrigen.Click += lblOrigen_Click;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(18, 105);
            lblDestino.Margin = new Padding(4, 0, 4, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(68, 20);
            lblDestino.TabIndex = 6;
            lblDestino.Text = "Destino:";
            lblDestino.Click += lblDestino_Click;
            // 
            // txtOrigen
            // 
            txtOrigen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrigen.Location = new Point(86, 57);
            txtOrigen.Margin = new Padding(4, 5, 4, 5);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(714, 26);
            txtOrigen.TabIndex = 1;
            txtOrigen.TextChanged += txtOrigen_TextChanged;
            txtOrigen.Enter += txtOrigen_Enter;
            // 
            // txtDestino
            // 
            txtDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestino.Location = new Point(86, 100);
            txtDestino.Margin = new Padding(4, 6, 4, 6);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(714, 31);
            txtDestino.TabIndex = 2;
            txtDestino.TextChanged += txtDestino_TextChanged;
            txtDestino.Enter += txtDestino_Enter;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(15, 151);
            lblArchivo.Margin = new Padding(4, 0, 4, 0);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(65, 20);
            lblArchivo.TabIndex = 9;
            lblArchivo.Text = "Archivo:";
            lblArchivo.Click += lblArchivo_Click;
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(86, 146);
            txtArchivo.Margin = new Padding(4, 5, 4, 5);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(714, 26);
            txtArchivo.TabIndex = 10;
            txtArchivo.TextChanged += txtArchivo_TextChanged;
            txtArchivo.Enter += txtArchivo_Enter;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 520);
            Controls.Add(txtArchivo);
            Controls.Add(lblArchivo);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(txtResult);
            Controls.Add(Mainmenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Mainmenu;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Obtener distancia de dos localidades";
            KeyDown += frmInicio_KeyDown;
            Mainmenu.ResumeLayout(false);
            Mainmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Mainmenu;
        private System.Windows.Forms.ToolStripMenuItem toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem optionToolDirecto;
        private System.Windows.Forms.ToolStripMenuItem optionToolporBase;
        private System.Windows.Forms.ToolStripSeparator toolSeparador1;
        private System.Windows.Forms.ToolStripMenuItem optionToolSalir;
        private System.Windows.Forms.ToolStripMenuItem toolAyuda;
        private System.Windows.Forms.ToolStripMenuItem optionToolAcercade;
        private System.Windows.Forms.ToolStripMenuItem toolHerramientas;
        private System.Windows.Forms.ToolStripMenuItem optiontoolConfigurar;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        public System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ToolStripMenuItem optionToolporArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.ToolStripMenuItem optionToolPlantilla;
    }
}
