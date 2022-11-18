using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectUpd;
using DataAccessLayerUpd;
namespace BusinessAccessLayerUPd
{
    public class ConfigBAL
    {
        ConfigDAL dal = new ConfigDAL();
        public bool InsertTOBlogger(ConfigBALobj obj)
        {
            bool status = dal.InsertBlogger(obj);
            return status;
        }
        public bool InsertToBlog(ConfigBALobj obj)
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
