using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class MunicipioModels
    {
        int id, id_departamento;
        string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
    }
}
