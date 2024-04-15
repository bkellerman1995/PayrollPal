using PayrollPal.Layers.DAL;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPal.Layers.BLL
{
    public class BLLBitacora : IBLLBitacora
    {
        public List<Bitacora> selectALL()
        {
            IDALBitacora dALBitacora = new DALBitacora();
            return dALBitacora.selectALL();
        }
    }
}
