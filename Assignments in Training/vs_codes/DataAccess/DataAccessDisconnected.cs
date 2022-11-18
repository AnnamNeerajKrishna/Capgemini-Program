using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLib;

namespace DataAccess
    
{
    public class DataAccessDisconnected
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public DataAccessDisconnected()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = new SqlCommand();
            cmd.CommandText = "select * from employee";

            cmd.Connection = con;
            //LAPTOP-SF5JKCA0\SQLEXPRESS
            //Data Source=LAPTOP-SF5JKCA0\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True;
            da = new SqlDataAdapter(cmd);


            ds=new DataSet();
            da.Fill(ds, "employee");
            ds.Tables[0].Constraints.Add("pk1", ds.Tables[0].Columns[0], true);

        }
        public bool AddEmp(employee emp)
        {
            //create a new row on the data set table
            DataRow row =ds.Tables[0].NewRow();
            // specify the values to the columns of tghe new row 
            row[0] = emp.Ecode;
            row[1] = emp.EName;
            row[2] = emp.Salary;
            row[3] = emp.DeptId;


            // add this new row to the Rows of the dataset table

            ds.Tables[0].Rows.Add(row);


            // save changes to data base
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "employee");

            // add primary key in dataset

            
            return true;
        }
        public bool DeleteEmpById(int Ecode)

        {
            DataRow row = ds.Tables[0].Rows.Find(Ecode);
            if (row != null)
            {
                row.Delete();
                /// save to dataset
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employee");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmp(employee emp)
        {
            DataRow row = ds.Tables[0].Rows.Find(emp.Ecode);
            if (row != null)
            {
                // update the value
                row[1] = emp.EName;
                row[2] = emp.Salary;
                row[3] = emp.DeptId;
                /// save to dataset
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employee");
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public List<employee> GetAllEmps()
        {
            List<employee> listEmp = new List<employee>();
            
            // Traverse all the rows in the dataset and add them to the collection
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                employee emp = new employee
                {
                    Ecode = (int)row[0],
                    EName = (string)row[1],
                    Salary = (int)row[2],
                    DeptId = (int)row[3]

                };
                // add the row values to the collection result
                listEmp.Add(emp);
            }
            return listEmp;
        
        }
        public employee GetEmpID(int Ecode)
        {
            employee emp = null;
            
            DataRow row = ds.Tables[0].Rows.Find(Ecode);

            if (row != null)
            {
                 emp = new employee {
                Ecode = (int)row[0],
                EName = (string)row[1],
                Salary = (int)row[2],
                DeptId = (int)row[3]
            };
            }
            return emp;
        }
    }
}
