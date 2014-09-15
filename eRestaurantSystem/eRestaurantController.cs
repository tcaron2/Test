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

namespace ClassLibrary1.BLL
{
    [DataObject]
    public class eRestaurantController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            //interfacing with out Context Class
            using(eRestaurantContext context = new eRestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
    }
}
