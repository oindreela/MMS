using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADOAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter The username");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter The Password");
            //string pass = Console.ReadLine();
            //SqlConnection con = new SqlConnection
            //    (@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand
            //    ("select count(*) from Data where username=@u1 and password=@u2 ", con);

            //cmd.Parameters.Add("@u1", name);
            //cmd.Parameters.Add("@u2", pass);
            //int cnt = (int)cmd.ExecuteScalar();
            //if (cnt > 0)
            //    Console.WriteLine("Login success");
            //else
            //    Console.WriteLine("Login failed");

            //SqlConnection con = new SqlConnection
            //  (@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from Data",con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows != true)
            //    Console.WriteLine("No data in the table");
            //else
            //{
            //    while (dr.Read())
            //    {
            //        Console.Write(dr[0].ToString() + "\t" + dr[1].ToString());
            //        Console.WriteLine();
            //    }
            //    con.Close();
            //}

            //SqlConnection con = new SqlConnection
            //  (@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //SqlDataAdapter da = new SqlDataAdapter("select * from Data", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "t1");
            //string data = ds.GetXml();
            //Console.WriteLine(data);

            //Console.WriteLine("Enter The employee id");
            //int eid = int.Parse(Console.ReadLine());
            //SqlConnection con = new SqlConnection
            //(@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from Employee where eid=@u1", con);
            //cmd.Parameters.Add("@u1", eid);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.Write(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" + dr[2].ToString());
            //    Console.WriteLine();
            //}

            //SqlConnection con = new SqlConnection
            //(@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("p1",con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Procedure Executed");

            //Console.WriteLine("Enter the values");
            //string name = Console.ReadLine();
            //string pass = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string city = Console.ReadLine();
            //SqlConnection con = new SqlConnection
            //(@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("p2 ", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@p1", name);
            //cmd.Parameters.AddWithValue("@p2", pass);
            //cmd.Parameters.AddWithValue("@p3", age);
            //cmd.Parameters.AddWithValue("@p4", city);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Procedure Executed");

            //SqlConnection con = new SqlConnection
            //(@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //con.Open();
            //Console.WriteLine("Enter the details");
            //string name = Console.ReadLine();
            //string oldpass  = Console.ReadLine();
            //string newpass= Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("p4", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@p1", name);
            //cmd.Parameters.AddWithValue("@p2", oldpass);
            //cmd.Parameters.AddWithValue("@p3", newpass);
            //int cnt=cmd.ExecuteNonQuery();
            //if(cnt>0)
            //     Console.WriteLine("password updated");
            //else
            //    Console.WriteLine("password not updated");



            //Console.WriteLine("Enter Choice:");
            //Console.WriteLine("1.Login");
            //Console.WriteLine("2.Change password");
            //Console.WriteLine("3.Add new user");
            //Console.WriteLine("4.Delete user");
            //int opt = int.Parse(Console.ReadLine());
            //switch(opt)
            //{
            //    case 1:
            //        Console.WriteLine("Enter The username");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("Enter The Password");
            //        string pass = Console.ReadLine();
            //        SqlConnection con = new SqlConnection
            //            (@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand
            //            ("select count(*) from Data where username=@u1 and password=@u2 ", con);
            //        cmd.Parameters.Add("@u1", name);
            //        cmd.Parameters.Add("@u2", pass);
            //        int cnt = (int)cmd.ExecuteScalar();
            //        if (cnt > 0)
            //            Console.WriteLine("Login success");
            //        else
            //            Console.WriteLine("Login failed");
            //        break;

            //    case 2: SqlConnection con1 = new SqlConnection
            //        (@"initial catalog=ADODemo; data source=CGI-JAVA-006\CGI;integrated security=true");
            //        con1.Open();
            //        Console.WriteLine("Enter the details");
            //        string name1 = Console.ReadLine();
            //        string oldpass = Console.ReadLine();
            //        string newpass = Console.ReadLine();
            //        SqlCommand cmd1 = new SqlCommand("p4", con1);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.AddWithValue("@p1", name1);
            //        cmd1.Parameters.AddWithValue("@p2", oldpass);
            //        cmd1.Parameters.AddWithValue("@p3", newpass);
            //        int cnt1 = cmd1.ExecuteNonQuery();
            //        if (cnt1 > 0)
            //            Console.WriteLine("password updated");
            //        else
            //            Console.WriteLine("password not updated");
            //        break;
            //}


        }
    }
}
