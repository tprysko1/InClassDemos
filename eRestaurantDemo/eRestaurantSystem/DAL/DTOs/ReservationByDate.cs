using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> origin/master
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
#region Additional Namespaces
using System.Collections; //required by IEnumerable
#endregion

=======
>>>>>>> origin/master
namespace eRestaurantSystem.DAL.DTOs
{
    public class ReservationByDate
    {
        public string Description { get; set; }
<<<<<<< HEAD
        //the rest of the data will be a collection of POCO rows
        //the actual POCO will be defined in the Linq query
=======
>>>>>>> origin/master
        public IEnumerable Reservations { get; set; }
    }
}
