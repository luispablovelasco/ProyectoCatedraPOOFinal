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

    class Mamiferos : Animales
    {
        //Atributos para la clase de animales Mamíferos
        private int cantMamas;
        private string colorPelo; //Para los que aplique

        //Propiedades con su validación
        public int CantMamas
        {
            get { return cantMamas; }
            set
            {
                cantMamas = value;
                if (Convert.ToString(cantMamas) == "")
                {
                    throw new Exception("Debe indicar la cantidad de mamas del mamífero");
                }
                if(cantMamas <= 0)
                {
                    throw new Exception("La cantidad de mamas del mamífero debe ser mayor a 0");
                }
            }
        }
        public string ColorPelo
        {
            get { return colorPelo; }
            set
            {
                colorPelo = value;
                if (Convert.ToString(colorPelo) == "")
                {
                    throw new Exception("Debe indicar el color del pelo del mamífero");
                }
            }
        }
    }
}
