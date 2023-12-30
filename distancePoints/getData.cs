using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Agregados
using System.Xml;
using System.IO;
using System.Net;
using System.Globalization;
#endregion

namespace distancePoints
{
    public class getData
    {
        /// <summary>
        /// Muestra un Saludo.
        /// </summary>
        /// <returns>Saludo.</returns>
        public static string Saluda()
        {
            string saludos = "Creado por: Guillermo Rodríguez." + Environment.NewLine +
                "Fecha: 05/mayo/2016." + Environment.NewLine + "Para Poryectos de Portafolio, Winform." + Environment.NewLine +
                "Actualizado y publicado en GitHub en Diciembre de 2023.";
            return saludos;
        }

        #region Obtiene Coordenadas

        /// <summary>
        /// Retorna Latitud
        /// </summary>
        /// <param name="addresspoint"></param>
        /// <returns></returns>
        public double GetCoordinatesLat(string addresspoint)
        {
            using (var client = new WebClient())
            {
                string seachurl = "http://maps.google.com/maps/geo?q='" + addresspoint + "'&output=csv";
                string[] geocodeInfo = client.DownloadString(seachurl).Split(',');
                return (Convert.ToDouble(geocodeInfo[2]));
            }
        }

        /// <summary>
        /// Retorna Longitud.
        /// </summary>
        /// <param name="addresspoint"></param>
        /// <returns></returns>
        public double GetCoordinatesLng(string addresspoint)
        {
            using (var client = new WebClient())
            {
                string seachurl = "http://maps.google.com/maps/geo?q='" + addresspoint + "'&output=csv";
                string[] geocodeInfo = client.DownloadString(seachurl).Split(',');
                return (Convert.ToDouble(geocodeInfo[3]));
            }
        }
        #endregion

        #region Consume Google Maps

        /// <summary>
        /// Devuelve la distancia numérica de conducción entre los códigos postales.
        /// </summary>
        /// <param name="origen">Código Postal Origen.</param>
        /// <param name="destino"></param>
        /// <param name="paisOrigen"></param>
        /// <param name="paisDestino"></param>
        /// <returns></returns>
        public static double ObtenDistancia(string origen, string destino, string paisOrigen, string paisDestino)
        {
            //Se asigna la cadena para solicitud
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origen + "," + paisOrigen + "&destinations=" + destino +
              "," + paisDestino + "&mode=driving&sensor=false&language=es-MX";
            //Se hace la solicitud
            HttpWebRequest solicita = (HttpWebRequest)WebRequest.Create(url);
            //Se obtiene la respuesta
            WebResponse respuesta = solicita.GetResponse();
            //Preparamos todo para obtener el dato requerido
            Stream dataStream = respuesta.GetResponseStream();
            StreamReader streamreader = new StreamReader(dataStream);
            string respuestareader = streamreader.ReadToEnd();
            respuesta.Close();
            //Tenemos el objeto para leer y obtener el dato requerido
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(respuestareader);

            //Leemos el dato y obtenemos el dato requerido
            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                if (xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList distancia = xmldoc.GetElementsByTagName("distance");
                    url = string.Empty;
                    respuesta.Dispose();
                    dataStream.Dispose();
                    streamreader.Dispose();
                    respuestareader = string.Empty;
                    solicita = null;
                    xmldoc = null;
                    //Levantamos la basura
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //Convertimos para obtener solo el número requerido
                    return Convert.ToDouble(distancia[0].ChildNodes[1].InnerText.Replace(" km", " "));
                }
            }
            //Levantamos la basura
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //Evitamos errores
            return 0;
        }

