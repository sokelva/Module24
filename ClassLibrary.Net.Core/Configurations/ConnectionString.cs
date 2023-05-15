using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNETLib.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"DataSource=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;";
    }
}
