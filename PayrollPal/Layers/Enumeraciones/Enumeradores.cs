using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Enumeraciones
{
    public enum Estado
    {
        Activo = 'A',
        Inactivo = 'I'
    }

    public enum CRUD
    {
        Create = 'C',
        Read = 'R',
        Update = 'U',
        Delete = 'D'
    }
}
