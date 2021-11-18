using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class HorarioCitaModels
    {
        int id;
        TimeSpan hora_cita;

        public int Id { get => id; set => id = value; }
        public TimeSpan Hora_cita { get => hora_cita; set => hora_cita = value; }
    }
}
