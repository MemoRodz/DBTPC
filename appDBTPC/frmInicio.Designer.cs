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
            Mainmenu = new MenuStrip();
            SuspendLayout();
            // 
            // Mainmenu
            // 
            this.Mainmenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Mainmenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolHerramientas,
            this.toolAyuda});
            this.Mainmenu.Location = new System.Drawing.Point(0, 0);
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(819, 35);
            this.Mainmenu.TabIndex = 0;
            this.Mainmenu.Text = "Menú Principal";
            // 
            // toolArchivo
            // 
            this.toolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolDirecto,
            this.optionToolporArchivo,
            this.optionToolporBase,
            this.toolSeparador1,
            this.optionToolSalir});
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(103, 29);
            this.toolArchivo.Text = "Opciones";
            // 
            // optionToolDirecto
            // 
            this.optionToolDirecto.Name = "optionToolDirecto";
            this.optionToolDirecto.Size = new System.Drawing.Size(205, 34);
            this.optionToolDirecto.Text = "Directo";
            this.optionToolDirecto.Click += new System.EventHandler(this.optionToolDirecto_Click);
            // 
            // optionToolporArchivo
            // 
            this.optionToolporArchivo.Name = "optionToolporArchivo";
            this.optionToolporArchivo.Size = new System.Drawing.Size(205, 34);
            this.optionToolporArchivo.Text = "Por Archivo";
            this.optionToolporArchivo.Click += new System.EventHandler(this.optionToolporArchivo_Click);
            // 
            // optionToolporBase
            // 
            this.optionToolporBase.Name = "optionToolporBase";
            this.optionToolporBase.Size = new System.Drawing.Size(205, 34);
            this.optionToolporBase.Text = "Por Base";
            this.optionToolporBase.Click += new System.EventHandler(this.optionToolporBase_Click);
            // 
            // toolSeparador1
            // 
            this.toolSeparador1.Name = "toolSeparador1";
            this.toolSeparador1.Size = new System.Drawing.Size(202, 6);
            // 
            // optionToolSalir
            // 
            this.optionToolSalir.Name = "optionToolSalir";
            this.optionToolSalir.Size = new System.Drawing.Size(205, 34);
            this.optionToolSalir.Text = "&Salir";
            this.optionToolSalir.Click += new System.EventHandler(this.optionToolSalir_Click);
            // 
            // toolHerramientas
            // 
            this.toolHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiontoolConfigurar,
            this.optionToolPlantilla});
            this.toolHerramientas.Name = "toolHerramientas";
            this.toolHerramientas.Size = new System.Drawing.Size(133, 29);
            this.toolHerramientas.Text = "Herramientas";
            // 
            // optiontoolConfigurar
            // 
            this.optiontoolConfigurar.Name = "optiontoolConfigurar";
            this.optiontoolConfigurar.Size = new System.Drawing.Size(225, 34);
            this.optiontoolConfigurar.Text = "Configuración";
            // 
            // optionToolPlantilla
            // 
            this.optionToolPlantilla.Name = "optionToolPlantilla";
            this.optionToolPlantilla.Size = new System.Drawing.Size(225, 34);
            this.optionToolPlantilla.Text = "Plantilla";
            this.optionToolPlantilla.Click += new System.EventHandler(this.optionToolPlantilla_Click);
            // 
            // toolAyuda
            // 
            this.toolAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolAcercade});
            this.toolAyuda.Name = "toolAyuda";
            this.toolAyuda.Size = new System.Drawing.Size(79, 29);
            this.toolAyuda.Text = "A&yuda";
            // 
            // optionToolAcercade
            // 
            this.optionToolAcercade.Name = "optionToolAcercade";
            this.optionToolAcercade.Size = new System.Drawing.Size(203, 34);
            this.optionToolAcercade.Text = "Acerca de...";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(18, 200);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(781, 299);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "\r\nPara un primer uso, favor de consultar la opción \"Acerca de\", del menú de \"Ayud" +
    "a\".";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(18, 62);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(60, 20);
            this.lblOrigen.TabIndex = 5;
            this.lblOrigen.Text = "Origen:";
            this.lblOrigen.Click += new System.EventHandler(this.lblOrigen_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(18, 105);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(68, 20);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Destino:";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigen.Location = new System.Drawing.Point(86, 57);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(714, 26);
            this.txtOrigen.TabIndex = 1;
            this.txtOrigen.TextChanged += new System.EventHandler(this.txtOrigen_TextChanged);
            this.txtOrigen.Enter += new System.EventHandler(this.txtOrigen_Enter);
            // 
            // txtDestino
            // 
            this.txtDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestino.Location = new System.Drawing.Point(86, 100);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(714, 26);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            this.txtDestino.Enter += new System.EventHandler(this.txtDestino_Enter);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(15, 151);
            this.lblArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(65, 20);
            this.lblArchivo.TabIndex = 9;
            this.lblArchivo.Text = "Archivo:";
            this.lblArchivo.Click += new System.EventHandler(this.lblArchivo_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(86, 146);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(714, 26);
            this.txtArchivo.TabIndex = 10;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            this.txtArchivo.Enter += new System.EventHandler(this.txtArchivo_Enter);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 520);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Mainmenu);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mainmenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener distancia de dos localidades";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInicio_KeyDown);
            this.Mainmenu.ResumeLayout(false);
            this.Mainmenu.PerformLayout();
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
