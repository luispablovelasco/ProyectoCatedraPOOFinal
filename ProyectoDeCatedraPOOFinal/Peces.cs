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
        //Atributos para la clase de animales Peces
        private int cantAletas;
        private string tipoBranquias; //Solamente existen 2 tipos de branquias: externas e internas

        //Propiedades con su validación
        public int CantAletas
        {
            get { return cantAletas; }
            set
            {
                cantAletas = value;
                if (Convert.ToString(cantAletas) == "")
                {
                    throw new Exception("Debe indicar el número de aletas del pez");
                }
                if (cantAletas < 0)
                {
                    throw new Exception("La cantidad de aletas del pez no puede ser menor a 0");
                }
            }
        }
        public string TipoBranquias
        {
            get { return tipoBranquias; }
            set
            {
                tipoBranquias = value;
                if (tipoBranquias == "")
                {
                    throw new Exception("Debe indicar el tipo de branquias del pez");
                }
            }
        }


    }
}
