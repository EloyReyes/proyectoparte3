using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGridView
{
    
    internal class PersonaDataObjects
    {
       private List<Persona> listaPersonas = new List<Persona>();

        public PersonaDataObjects()
        {
            Persona p1 = new Persona { Nombre = "Javiel", Emaill = "lavier@emaill.com", 
                Genero = "hombre", Telefono = "2228889993", ImagenGenero = "Assets/icono de hombre.png" };
            Persona p2 = new Persona { Nombre = "Rebecca", Emaill = "rebecca@email.com", 
                Genero = "mujer", Telefono = "2226655447", ImagenGenero = "Assets/icono de mujer.png"};
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
        }
        public List<Persona> listar() 
        {
            return listaPersonas;
        }
    }
}
