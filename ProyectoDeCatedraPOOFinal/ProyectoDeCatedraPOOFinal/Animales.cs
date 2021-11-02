using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCatedraPOOFinal
{
    /*
        INTEGRANTES DEL EQUIPO

            - Ayala Acevedo, Diego Javier -------- AA210072
            - Alvarado, Anderson Meléndez -------- MA201409
            - Elías Pérez, Karletty Carolina ----- EP210584
            - Matínez Soto, Adriana Guadalupe ---- MS211714
            - Velasco Flores, Luis Pablo --------- VF202313

    */


    abstract class Animales
    {
        // Atributos

        private string nomcomun;
        private string nomcientifico;
        //Espacio para el nombre de la variable para la imagen (RECUERDE PONERLA PRIVADA "private")
        private string clasi;
        private string habitat;
        

        //Propiedades con su validación

        public string Nomcomun
        {
            get { return nomcomun; }
            set
            {
                nomcomun = value;
                if (nomcomun == "")
                {
                    throw new Exception("Debe llenar el campo -Nombre común-");
                }
            }
        }

        public string Nomcinetifico
        {
            get { return nomcientifico; }
            set
            {
                nomcientifico = value;
                if (nomcientifico == "")
                {
                    throw new Exception("Debe de llenar el campo -Nombre Cientifico-");
                }
            }
        }

        public string Clasi
        {
            get { return clasi; }
            set
            {
                clasi = value;
                if (clasi == "")
                {
                    throw new Exception("Debe de llenar el campo -Clasificación-");
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
                    throw new Exception("Debe de llenar el campo -Habitat-");
                }
            }
        }

    }
}
