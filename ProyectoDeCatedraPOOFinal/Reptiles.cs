using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private string cantFosas;
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

        public string CantFosas
        {
            get { return cantFosas; }
            set
            {
                cantFosas = value;
                if (cantFosas == "")
                {
                    throw new Exception("Debe indicar el número de fosas que posee el reptil");
                }
            }
        }
        public override void guardarDatos(string folder)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(folder, this.NomComun + ".txt"));
                sw.WriteLine(this.NomComun);
                sw.WriteLine(this.NomCientifico);
                sw.WriteLine(this.Clasificacion);
                sw.WriteLine(this.Habitat);
                sw.WriteLine(this.RutaFoto);
                sw.WriteLine(this.TipoResp);
                sw.WriteLine(this.CantFosas);
                sw.WriteLine("reptil");
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
