using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class BDGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(" I n t e g r a t e d   S e c u r i t y = S S P I ; P e r s i s t   S e c u r i t y   I n f o = F a l s e ; I n i t i a l   C a t a l o g = A d r i a n a ; D a t a   S o u r c e = D E S K T O P - 7 9 O S Q S U \\ S Q L E X P R E S S 0 1 \r\n \r\n ");
            conexion.Open();

            return conexion;
        }
        
           
        
    }
}
