using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayerLirbary;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerLibrary
{
    public class CategoryDataAccess
    {
        public bool InsertCategory(CategoryBAL category)
        {
            bool operationStatus = false;
            SqlConnection cn = new SqlConnection("Data Source=SPD;Integrated Security=true;Initial Catalog=northwind");
            try
            {


                
                SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertCategory]",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CatName", category.CategoryName);
                cmd.Parameters.AddWithValue("@CatDesc", category.CatDesc);
                cn.Open();
                cmd.ExecuteNonQuery();
                operationStatus = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                
                    }
            return operationStatus;
        }
        public bool UpdateCategory(CategoryBAL category)
        {
            return true;
        }
        public bool DeleteCategory(int categoryid)
        {
            return true;
        }
        public CategoryBAL FindCategory(int catid)
        {
            CategoryBAL c = new CategoryBAL();
            SqlConnection cn = new SqlConnection("Data Source=SPD;Integrated Security=true;Initial Catalog=northwind");
            try
            {
                //fn_ShowListCategories
                SqlCommand cmd = new SqlCommand("select * from [dbo].[fn_FindCategory](@Catid)", cn);

                cmd.Parameters.AddWithValue("@Catid", catid);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    c.CategoryID = catid;
                    c.CategoryName = dr[0].ToString();
                    c.CatDesc = dr[1].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }


                return c;
        }
        public List<CategoryBAL> ShowCategories()
        {
            List<CategoryBAL> list = new List<CategoryBAL>();
            SqlConnection cn = new SqlConnection("Data Source=SPD;Integrated Security=true;Initial Catalog=northwind");
            try
            {
                //fn_ShowListCategories
                SqlCommand cmd = new SqlCommand("select * from [dbo].[fn_ShowListCategories]()", cn);
                cn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    CategoryBAL b = new CategoryBAL();
                    b.CategoryID = Convert.ToInt32(dr[0]);
                    b.CategoryName = dr[1].ToString();
                    b.CatDesc = dr[2].ToString();
                    list.Add(b);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                cn.Close();
                cn.Dispose();
            }
                return list;
        }

    }
}
