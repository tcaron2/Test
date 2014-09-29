using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel;
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class eRestaurantController
    {
        #region SpecialEvents

        //Get all in a list
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            //interfacing with our Context class
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }

        //Get one by primary Key
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent SpecialEventByEventCode(string eventcode)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.SpecialEvents.Find(eventcode);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void SpecialEvents_Add(SpecialEvent item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                SpecialEvent added = null;
                added = context.SpecialEvents.Add(item);
                // commits the add to the database
                // Evaluate the annotations (validations) on your entity
                // [Required], [StringLength], [Range], ect...
                context.SaveChanges(); 
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update,false)]
        public void SpecialEvents_Update(SpecialEvent item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<SpecialEvent>(context.SpecialEvents.Attach(item)).State 
                    = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void SpecialEvents_Delete(SpecialEvent item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                SpecialEvent exsisting = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(exsisting);
                context.SaveChanges();
            }
        }
        #endregion

        #region Reservations
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> Reservation_List()
        {
            //interfacing with our Context class
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.Reservations.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> ReservationbyEvent(string eventcode)
        {
            using (eRestaurantContext context= new eRestaurantContext())
            {
                return context.Reservations.Where(anItem => anItem.Eventcode == eventcode).ToList();
            }
        }

        #endregion

        #region Waiter

        //Get all in a list
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> Waiter_List()
        {
            //interfacing with our Context class
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.Waiters.ToList();
            }
        }

        //Get one by primary Key
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter WaiterByWaiterID(string waiterid)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                return context.Waiters.Find(waiterid);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Waiters_Add(Waiter item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Waiter added = null;
                added = context.Waiters.Add(item);
                // commits the add to the database
                // Evaluate the annotations (validations) on your entity
                // [Required], [StringLength], [Range], ect...
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Waiters_Update(Waiter item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                context.Entry<Waiter>(context.Waiters.Attach(item)).State
                    = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void Waiters_Delete(Waiter item)
        {
            using (eRestaurantContext context = new eRestaurantContext())
            {
                Waiter exsisting = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(exsisting);
                context.SaveChanges();
            }
        }
        #endregion

    }
}