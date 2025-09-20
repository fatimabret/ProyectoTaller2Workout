using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout.CapaEntidad
{
    public class Entrenador : Usuario
    {
        //Atributos
        public int id_entrenador { get; set; }
        public string horario_disp { get; set; }
        public string dias_disp { get; set; }
        public string detalles { get; set; }
        public int cupo { get; set; }
        //Constructor
        public Entrenador(string p_nombre, string p_apellido, int p_dni, string p_correo, string p_contrasena, string p_horario_disp, string p_dias_disp, string p_detalles)
            //LLama al constructor de la clase base (Usuario)
            : base(p_nombre, p_apellido, p_dni, p_correo, p_contrasena, 3)//El rol 3 es el de entrenador
        {
            this.horario_disp = p_horario_disp;
            this.dias_disp = p_dias_disp;
            this.detalles = p_detalles;
            this.cupo = 15; //Cupo inicial
            this.id_estado = 1; //Activo por defecto
        }

        public string InfoCompleta
        {
            get { return $"{nombre} {apellido} - {horario_disp} - {dias_disp}"; }
        }

        public Entrenador()
        { 
        
        }
    }
}
