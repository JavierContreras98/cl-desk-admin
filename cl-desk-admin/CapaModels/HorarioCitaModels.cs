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
        string hora_cita;

        public int Id { get => id; set => id = value; }
        public string Hora_cita { get => hora_cita; set => hora_cita = value; }
    }
}
