using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using distancePoints;

namespace GetDistance
{
    class ObtenDistancia
    {
        /// <summary>
        /// Aplicación de consola para pruebas de funcionalidad de clase distancePoints.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(distancePoints.getData.Saluda());
            Console.WriteLine("Distancia: " + distancePoints.getData.ObtenDistancia("24645,GUSTAVO DIAZ ORDAZ,CALAKMUL,CAMPECHE", "24000,SAN FRANCISCO DE CAMPECHE CENTRO.,CAMPECHE,CAMPECHE", "MEXICO", "MEXICO").ToString());
            Console.WriteLine("Distancia: " + distancePoints.getData.obtenDuracion("24645,GUSTAVO DIAZ ORDAZ,CALAKMUL,CAMPECHE", "24000,SAN FRANCISCO DE CAMPECHE CENTRO.,CAMPECHE,CAMPECHE", "MEXICO", "MEXICO"));
            string distaancia = string.Empty;
            string tieempo = string.Empty;
            distancePoints.getData.obtenDuracionDistancia(
                "24645,GUSTAVO DIAZ ORDAZ,CALAKMUL,CAMPECHE"
                , "24000,SAN FRANCISCO DE CAMPECHE CENTRO,CAMPECHE,CAMPECHE"
                , "MEXICO", "MEXICO", out distaancia, out tieempo
                );
            Console.WriteLine("Datos del recorrido, distancia: " + distaancia + " tiempo: " + tieempo);
            Console.ReadKey();
        }
    }
}