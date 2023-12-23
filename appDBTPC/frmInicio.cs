using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Agregados
using distancePoints;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
#endregion

namespace appDBTPC
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.optionToolAcercade.Click += new System.EventHandler(this.optionToolAcercade_Click);
            this.optiontoolConfigurar.Click += new System.EventHandler(this.optiontoolConfigurar_Click);
            this.optionToolDirecto.Enabled = false;
            this.optionToolporBase.Enabled = false;
            #region No Activos
            //this.optionToolPlantilla.Enabled = false;
            //this.optionToolPlantilla.Visible = false;
            //this.optionToolporArchivo.Enabled = false;
            //this.optionToolporArchivo.Visible = false;
            this.lblArchivo.Enabled = false;
            this.lblArchivo.Visible = false;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Visible = false;
            //522, 196
            this.txtResult.Size = new System.Drawing.Size(522, 235);
            //12, 130
            this.txtResult.Location = new System.Drawing.Point(12, 91);
            #endregion
        }


        #region Métodos Personalizados

        private void ShowForm<T>() where T : Form, new()
        {
            Cursor.Current = Cursors.WaitCursor;

            using (Form form = new T())
            {
                form.ShowDialog(this);
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        void Salir()
        {
            this.Close();
        }

        void Abre()
        {
            txtResult.Clear();
            txtOrigen.Enabled = false;
            txtDestino.Enabled = false;
            optionToolDirecto.Enabled = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Elige un archivo, sólo MS Excel";
            ofd.Filter = "Archivos Excel (*.xlsx)| *.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = ofd.FileName;
                #region Configura Controles
                this.lblArchivo.Enabled = true;
                this.lblArchivo.Visible = true;
                this.txtArchivo.Enabled = true;
                this.txtArchivo.Visible = true;
                //522, 196
                this.txtResult.Size = new System.Drawing.Size(522, 196);
                //12, 130
                this.txtResult.Location = new System.Drawing.Point(12, 130);
                #endregion
                conExcel(ofd.FileName);
            }

        }

        void conExcel(string fileName)
        {

            try
            {
                //Variables de Datos
                string destinoo = string.Empty;
                string origeen = string.Empty;
                string recorridoKm = string.Empty;
                string recorridoHr = string.Empty;
                string str = string.Empty; ;
                int rCnt = 0;
                int cCnt = 0;
                //Objetos Excel
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook xlWorkBook =
                    xlApp.Workbooks.Open(txtArchivo.Text, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range range = xlWorkSheet.UsedRange;
                //Verificamos si Ms Excel esta instalado en el SO.
                if (xlApp == null)
                {
                    txtResult.AppendText("¡¡ Excel no está instalado correctamente !!");
                    return;
                }

                if (range.Columns.Count <= 19)
                {
                    for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
                    {
                        for (cCnt = 2; cCnt <= range.Columns.Count - 5; cCnt++)
                        {
                            str = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value);
                            if (!String.IsNullOrEmpty(str))
                            {
                                str = str.Trim();
                                if ((cCnt >= 1) && (cCnt <= 6))
                                {
                                    switch (str)
                                    {
                                        case "ID":
                                        case "d_CP":
                                        case "d_asenta":
                                        case "d_mnpio":
                                        case "d_ciudad":
                                        case "d_ESTADO":
                                        case "o_CP":
                                        case "o_asenta":
                                        case "o_mnpio":
                                        case "o_ciudad":
                                        case "o_ESTADO":
                                            break;
                                        default:
                                            if (str != string.Empty)
                                            {
                                                origeen = origeen + str + ",";
                                            }
                                            break;
                                    }
                                }
                                else if ((cCnt >= 10) && (cCnt <= 14))
                                {
                                    switch (str)
                                    {
                                        case "ID":
                                        case "d_CP":
                                        case "d_asenta":
                                        case "d_mnpio":
                                        case "d_ciudad":
                                        case "d_ESTADO":
                                        case "o_CP":
                                        case "o_asenta":
                                        case "o_mnpio":
                                        case "o_ciudad":
                                        case "o_ESTADO":
                                            break;
                                        default:
                                            if (str != string.Empty)
                                            {
                                                destinoo = destinoo + str + ",";
                                            }
                                            break;
                                    }
                                }
                            }

                        }
                        //Aqui debería estar el código para distancia y tiempo
                        getData.obtenDuracionDistancia(origeen, destinoo, "Mexico", "Mexico", out recorridoKm, out recorridoHr);
                        xlWorkSheet.Cells[rCnt, 18] = recorridoKm;
                        xlWorkSheet.Cells[rCnt, 19] = recorridoHr;
                        txtResult.AppendText(Environment.NewLine + "Origen: " + origeen + Environment.NewLine +
                            "Destino: " + destinoo + Environment.NewLine + "Duración: " + recorridoHr +
                            Environment.NewLine + "Distancia: " + recorridoKm);
                    }
                }

                xlWorkBook.Save();
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                //Liberamos los objetos
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                //txtResult.Visible = false;
            }
            catch (Exception ex)
            {
                txtResult.AppendText(Environment.NewLine + "Existe un problema para trabajar con el archivo de Excel."
                    + Environment.NewLine + ex.Message);
            }


        }

        /// <summary>
        /// Crea plantilla de Excel para obtener datos.
        /// </summary>
        void creaPlantilla()
        {
            try
            {
                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    txtResult.AppendText("¡¡ Excel no está instalado correctamente !!");
                    return;
                }


                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "OrigenDestino";
                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "d_CP"; xlWorkSheet.Cells[1, 2].Interior.ColorIndex = 19; xlWorkSheet.Cells[1, 2].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 3] = "d_ASENTAMIENTO"; xlWorkSheet.Cells[1, 3].Interior.ColorIndex = 29; xlWorkSheet.Cells[1, 3].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 4] = "d_MUNICIPIO"; xlWorkSheet.Cells[1, 4].Interior.ColorIndex = 30; xlWorkSheet.Cells[1, 4].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 5] = "d_CIUDAD"; xlWorkSheet.Cells[1, 5].Interior.ColorIndex = 31; xlWorkSheet.Cells[1, 5].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 6] = "d_ESTADO"; xlWorkSheet.Cells[1, 6].Interior.ColorIndex = 32; xlWorkSheet.Cells[1, 6].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 7] = "d_DESC_ZONA";
                xlWorkSheet.Cells[1, 8] = "d_DESC_REGION";
                xlWorkSheet.Cells[1, 9] = "d_LOCALIDAD";
                xlWorkSheet.Cells[1, 10] = "o_CP"; xlWorkSheet.Cells[1, 10].Interior.ColorIndex = 33; xlWorkSheet.Cells[1, 10].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 11] = "o_ASENTAMIENTO"; xlWorkSheet.Cells[1, 11].Interior.ColorIndex = 34; xlWorkSheet.Cells[1, 11].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 12] = "o_MUNICIPIO"; xlWorkSheet.Cells[1, 12].Interior.ColorIndex = 35; xlWorkSheet.Cells[1, 12].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 13] = "o_CIUDAD"; xlWorkSheet.Cells[1, 13].Interior.ColorIndex = 36; xlWorkSheet.Cells[1, 13].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 14] = "o_ESTADO"; xlWorkSheet.Cells[1, 14].Interior.ColorIndex = 37; xlWorkSheet.Cells[1, 14].Font.ColorIndex = 2;
                xlWorkSheet.Cells[1, 15] = "o_DESC_ZONA";
                xlWorkSheet.Cells[1, 16] = "o_DESC_REGION";
                xlWorkSheet.Cells[1, 17] = "o_LOCALIDAD";
                xlWorkSheet.Cells[1, 18] = "DISTANCIA";
                xlWorkSheet.Cells[1, 19] = "TIEMPO";
                xlWorkSheet.Columns.AutoFit();

                for (int indcol = 1; indcol <= 19; indcol++)
                {
                    switch (indcol)
                    {
                        case 1:
                            //Se cambia a Negrita
                            xlWorkSheet.Cells[1, indcol].Font.Bold();

                            //xlWorkSheet.Columns[indcol].AutoFit();
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            //Se cambia a Texto subrrayado
                            xlWorkSheet.Cells[1, indcol].Font.Underline();

                            //xlWorkSheet.Columns[indcol].AutoFit();
                            break;
                        default:
                            //Se cambia a letra Italica
                            xlWorkSheet.Cells[1, indcol].Font.Italic();
                            //xlWorkSheet.Columns[indcol].AutoFit();
                            break;
                    }
                }
                string fecha = DateTime.Now.ToString("yyyyMMddhhmmss");
                string csharp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\distanceCPs\\OrigenDestino" + fecha + ".xlsx";//string.Empty;

                if (!Directory.Exists(Path.GetDirectoryName(csharp)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(csharp));
                }
                if (File.Exists(csharp))
                {
                    fecha = DateTime.Now.ToString("yyyyMMddhhmmss");
                    csharp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\distanceCPs\\OrigenDestino" + fecha + ".xlsx";
                }
                //xlWorkbookNormal = Excel workbook format      xlExcel12 = Excel12         xlWorkbookDefault = Workbook default
                xlWorkBook.SaveAs(csharp, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                txtResult.Clear();
                txtResult.AppendText(Environment.NewLine + "Plantilla Creada!!!!" + Environment.NewLine +
                    "Revisa la ruta: " + csharp + Environment.NewLine);

            }
            catch (Exception ex)
            {
                txtResult.Clear();
                txtResult.AppendText("Error al generar la Plantilla OrigenDestino." + Environment.NewLine + ex.Message);
            }

        }

        /// <summary>
        /// Libera el objeto de la memoria.
        /// </summary>
        /// <param name="obj">Objeto a liberar.</param>
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocurrio una excepción mientras se liberaba el objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        #endregion

        #region Opciones de Menú

        /// <summary>
        /// Cierra el formulario, desde la opción de menú salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionToolSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void optiontoolConfigurar_Click(object sender, EventArgs e)
        {
            //Muestra formulario de configuración
            this.ShowForm<frmConfigura>();
            //Se verificaron los datos de conexion y consulta
            if (Herramientas.dbtpc.Default.Configura == true)
            {
                txtResult.Clear();
                optionToolporBase.Enabled = Herramientas.dbtpc.Default.Configura;
                txtOrigen.Enabled = !Herramientas.dbtpc.Default.Configura;
                txtDestino.Enabled = !Herramientas.dbtpc.Default.Configura;
                txtResult.Focus();
                txtResult.AppendText("Use la opción \"Base\" (ahora disponible) para usar los datos configurados, para obtener datos por lote." + Environment.NewLine);
            }
            else
            {
                txtResult.Clear();
                optionToolporBase.Enabled = Herramientas.dbtpc.Default.Configura;
                txtOrigen.Enabled = !Herramientas.dbtpc.Default.Configura;
                txtDestino.Enabled = !Herramientas.dbtpc.Default.Configura;
                txtOrigen.Focus();
                txtResult.AppendText("Los valores para obtener datos por lotes, aún no se han configurado." + Environment.NewLine);
            }
        }

        private void optionToolAcercade_Click(object sender, EventArgs e)
        {
            //Muestra formulario de Acerca de...
            this.ShowForm<AboutDialog>();
        }

        private void optionToolDirecto_Click(object sender, EventArgs e)
        {
            string distanciaKM = string.Empty;
            string tiempoHr = string.Empty;
            if (txtOrigen.Text.Length > 0)
            {
                if (txtDestino.Text.Length > 0)
                {
                    distancePoints.getData.obtenDuracionDistancia(txtOrigen.Text, txtDestino.Text, "Mexico", "Mexico", out distanciaKM, out tiempoHr);
                    txtResult.Clear();
                    txtResult.AppendText("Se obtuvieron los siguientes datos" + Environment.NewLine +
                        "Distancia: " + distanciaKM + Environment.NewLine +
                        "Tiempo: " + tiempoHr);
                }
                else
                {
                    txtResult.Clear();
                    txtResult.AppendText("Se requiere información del punto de Destino.");
                    txtDestino.Focus();
                }
            }
            else
            {
                txtResult.Clear();
                txtResult.AppendText("Se requiere información del punto de Origen.");
                txtOrigen.Focus();
            }
        }

        private void optionToolporBase_Click(object sender, EventArgs e)
        {
            //Cadena de conexion a la base de datos.
            string CadConec = "Password=" + Herramientas.dbtpc.Default.Acceso +
            "; User ID=" + Herramientas.dbtpc.Default.Usuario +
            "; Initial Catalog=" + Herramientas.dbtpc.Default.Base +
            "; Data Source=" + Herramientas.dbtpc.Default.Servidor +
            ";Connection Timeout = 5";

            SqlConnection Conec = new SqlConnection(CadConec);
            int Actualizaciones = 0;
            try
            {
                Conec.Open();

            }
            catch (Exception ex)
            {
                txtResult.Clear();
                txtResult.AppendText("Error al conectar con la base de datos." + Environment.NewLine +
                    ex.Message);
            }
            try
            {
                //adaptador de Datos SQL
                System.Data.SqlClient.SqlDataAdapter Consul = new System.Data.SqlClient.SqlDataAdapter(Herramientas.dbtpc.Default.Query, CadConec);
                //dataset para manejo de datos
                System.Data.DataSet dsCPs = new DataSet("Datos");
                //manejando datos
                Consul.FillSchema(dsCPs, SchemaType.Source, "Datos");
                Consul.Fill(dsCPs, "Datos");
                //Por cada registro, consulta la API de google maps
                foreach (System.Data.DataRow Renglo in dsCPs.Tables["Datos"].Rows)
                {
                    if (Renglo[1].ToString().Length >= 0)
                    {
                        if (Renglo[2].ToString().Length >= 0)
                        {
                            string Pais = "México";
                            string distaancia = string.Empty;
                            string tieempo = string.Empty;
                            //Obtenemos datos para la actualización
                            distancePoints.getData.obtenDuracionDistancia(Renglo[1].ToString(), Renglo[2].ToString(), Pais, Pais, out distaancia, out tieempo);
                            if (distaancia != "OVER_QUERY_LIMIT")
                            {
                                //Generamos objetos para la actualización
                                System.Data.SqlClient.SqlCommand cmdCP = new System.Data.SqlClient.SqlCommand();
                                cmdCP.CommandType = System.Data.CommandType.Text;
                                cmdCP.CommandText = "UPDATE [dbo].[distanceCPs] SET [distancia_Km] = '" + distaancia + "' ,[distancia_Time] = '" + tieempo + "' WHERE [ID_distance] = " + Renglo[0].ToString();
                                cmdCP.Connection = Conec;
                                //Ejecución de la Sentencia SQL
                                cmdCP.ExecuteNonQuery();
                                Actualizaciones++;
                                txtResult.AppendText(Environment.NewLine +
                                    "ID: " + Renglo[0].ToString() + Environment.NewLine +
                                    "Origen: " + Renglo[1].ToString() + Environment.NewLine +
                                    "Destino: " + Renglo[2].ToString() + Environment.NewLine +
                                    "Distancia: " + distaancia + Environment.NewLine +
                                    "Duración: " + tieempo + Environment.NewLine +
                                    "Registros actualizados: " + Actualizaciones.ToString("##,#", CultureInfo.CurrentCulture) + Environment.NewLine);
                            }
                            else
                            {
                                txtResult.AppendText(Environment.NewLine +
                                    "ID: " + Renglo[0].ToString() + Environment.NewLine +
                                    "Origen: " + Renglo[1].ToString() + Environment.NewLine +
                                    "Destino: " + Renglo[2].ToString() + Environment.NewLine +
                                    "Distancia: " + distaancia + Environment.NewLine +
                                    "Duración: " + tieempo + Environment.NewLine +
                                    "Registros actualizados: " + Actualizaciones.ToString("##,#", CultureInfo.CurrentCulture) + Environment.NewLine);
                                break;
                            }
                        }
                        else { txtResult.AppendText("Formato Inválido del Código Postal de Destino." + Renglo[2].ToString() + Environment.NewLine); }
                    }
                    else { txtResult.AppendText("Formato Inválido del Código Postal de Origen." + Renglo[1].ToString() + Environment.NewLine); }
                    //Levantamos la basura
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                Conec.Close();
                txtResult.AppendText(Environment.NewLine + "Proceso Terminado.");
            }
            catch (Exception ex)
            {
                txtResult.AppendText(Environment.NewLine +
                    "Error al obtener datos." +
                    Environment.NewLine + ex.Message);
            }
            //Fin de proceso por lotes.
        }

        private void optionToolporArchivo_Click(object sender, EventArgs e)
        {
            Abre();
        }

        private void optionToolPlantilla_Click(object sender, EventArgs e)
        {
            creaPlantilla();
        }

        #endregion

        #region Eventos de Controles.

        /// <summary>
        /// Selecciona el texto existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrigen_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOrigen.Text))
            {
                txtOrigen.SelectionStart = 0;
                txtOrigen.SelectionLength = txtOrigen.Text.Length;
            }
        }

        /// <summary>
        /// Selecciona el texto existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDestino_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtOrigen.Text))
            {
                txtOrigen.SelectionStart = 0;
                txtOrigen.SelectionLength = txtOrigen.Text.Length;
            }
        }

        /// <summary>
        /// Cierra el formulario si se presiona la tecla Escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Salir(); }
        }

        /// <summary>
        /// Si hay texto en el control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
            if ((txtOrigen.Text.Length > 0) && (txtDestino.Text.Length > 0))
            {
                this.optionToolDirecto.Enabled = true;
            }
        }

        /// <summary>
        /// Si hay texto en el control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            if ((txtOrigen.Text.Length > 0) && (txtDestino.Text.Length > 0))
            {
                this.optionToolDirecto.Enabled = true;
            }
        }

        /// <summary>
        /// Cuando el control no tiene texto, activa los otros controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            if (txtArchivo.Text == string.Empty)
            {
                this.txtOrigen.Enabled = true;
                this.txtDestino.Enabled = true;
                this.txtOrigen.Focus();
            }
        }

        /// <summary>
        /// Selecciona el texto existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArchivo_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtArchivo.Text))
            {
                txtArchivo.SelectionStart = 0;
                txtArchivo.SelectionLength = txtArchivo.Text.Length;
            }
        }



        #endregion

        private void lblOrigen_Click(object sender, EventArgs e)
        {

        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }

        private void lblArchivo_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
