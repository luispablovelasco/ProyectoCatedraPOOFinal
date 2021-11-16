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

    class Artropodos : Animales
    {
        //Atributos para la clase de animales Artrópodos
        private string tiposApendices; 
        /*Los tipos de apéndices pueden ser:
            antenas, antenulas, gnatopodios, hileras, peines, labio,
            mandíbulas, maxilas, maxilípedos, masillas, ovejeros, patas,
            pedipalpos, periópodos, leopoldos, quelíceros, quilíferos,
            toracópodos, uro podios, abdómenes
         */
        private int cantApendices; 


        //Propiedades con su validación
        public int CantApendices
        {
            get { return cantApendices; }
            set
            {
                cantApendices = value;
                if (Convert.ToString(cantApendices) == "")
                {
                    throw new Exception("Debe indicar la cantidad de apéndices del insecto");
                }
                if (cantApendices < 0)
                {
                    throw new Exception("La cantidad de apéndices no puede ser menor a 0");
                }
            }
        }
        public string TiposApendices
        {
            get { return tiposApendices; }
            set
            {
                tiposApendices = value;
                if (Convert.ToString(tiposApendices) == "")
                {
                    throw new Exception("Debe indicar el tipo de apéndices del insecto");
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
                sw.WriteLine(this.CantApendices);
                sw.WriteLine(this.TiposApendices);
                sw.WriteLine("artropodo");
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
