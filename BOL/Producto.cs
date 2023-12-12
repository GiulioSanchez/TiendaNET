using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BOL
{
   public  class Producto
    {
        DBAccess conexion= new DBAccess();
        public DataTable listar() 
        {
            return conexion.listarDatos("spu_productis_listar");
        }
    }
}
