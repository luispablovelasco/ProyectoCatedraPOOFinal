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

    class Reptiles : Animales
    {

        private string tiporesp; //Los reptiles pueden tener respiracion pulmonar o cutanea (Por medio de la piel)
        private int cantfosas; 

        /*Los reptiles se clasifican me diante la cantidad de fosas temporales en el craneo, pueden ser:
          - Sinapsidos: Con solo 1 fosa temporal
          - Anapsidos: Con ninguna fosa temporal
          - Diapsidos: Con dos fosas temporales
        */

        //Propiedades con sus validaciones

        public string Tiporesp
        {
            get { return tiporesp; }
            set
            {
                tiporesp = value;
                if (tiporesp == "")
                {
                    throw new Exception("Debe ingresar el tipo de respiración del repltil");
                }
            }
        }

        public int Cantfosas
        {
            get { return cantfosas; }
            set
            {
                cantfosas = value;
                if (Convert.ToString(cantfosas) == "")
                {
                    throw new Exception("Ingrese el numero de fosas que posee el reptil por favor");
                }
            }
        }
    }
}
