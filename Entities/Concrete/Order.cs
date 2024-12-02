using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Bir class'ı IEntity ile işaretlediğimizde bu class'ın Database'deki bir
    //veritabanı tablosuna karşılık geldiğini belirtmiş oluruz.
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }


    }
}
