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


    abstract class Animales
    {
        // Atributos

        private string nomComun;
        private string nomCientifico;
        private string clasificacion;
        private string habitat;
        private string rutaFoto;
        

        //Propiedades con su validación

        public string NomComun
        {
            get { return nomComun; }
            set
            {
                nomComun = value;
                if (nomComun == "")
                {
                    throw new Exception("Debe indicar el nombre común");
                }
            }
        }

        public string NomCientifico
        {
            get { return nomCientifico; }
            set
            {
                nomCientifico = value;
                if (nomCientifico == "")
                {
                    throw new Exception("Debe indicar el nombre científico-");
                }
            }
        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set
            {
                clasificacion = value;
                if (value == "")
                {
                    throw new Exception("Debe indicar la clasificación");
                }
            }
        }

        public string Habitat
        {
            get { return habitat; }
            set
            {
                habitat = value;
                if (habitat == "")
                {
                    throw new Exception("Debe indicar el habitat");
                }
            }
        }
        public string RutaFoto
        {
            get { return rutaFoto; }
            set
            {
                rutaFoto = value;
                if (rutaFoto == "")
                {
                    throw new Exception("Debe añadir la foto");
                }
            }
        }
        public string guardar(string rutaInicial)
        {
            string folder = rutaInicial + @"\Registros";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }
        public virtual void guardarDatos(string folder)
        {

        }
    }
}
