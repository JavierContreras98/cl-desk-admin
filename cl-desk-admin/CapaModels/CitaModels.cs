using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class CitaModels
    {
        int id, id_Paciente, id_Horario, id_Medico;
        string asunto;
        DateTime fecha;

        public int Id { get => id; set => id = value; }
        public int Id_Paciente { get => id_Paciente; set => id_Paciente = value; }
        public int Id_Horario { get => id_Horario; set => id_Horario = value; }
        public int Id_Medico { get => id_Medico; set => id_Medico = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
