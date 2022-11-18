using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessObject;
namespace BusinessAccessLayer
{
    public class ConfigBAL
    {
        configDAL dal = new configDAL();    
        public bool InsertTOBlogger(configBALobj obj)
        {
            bool status=dal.InsertBlogger(obj);
            return status;
        }
        public bool InsertToBlog(configBALobj obj)
        {
            return dal.InsertBlog(obj);
        }
        public bool ShowBloggerData()
        {
            return dal.ShowBlogger();
        }
        public bool ShowBlogData()
        {
            return dal.ShowBlog();
        }
    }
}
