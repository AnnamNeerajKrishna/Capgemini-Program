using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLib;
using DataAccess;

namespace BusinessLayerLib
{
    public class BusinessLAyer
    {
        public bool AddEmp(employee emp)
        {
            //Insert using DAl Layer
            DataAccessDisconnected dal = new DataAccessDisconnected();

            bool status = dal.AddEmp(emp);

            return status;
        }
        public bool DeleteEmpById(int Ecode)
        {
            DataAccessDisconnected dal = new DataAccessDisconnected();

            bool status = dal.DeleteEmpById(Ecode); 

            return status;
           // return true;
        }
        public bool UpdateEmp(employee emp)
        {
            return true;
        }
        public List<employee> GetAllEmps()
        {
            List<employee> listEmp = new List<employee>();
            DataAccessDisconnected dal = new DataAccessDisconnected();

           listEmp=dal.GetAllEmps();    

            return listEmp;

        }
        public employee GetEmpID(int Ecode)
        {
            employee emp = new employee();
            DataAccessDisconnected dll = new DataAccessDisconnected();

            return emp;
        }
    }
}
