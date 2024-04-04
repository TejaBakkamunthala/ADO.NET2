using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCrudOpertionsProgram2
{
    public class Program
    {
      

        static void Main(string[] args)
        {

            Console.WriteLine("hii");
            //  string connection = ConfigurationManager.ConnectionStrings["EmpDB"].ConnectionString;
            try {

                string connection = @"Data Source=LAPTOP-9LF56231\SQLEXPRESS;Initial Catalog=EMPLOYEE;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                Console.WriteLine("Connection Established ");
                //Console.WriteLine("Enter EMPID ");
                //int EMPID = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter EMPLOYEE NAME ");
                //String ENAME = Console.ReadLine();
                //Console.WriteLine("Enter Salary ");
                //int SALARY = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter DEPTNO");
                //int DEPTNO = int.Parse(Console.ReadLine());
                //String insertQuery = "INSERT INTO EMP(EMPID,ENAME,SALARY,DEPTNO) VALUES(" + EMPID + ",'" + ENAME + "'," + SALARY + "," + DEPTNO + ")";
                //SqlCommand cmd = new SqlCommand(insertQuery, conn);
                //cmd.ExecuteNonQuery();

                //Console.WriteLine("Data Inserted Succesfully ");

                //SELECT 
                //Console.WriteLine("Retrive the data");

                //string selectQuery = "SELECT * FROM EMP";

                //SqlCommand cmd2=new SqlCommand(selectQuery,conn);

                //SqlDataReader reader = cmd2.ExecuteReader();

                //while (reader.Read())
                //{
                //    Console.Write(" EMPID\t" + reader.GetValue(0).ToString() + " ");
                //    Console.Write(" ENAME\t" + reader.GetValue(1).ToString() + " ");
                //    Console.Write(" SALARY\t" + reader.GetValue(2).ToString() + " ");
                //    Console.Write(" DEPTNO\t" + reader.GetValue(3).ToString()+"   ");
                //    Console.WriteLine();
                //}
                //reader.Close();


                //UPDATE 

                //Console.WriteLine("Update the table ");
                //Console.WriteLine("Enter the EMPid which you want to be updated ");
                //int EMPID=int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter the updated salary for that id ");
                //int SALARY=int.Parse(Console.ReadLine());

                //String updateQuery="UPDATE EMP SET SALARY="+SALARY+" WHERE EMPID="+EMPID+"";
                //SqlCommand cmd3 = new SqlCommand(updateQuery,conn);
                //cmd3.ExecuteNonQuery();

                //Console.WriteLine("Updated Sucessfully ");


                //DELETE

                Console.WriteLine("DELTE ROW IN EMP TABLE");
                Console.WriteLine("ENTER THE EMP ID WHICH YOU WANT TO BE DELETED ");
                int EMPID=int.Parse(Console.ReadLine());

                string deleteQuery = "DELETE FROM EMP WHERE EMPID="+EMPID+" ";
                SqlCommand cmd4=new SqlCommand(deleteQuery, conn);
                cmd4.ExecuteNonQuery();

                Console.WriteLine("Deleted Successfully ");




                conn.Close();
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }

           

        }
    }
}
