using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDBTPC
{
    public partial class AboutDialog : Form
    {
        #region Componentes Privados

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Metodos Protegidos

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

        #endregion

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            closeButton = new Button();
            nameLabel = new Label();
            versionLabel = new Label();
            copyrightLabel = new Label();
            iconPictureBox = new PictureBox();
            footerGroupBox = new Panel();
            doctoLabel = new LinkLabel();
            aforgeLabel = new LinkLabel();
            webLinkLabel = new LinkLabel();
            docsTabControl = new TabControl();
            lbl1 = new Label();
            lbl2 = new Label();
            ((ISupportInitialize)iconPictureBox).BeginInit();
            footerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(528, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "&Cerrar";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(50, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // versionLabel
            // 
            versionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            versionLabel.Location = new Point(50, 25);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(68, 23);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version";
            // 
            // copyrightLabel
            // 
            copyrightLabel.AutoSize = true;
            copyrightLabel.Location = new Point(53, 47);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(88, 25);
            copyrightLabel.TabIndex = 2;
            copyrightLabel.Text = "copyright";
            // 
            // iconPictureBox
            // 
            iconPictureBox.Image = Properties.Resources.GRSIco;
            iconPictureBox.Location = new Point(12, 12);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new Size(48, 48);
            iconPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox.TabIndex = 4;
            iconPictureBox.TabStop = false;
            // 
            // footerGroupBox
            // 
            footerGroupBox.BackColor = SystemColors.Control;
            footerGroupBox.Controls.Add(doctoLabel);
            footerGroupBox.Controls.Add(aforgeLabel);
            footerGroupBox.Controls.Add(webLinkLabel);
            footerGroupBox.Controls.Add(closeButton);
            footerGroupBox.Dock = DockStyle.Bottom;
            footerGroupBox.Location = new Point(0, 448);
            footerGroupBox.Name = "footerGroupBox";
            footerGroupBox.Size = new Size(615, 47);
            footerGroupBox.TabIndex = 4;
            footerGroupBox.Paint += footerGroupBox_Paint;
            // 
            // doctoLabel
            // 
            doctoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            doctoLabel.AutoSize = true;
            doctoLabel.Location = new Point(12, -27);
            doctoLabel.Name = "doctoLabel";
            doctoLabel.Size = new Size(513, 25);
            doctoLabel.TabIndex = 3;
            doctoLabel.TabStop = true;
            doctoLabel.Tag = "https://developers.google.com/maps/documentation/distance-matrix/intro?hl=es#Introduction";
            doctoLabel.Text = "developers.google.com/maps/documentation/distance-matrix/";
            doctoLabel.Click += webLinkLabel_Click;
            // 
            // aforgeLabel
            // 
            aforgeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            aforgeLabel.AutoSize = true;
            aforgeLabel.ForeColor = SystemColors.HotTrack;
            aforgeLabel.Location = new Point(12, 6);
            aforgeLabel.Name = "aforgeLabel";
            aforgeLabel.Size = new Size(191, 25);
            aforgeLabel.TabIndex = 2;
            aforgeLabel.TabStop = true;
            aforgeLabel.Tag = "https://memorodz.github.io/portfolio";
            aforgeLabel.Text = "memorodz.github.io/portfolio";
            aforgeLabel.Click += webLinkLabel_Click;
            // 
            // webLinkLabel
            // 
            webLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            webLinkLabel.AutoSize = true;
            webLinkLabel.ForeColor = SystemColors.HotTrack;
            webLinkLabel.Location = new Point(345, 11);
            webLinkLabel.Name = "webLinkLabel";
            webLinkLabel.Size = new Size(257, 25);
            webLinkLabel.TabIndex = 0;
            webLinkLabel.TabStop = true;
            webLinkLabel.Tag = "https://developers.google.com/maps/documentation/distance-matrix/usage-limits?hl=es";
            webLinkLabel.Text = "developers.google.com/maps/";
            webLinkLabel.Click += webLinkLabel_Click;
            // 
            // docsTabControl
            // 
            docsTabControl.Location = new Point(12, 77);
            docsTabControl.Name = "docsTabControl";
            docsTabControl.SelectedIndex = 0;
            docsTabControl.Size = new Size(591, 365);
            docsTabControl.TabIndex = 3;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl1.Location = new Point(388, 12);
            lbl1.Name = "lbl1";
            lbl1.RightToLeft = RightToLeft.No;
            lbl1.Size = new Size(240, 25);
            lbl1.TabIndex = 13;
            lbl1.Text = "Distancia entre dos puntos.";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(382, 34);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(247, 50);
            lbl2.TabIndex = 14;
            lbl2.Text = "Programa para Portafolio\r\nde Proyectos.";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            AcceptButton = closeButton;
            BackColor = SystemColors.Window;
            CancelButton = closeButton;
            ClientSize = new Size(615, 495);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(docsTabControl);
            Controls.Add(footerGroupBox);
            Controls.Add(iconPictureBox);
            Controls.Add(copyrightLabel);
            Controls.Add(versionLabel);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de DBTPC";
            ((ISupportInitialize)iconPictureBox).EndInit();
            footerGroupBox.ResumeLayout(false);
            footerGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Componentes de Windows Forms

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Panel footerGroupBox;
        private System.Windows.Forms.LinkLabel webLinkLabel;
        private LinkLabel aforgeLabel;
        private LinkLabel doctoLabel;
        private Label lbl1;
        private Label lbl2;
        private System.Windows.Forms.TabControl docsTabControl;

        #endregion

        #region Constructores Publicos

        public AboutDialog()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Miembros de Clase

        internal static void ShowAboutDialog()
        {
            using (Form dialog = new AboutDialog())
            {
                dialog.ShowDialog();
            }
        }

        #endregion

        #region Metodos  Sobrescritos

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!this.DesignMode)
            {
                FileVersionInfo info;
                Assembly assembly;
                string title;
                FileVersionInfo desc;
                Assembly baseassembly;
                string description;


                assembly = typeof(distancePoints.getData).Assembly;
                baseassembly = typeof(AboutDialog).Assembly;
                info = FileVersionInfo.GetVersionInfo(assembly.Location);
                desc = FileVersionInfo.GetVersionInfo(baseassembly.Location);
                title = info.ProductName;
                description = desc.ProductName;

                this.Text = string.Format("Acerca de {0}", description);
                nameLabel.Text = string.Format("Basado en  {0}", title);
                versionLabel.Text = string.Format("Version {0}", info.FileVersion);
                copyrightLabel.Text = info.LegalCopyright;

                //Agregamos archivos de ayuda
                this.AddReadme("GuiaUso.txt");
                this.AddReadme("Copyright.txt");
                this.AddReadme("googleMapsAPI.txt");

            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (docsTabControl != null)
            {
                docsTabControl.SetBounds(docsTabControl.Left, docsTabControl.Top, this.ClientSize.Width - (docsTabControl.Left * 2), this.ClientSize.Height - (docsTabControl.Top + footerGroupBox.Height + docsTabControl.Left));
            }
        }

        #endregion

        #region Propiedades Protegidas

        protected TabControl TabControl
        {
            get { return docsTabControl; }
        }

        #endregion

        #region Miembros Privados

        private void AddReadme(string fileName)
        {
            TabPage page;
            TextBox textBox;
            string fullPath;

            fullPath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Herramientas\"), fileName);

            page = new TabPage
            {
                UseVisualStyleBackColor = true,
                Padding = new Padding(9),
                ToolTipText = fullPath,
                //BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Text = Path.GetFileNameWithoutExtension(fileName)
            };

            textBox = new TextBox
            {
                ReadOnly = true,
                Multiline = true,
                WordWrap = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                //BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Text = File.ReadAllText(fullPath)
            };

            page.Controls.Add(textBox);

            docsTabControl.TabPages.Add(page);
        }

        #endregion

        #region Manejadores de Eventos

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void footerGroupBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, footerGroupBox.Width, 0);
            e.Graphics.DrawLine(SystemPens.ControlLightLight, 0, 1, footerGroupBox.Width, 1);
        }

        private void webLinkLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((Control)sender).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("No se puede iniciar la URL especificada.\n\n{0}", ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
    }
}
