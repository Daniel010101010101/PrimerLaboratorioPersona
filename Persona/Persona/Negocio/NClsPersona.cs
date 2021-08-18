using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
       

        public String Hablar(ClsPersona persona)
        {
            return "La Persona " + persona.Nombre + " esta hablando sobre la segunda guerra mundial ";
        }
        public String Caminar(ClsPersona persona)
        {
            return "La Persona " + persona.Nombre + " esta caminando por el barrio ";
        }
        public String Reir(ClsPersona persona)
        {
            return "La Persona " + persona.Nombre + " esta riendo con Franklin ";
        }
        public String Observar(ClsPersona persona)
        {
            return "La Persona " + persona.Nombre + " esta observando a su Crush UwU ";
        }

    }
}
