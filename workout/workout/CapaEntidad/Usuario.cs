using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Usuario
    {
        //Atributos
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public int id_estado { get; set; }
        public int id_rol { get; set; }

        //Constructor
        public Usuario(string p_nombre, string p_apellido, int p_dni, string p_correo, string p_contrasena,int p_id_rol) { 
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.dni = p_dni;
            this.correo = p_correo;
            this.contrasena = p_contrasena;
            this.id_estado = 1; //Activo por defecto
            this.id_rol = p_id_rol;
        }
    }
}