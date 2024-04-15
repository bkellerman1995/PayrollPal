using PayrollPal.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Interfaces
{
    public interface IBLLBitacora
    {
        List<Bitacora> selectALL();
    }
}
