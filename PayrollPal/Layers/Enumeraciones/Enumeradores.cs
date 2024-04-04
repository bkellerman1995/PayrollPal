using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

    public enum Rol
    {
        Administrador = 1,
        Supervisor = 2,
        Colaborador = 3
    }

    public enum PlanillaEstado
    {
        Activa,
        Inactiva,
        Enviada,
        PorEnviar
    }
}
