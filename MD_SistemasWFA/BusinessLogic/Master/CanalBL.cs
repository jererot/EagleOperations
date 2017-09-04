using BusinessEntities;
using DataAccess.Master; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Master
{
    public class CanalBL
    {
        CanalDA objCanalDA = new CanalDA();

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals()
        {
            return objCanalDA.GetCanals();
        }

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals2()
        {
            return objCanalDA.GetCanals();
        }
    }
}
