using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"initial catalog=ADODemo ; data source=CGI-JAVA-006\CGI ; integrated security=true"); //To establish the connection.
            //SqlDataAdapter da = new SqlDataAdapter("select * from Data", con);
            //DataSet sa = new DataSet();
            //da.Fill(sa, "t1");
          //DataTable dt = sa.Tables["t1"];
          //for(int j=0;j<dt.Rows.Count;j++)
                                                                                                                                           //{
                                                                                                                                         //    DataRow dr = dt.Rows[j];
                                                                                                                                         //    for(int i=0;i<dt.Columns.Count;i++)
                                                                                                                                         //    {
                                                                                                                                         //        if (int.Parse(dr[2].ToString()) == 25)
                                                                                                                                         //        {
                                                                                                                                         //            dr[2] = 45;
                                                                                                                                         //        }
                                                                                                                                         //        Console.Write("{0,-20}", dr[i].ToString());
                                                                                                                                         //    }
                                                                                                                                         //    Console.WriteLine();

            //}
            // Console.WriteLine("Enter the details of user:");
            // string name = Console.ReadLine();
            // Console.WriteLine("Enter the details of age:");
            //int n = int.Parse(Console.ReadLine());
            // SqlCommand cmd = new SqlCommand("input set age=@p1 where username=@p2", con);
            // cmd.Parameters.Add("@name", name);
            // cmd.Parameters.Add("@n", n);

            // cmd.ExecuteNonQuery();
            // con.Close;




            //Console.WriteLine("Enter the details of user:");
            //string name = Console.ReadLine();
            //string pass = Console.ReadLine();
            //int a =int.Parse( Console.ReadLine());
            //string c = Console.ReadLine();

            //SqlConnection con = new SqlConnection(@"initial catalog=ADODemo ; data source=CGI-JAVA-006\CGI ; integrated security=true");
            //SqlCommand cmd=new SqlCommand("insert into userinfo values(@n1,@n2,@n3,@n4)")
            //cmd.Parameters.Add("@n1", name);
            //cmd.Parameters.Add("@n2",pass);
            //cmd.Parameters.Add("@n3", a);
            //cmd.Parameters.AddWithValue("@n4", c);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Inserted Successfully");

            //Console.WriteLine("enter username to be deleted");
            //string user_name = Console.ReadLine();
            //con.Open();
            //SqlCommand cmd = new SqlCommand("delete from Data where username=@u1", con);
            //cmd.Parameters.AddWithValue("@u1", user_name);
            //if (cmd.ExecuteNonQuery() > 0)
            //    Console.WriteLine("Record Deleted successfully");

            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Done");

            //Console.WriteLine("enter username to be deleted");
            //string user_name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select count(*) from Data",con);
            int cnt = (int)cmd.ExecuteScalar();
            Console.WriteLine("count of records:" + cnt);
        }
    }
}