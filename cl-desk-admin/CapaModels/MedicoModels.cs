using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class MedicoModels
    {
        int id, id_Empleado, id_Especialidad;
        string dias_De_Llegada;
        TimeSpan hora_Entrada, hora_Salida;

        public int Id { get => id; set => id = value; }
        public string Dias_De_Llegada { get => dias_De_Llegada; set => dias_De_Llegada = value; }
        public TimeSpan Hora_Entrada { get => hora_Entrada; set => hora_Entrada = value; }
        public TimeSpan Hora_Salida { get => hora_Salida; set => hora_Salida = value; }
        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
    }
}
