using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NTier_method.Model
{
    internal class studentBussLayer
    {
        public static DataTable getall()
        {
            return DBLayer.select(new SqlCommand("select * from student"));
        }

        public static DataTable getbyid(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from student where St_Id =@id");
            cmd.Parameters.AddWithValue("@id", id);
            return DBLayer.select(cmd);
        }

        public static int add(string fname,string lname, int age, string address, int deptid)
        {
            SqlCommand cmd = new SqlCommand("insert into Student(St_Fname,St_Lname,St_Address,St_Age,Dept_Id) values(@St_Fname,@St_Lname,@St_Address,@St_Age,@Dept_Id)");
            cmd.Parameters.AddWithValue("@St_Fname", fname);
            cmd.Parameters.AddWithValue("@St_Lname", lname);
            cmd.Parameters.AddWithValue("@St_Address", address);
            cmd.Parameters.AddWithValue("@St_Age", age);
            cmd.Parameters.AddWithValue("@Dept_Id", deptid);

            return DBLayer.DML(cmd);
        }

        public static int update(int id, string fname, string lname, int age, string address, int deptid)
        {
            SqlCommand cmd = new SqlCommand("update Student set St_Fname=@St_Fname,St_Lname=@St_Lname ,St_Address=@St_Address,St_Age=@St_Age ,Dept_Id=@Dept_Id where St_Id=@St_Id");
            cmd.Parameters.AddWithValue("@St_Id", id);
            cmd.Parameters.AddWithValue("@St_Fname", fname);
            cmd.Parameters.AddWithValue("@St_Lname", lname);
            cmd.Parameters.AddWithValue("@St_Address", address);
            cmd.Parameters.AddWithValue("@St_Age", age);
            cmd.Parameters.AddWithValue("@Dept_Id", deptid);

            return DBLayer.DML(cmd);
        }

        public static int remove(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from student where St_Id =@St_Id");
            cmd.Parameters.AddWithValue("@St_Id", id);
            return DBLayer.DML(cmd);
        }
    

}
}
