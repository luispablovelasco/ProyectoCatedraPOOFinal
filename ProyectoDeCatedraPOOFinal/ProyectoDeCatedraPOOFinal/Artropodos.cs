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

    class Artropodos : Animales
    {
        //Atributos para la clase de anumales Artropodos

        private bool veneno = false; //Esto indicará si el animal posee alguna clase de veneno
        private int cantpatas; 


        //Propiedades con su validación

        public int Cantpatas
        {
            get { return cantpatas; }
            set
            {
                cantpatas = value;
                if (Convert.ToString(cantpatas) == "")
                {
                    throw new Exception("Debe de colocar la cantidad de patas del insecto");
                }
            }
        }

    }
}
