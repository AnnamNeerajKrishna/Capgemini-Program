using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using AirwaysDataAccessLayer;

namespace AirwaysBusinessAccessLayer
{
    public class AirwaysBusinessAccess
    {
       
        public bool AddUser(LoginEntity k)
        {
            AirwaysDataAccess a = new AirwaysDataAccess();
            return a.AddUser(k);
        }
        public bool UserLogin(LoginEntity k)
        {
            AirwaysDataAccess a = new AirwaysDataAccess();


            return a.UserLogin(k);
        }
        public void Booking(flight k)
        {
            AirwaysDataAccess a = new AirwaysDataAccess();

            a.Booking(k);

        }
        public void CancelTickets(string PN)
        {
            AirwaysDataAccess a = new AirwaysDataAccess();

            a.CancelTickets(PN);
        }
        public void BookingStatus(string PN)
        {
            AirwaysDataAccess a = new AirwaysDataAccess();


            a.BookingStatus(PN);
        }

       /* public void ChangeTimings()
        {
            AirwaysDataAccess a = new AirwaysDataAccess();

            a.ChangeTimings();
        }*/
    }
}
