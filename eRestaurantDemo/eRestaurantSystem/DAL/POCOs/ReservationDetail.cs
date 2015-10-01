using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

=======
>>>>>>> origin/master
namespace eRestaurantSystem.DAL.POCOs
{
    public class ReservationDetail
    {
<<<<<<< HEAD
        //NOTE; NO validation in these POCO classes
        public string CustomerName {get;set;}
=======
        public string CustomerName { get; set; }
>>>>>>> origin/master
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
    }
}
