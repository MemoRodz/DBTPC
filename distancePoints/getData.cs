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
        public static string Saluda()
        {
            string saludos = "Creado por: Guillermo Rodríguez." + Environment.NewLine +
                "Fecha: 05/mayo/2016." + Environment.NewLine + "Para Poryectos de Portafolio, Winform." + Environment.NewLine +
                "Actualizado y publicado en GitHub en Diciembre de 2023.";
            return saludos;
        }
    }
}
