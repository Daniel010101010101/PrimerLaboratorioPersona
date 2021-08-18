using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidades
{
    class ClsPersona
    {
        private String nombre;
        private String apellido;
        private String cedula;
        private int edad;
        private String sexo;
        private String colordePiel;
        private String colordeOjos;
        private int peso;
        private int altura;
        private String nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string ColordePiel { get => colordePiel; set => colordePiel = value; }
        public string ColordeOjos { get => colordeOjos; set => colordeOjos = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
       
        
    }
}
