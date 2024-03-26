using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApp7
{
    class Class2
    {
        SqlConnection con;
        
        public Class2()
        {
            con = new SqlConnection("Data Source=technomartserver.database.windows.net;Initial Catalog=TechnoMart1;Persist Security Info=True;User ID=Dilshan;Password=***********");
        }
    }
}
