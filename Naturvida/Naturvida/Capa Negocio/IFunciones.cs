using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naturvida.Recursos
{
    public interface IFunciones
    {
        int Registrar();
        bool Actualizar();
        bool Eliminar();
        DataSet Listar();
        DataTable BuscarPorCodigo(int id);
    }
}
