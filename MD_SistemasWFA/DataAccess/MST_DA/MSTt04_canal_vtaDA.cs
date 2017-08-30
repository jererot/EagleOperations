using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MST
{
    public class MSTt04_canal_vtaDA
    {
        private EagleEntities dbContext = new EagleEntities();

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals() {
            var ListCanales = dbContext.MSTt04_canal_vta.ToList();
            return ListCanales;
        }
        //(METHOD) RETURN ALL LIST OF CANALES
        public static List<MSTt04_canal_vta> GetCanals2()
        {
            List<MSTt04_canal_vta> lstMSTt04_canal_vta = null;
            using (EagleEntities db =  new EagleEntities()) {
                lstMSTt04_canal_vta = (from u in db.MSTt04_canal_vta select u).ToList();
            }
            return lstMSTt04_canal_vta;
        }
    }
}
