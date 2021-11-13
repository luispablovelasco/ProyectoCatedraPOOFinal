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
        //Atributos para la clase de animales Reptiles
        private string tipoResp; //Los reptiles pueden tener respiración pulmonar o cutánea (por medio de la piel)
        private int cantFosas; 
        /*Los reptiles se clasifican mediante la cantidad de fosas temporales en el craneo, pueden ser:
          - Sinápsidos: Con solo 1 fosa temporal
          - Anápsidos: Con ninguna fosa temporal
          - Diápsidos: Con dos fosas temporales
        */

        //Propiedades con sus validaciones
        public string TipoResp
        {
            get { return tipoResp; }
            set
            {
                tipoResp = value;
                if (tipoResp == "")
                {
                    throw new Exception("Debe indicar el tipo de respiración del reptil");
                }
            }
        }

        public int CantFosas
        {
            get { return cantFosas; }
            set
            {
                cantFosas = value;
                if (Convert.ToString(cantFosas) == "")
                {
                    throw new Exception("Debe indicar el número de fosas que posee el reptil");
                }
                if (cantFosas < 0)
                {
                    throw new Exception("La cantidad de fosas temporales del reptil no puede ser menor a 0");
                }
            }
        }
    }
}
