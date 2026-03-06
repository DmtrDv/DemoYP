using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lib
{
    public class X3X3Orders
    {
        [DisplayName("ИД")]
        public int orderId {  get; set; }
        [DisplayName("Дата заказа")]
        public DateTime orderDate { get; set; }
        [DisplayName("Дата доставки")]
        public DateTime deliveryDate { get; set; }
        [DisplayName("ИД пункта выдачи")]
        public int pickupPointId { get; set; }
        [DisplayName("Заказчик")]
        public string customerName { get; set; }
        [DisplayName("Код заказа")]
        public int pickupCode { get; set; }
        [DisplayName("Статус заказа")]
        public string status { get; set; }
    }
}
