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
        //Atributos unicos
        private int cantmamas;
        private bool subcate; //Para saber si son viviparos o no

        //Propiedades con su validación

        public int Cantmamas
        {
            get { return cantmamas; }
            set
            {
                cantmamas = value;
                if (Convert.ToString(cantmamas) == "")
                {
                    throw new Exception("Debe indicar la cantidad de mamas que posee el animal");
                }
            }
        }

    }
}
