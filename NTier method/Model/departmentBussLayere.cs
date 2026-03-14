using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NTier_method.Model
{
    internal class departmentBussLayere
    {
        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select * from department"));
        }
    }
}