        /// <summary>
        /// devuelve la distancia y duración del recorrido en modo de conducción entre los códigos postales.
        /// </summary>
        /// <param name="origen">Código Postal Origen.</param>
        /// <param name="destino">Código Postal Destino.</param>
        /// <param name="paisOrigen">País donde inicia el recorrido.</param>
        /// <param name="paisDestino">País donde termina el recorrido.</param>
        /// <returns></returns>
        public static string obtenDuracion(string origen, string destino, string paisOrigen, string paisDestino)
        {
            //Se asigna la cadena para solicitud
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origen + "," + paisOrigen + "&destinations=" + destino +
              "," + paisDestino + "&mode=driving&sensor=false&language=es-MX";
            //Se hace la solicitud
            HttpWebRequest solicita = (HttpWebRequest)WebRequest.Create(url);
            //Se obtiene la respuesta
            WebResponse respuesta = solicita.GetResponse();
            //Preparamos todo para obtener el dato requerido
            Stream dataStream = respuesta.GetResponseStream();
            StreamReader streamreader = new StreamReader(dataStream);
            string respuestareader = streamreader.ReadToEnd();
            respuesta.Close();
            //Tenemos el objeto para leer y obtener el dato requerido
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(respuestareader);

            //Leemos el dato y obtenemos el dato requerido
            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                if (xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList duracion = xmldoc.GetElementsByTagName("duration");
                    url = string.Empty;
                    respuesta.Dispose();
                    dataStream.Dispose();
                    streamreader.Dispose();
                    respuestareader = string.Empty;
                    solicita = null;
                    xmldoc = null;
                    //Levantamos la basura
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //Regresamos la cadena contenida
                    return (duracion[0].ChildNodes[1].InnerText);
                }
            }
            //Levantamos la basura
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //Evitamos errores
            return string.Empty;
        }

        /// <summary>
        /// devuelve la distancia y duración del recorrido en modo de conducción entre los códigos postales.
        /// </summary>
        /// <param name="origen">Código Postal Origen.</param>
        /// <param name="destino">Código Postal Destino.</param>
        /// <param name="paisOrigen">País donde inicia el recorrido.</param>
        /// <param name="paisDestino">País donde termina el recorrido.</param>
        /// <param name="distancia">Distancia, en Kms, por recorrer.</param>
        /// <param name="tiempo">Duración del recorrido.</param>
        public static void obtenDuracionDistancia(string origen, string destino, string paisOrigen, string paisDestino, out string distancia, out string tiempo)
        {
            //Se asigna la cadena para solicitud
            string url = @"http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" +
              origen + "," + paisOrigen + "&destinations=" + destino +
              "," + paisDestino + "&mode=driving&sensor=false&language=es-MX";
            //Se hace la solicitud
            HttpWebRequest solicita = (HttpWebRequest)WebRequest.Create(url);
            //Se obtiene la respuesta
            WebResponse respuesta = solicita.GetResponse();
            //Preparamos todo para obtener el dato requerido
            Stream dataStream = respuesta.GetResponseStream();
            StreamReader streamreader = new StreamReader(dataStream);
            string respuestareader = streamreader.ReadToEnd();
            respuesta.Close();
            //Tenemos el objeto para leer y obtener el dato requerido
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(respuestareader);

            //Leemos el dato y obtenemos el dato requerido

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                if (xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList duracion = xmldoc.GetElementsByTagName("duration");
                    XmlNodeList distanciaKm = xmldoc.GetElementsByTagName("distance");
                    url = string.Empty;
                    respuesta.Dispose();
                    dataStream.Dispose();
                    streamreader.Dispose();
                    respuestareader = string.Empty;
                    solicita = null;
                    xmldoc = null;
                    //Levantamos la basura
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //Regresamos la cadena contenida
                    tiempo = duracion[0].ChildNodes[1].InnerText;
                    distancia = distanciaKm[0].ChildNodes[1].InnerText;
                }
                else
                {
                    url = string.Empty;
                    respuesta.Dispose();
                    dataStream.Dispose();
                    streamreader.Dispose();
                    respuestareader = string.Empty;
                    solicita = null;
                    xmldoc = null;
                    //Levantamos la basura
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    tiempo = xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText; // NOT_FOUND
                    distancia = xmldoc.GetElementsByTagName("status")[1].ChildNodes[0].InnerText;  // NOT_FOUND
                }
            }
            else
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                tiempo = xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText;
                distancia = xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText;
            }
        }
        
        #endregion
    }
}
