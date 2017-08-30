using BusinessEntities;
using DataAccess.MST;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MST_BL
{
    public class MSTt04_canal_vtaBL
    {
        MSTt04_canal_vtaDA objMSTt04_canal_vtaDA = new MSTt04_canal_vtaDA();

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals()
        {
            return objMSTt04_canal_vtaDA.GetCanals();
        }

        //(METHOD) RETURN ALL LIST OF CANALES
        public static List<MSTt04_canal_vta> GetCanals2()
        {
            return MSTt04_canal_vtaDA.GetCanals2();
        }      
    }
}
