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
        public override void guardarDatos (string folder)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(folder, this.NomComun + ".txt"));
                sw.WriteLine(this.NomComun);
                sw.WriteLine(this.NomCientifico);
                sw.WriteLine(this.Clasificacion);
                sw.WriteLine(this.Habitat);
                sw.WriteLine(this.RutaFoto);
                sw.WriteLine(this.cantMamas);
                sw.WriteLine(this.colorPelo);
                sw.WriteLine("mamifero");
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
