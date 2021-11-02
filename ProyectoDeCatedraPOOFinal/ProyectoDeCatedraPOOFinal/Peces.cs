using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCatedraPOOFinal
{
    /*
        -----------------------------------------------------------------------
        |   INTEGRANTES DEL EQUIPO:                                            |
        |                                                                      |
        |   - Ayala Acevedo, Diego Javier -------- AA210072                    |
        |   - Alvarado, Anderson Meléndez -------- MA201409                    |
        |   - Elías Pérez, Karletty Carolina ----- EP210584                    |
        |   - Matínez Soto, Adriana Guadalupe ---- MS211714                    |
        |   - Velasco Flores, Luis Pablo --------- VF202313                    |      
        |                                                                      | 
        ------------------------------------------------------------------------
    */

    class Peces : Animales
    {
        //Atributos 

        private int cantaletas;
        private string tipobranqueas; //Solamente existen 2 tipos de branqueas: Externas e Internas


        //Propiedades con Su validación

        public int Cantaletas
        {
            get { return cantaletas; }
            set
            {
                cantaletas = value;
                if (Convert.ToString(cantaletas) == "")
                {
                    throw new Exception("Por vafor ingrese el numero de branqueas del pez");
                }
            }
        }

        public string Tipobranqueas
        {
            get { return tipobranqueas; }
            set
            {
                tipobranqueas = value;
                if (tipobranqueas == "")
                {
                    throw new Exception("Ingrerse el tipo de branqueas del pez");
                }
            }
        }


    }
}
