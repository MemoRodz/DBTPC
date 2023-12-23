using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDBTPC
{
    public partial class frmConfigura : Form
    {
        public frmConfigura()
        {
            InitializeComponent();
            txtServer.Text = Herramientas.dbtpc.Default.Servidor;
            txtBase.Text = Herramientas.dbtpc.Default.Base;
            txtUsuario.Text = Herramientas.dbtpc.Default.Usuario;
            txtAcceso.Text = Herramientas.dbtpc.Default.Acceso;
            txtQuery.Text = Herramientas.dbtpc.Default.Query;
            btnAceptar.Enabled = false;
        }

        #region Eventos de Control

        /// <summary>
        /// Evento click del botón de Prueba.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (statusConec())
            {
                txtMensajero.Clear();
                txtMensajero.AppendText(Environment.NewLine + "Valores de conexión válidos.");
                btnAceptar.Enabled = true;
                btnCierra.Enabled = false;
            }
            else
            {
                txtMensajero.Clear();
                txtMensajero.AppendText(Environment.NewLine + "Verifique los valores de conexión." + Environment.NewLine +
                    "Para poder guardar los valores de configuración, debe:" + Environment.NewLine +
                    "\t*Revisar el Servidor." + Environment.NewLine +
                    "\t*Revisar Base de Datos." + Environment.NewLine +
                    "\t*Revisar usuario y contraseña." + Environment.NewLine +
                    "\t*Consulta.");
            }

        }

        /// <summary>
        /// Evento click del botón Aceptar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (statusConec())
            {
                Herramientas.dbtpc.Default.Servidor = txtServer.Text;
                Herramientas.dbtpc.Default.Base = txtBase.Text;
                Herramientas.dbtpc.Default.Usuario = txtUsuario.Text;
                Herramientas.dbtpc.Default.Acceso = txtAcceso.Text;
                Herramientas.dbtpc.Default.Query = txtQuery.Text;
                Herramientas.dbtpc.Default.Configura = btnAceptar.Enabled;
                Herramientas.dbtpc.Default.Save();
                Salir();
            }
            else
            {
                txtMensajero.AppendText(Environment.NewLine +
                    "Verifique datos." + Environment.NewLine +
                    "Oprima el botón cerrar, para salir del Formulario.");
                btnCierra.Focus();
            }
        }

        /// <summary>
        /// Cierra formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCierra_Click(object sender, EventArgs e)
        {
            Herramientas.dbtpc.Default.Configura = btnAceptar.Enabled;
            Herramientas.dbtpc.Default.Save();
            Salir();
        }

        /// <summary>
        /// Evalua si se ha presionado la tecla Escape, entonces Cierra el Formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConfigura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Salir(); }
        }

        #endregion

        #region Métodos Personalizados

        /// <summary>
        /// Verifica el estatus de la conexión.
        /// </summary>
        /// <returns>True si Conecta de lo contrario False.</returns>
        public bool statusConec()
        {
            //Cadena de conexion a la base de datos.
            string Cadena = "Password=" + txtAcceso.Text +
            "; User ID=" + txtUsuario.Text +
            "; Initial Catalog=" + txtBase.Text +
            "; Data Source=" + txtServer.Text +
            ";Connection Timeout = 5";
            bool Conectado = false;
            SqlConnection Conec = new SqlConnection(Cadena);
            try
            {
                Conec.Open();
                if (StatusQuery(Cadena))
                {
                    Conectado = true;
                }
            }
            catch (Exception e)
            {
                txtMensajero.Clear();
                txtMensajero.AppendText(Environment.NewLine + "Error en los datos de conexión." +
                    Environment.NewLine + e.Message + Environment.NewLine);
                Conectado = false;
            }

            return Conectado;
        }

        /// <summary>
        /// Verifica que los datos de conexión y la consulta sean válidos.
        /// </summary>
        /// <returns>Si son válidos, regresa True.</returns>
        public bool StatusQuery(string cadConecta)
        {
            bool Conectado = false;
            try
            {
                using (SqlConnection Conec = new SqlConnection(cadConecta))
                {
                    Conec.Open();
                    //adaptador de Datos SQL
                    System.Data.SqlClient.SqlDataAdapter Consul = new System.Data.SqlClient.SqlDataAdapter(txtQuery.Text, cadConecta);
                    //dataset para manejo de datos
                    System.Data.DataSet dsCPs = new DataSet("Datos");
                    //manejando datos
                    Consul.FillSchema(dsCPs, SchemaType.Source, "Datos");
                    Consul.Fill(dsCPs, "Datos");
                    if (dsCPs.Tables["Datos"].Rows.Count > 0)
                    {
                        txtMensajero.AppendText("Consulta válida." + Environment.NewLine +
                            "Total de registros: " + dsCPs.Tables["Datos"].Rows.Count);
                        Conectado = true;
                    }
                    else
                    {
                        txtMensajero.AppendText("Consulta sin resultados." + Environment.NewLine +
                            "Registros: " + dsCPs.Tables["Datos"].Rows.Count);
                        Conectado = false;
                    }

                }
            }
            catch (Exception e)
            {
                txtMensajero.Clear();
                txtMensajero.AppendText("Problemas al ejecutar la consulta." + Environment.NewLine + e.Message + Environment.NewLine);
                Conectado = false;
            }

            return Conectado;
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        void Salir()
        {
            this.Close();
        }

        #endregion
    }
}
