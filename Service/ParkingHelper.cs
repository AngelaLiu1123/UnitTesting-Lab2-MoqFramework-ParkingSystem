using Microsoft.AspNetCore.Mvc;
using UnitTesting_Lab2_MoqFramework.Data;
using UnitTesting_Lab2_MoqFramework.Models;

namespace UnitTesting_Lab2_MoqFramework.Controllers
{
    public class ParkingHelper : Controller
    {
        private readonly ParkomaticContext db;
       
        public ParkingHelper(ParkomaticContext context)
        {
            db = context;
        }

        public Pass CreatePass(string purchaser, bool premium, int capacity)
        {
            Pass newPass = new Pass();
            newPass.Purchaser = purchaser;
            newPass.Premium = premium;
            newPass.Capacity = capacity;

            db.Passes.Add(newPass);
            db.SaveChanges();

            return newPass;
        }

        public ParkingSpot CreateParkingSpot()
        {
            ParkingSpot newSpot = new ParkingSpot();
            newSpot.Occupied =false;

            db.ParkingSpot.Add(newSpot);
            //bug-fix
            db.SaveChanges();
            return newSpot;
        }
    }

}
