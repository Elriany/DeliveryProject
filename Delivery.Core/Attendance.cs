using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public Guid DeliveryId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LeaveDate { get; set; }
        public Delivery Delivery { get; set; }
    }
}
