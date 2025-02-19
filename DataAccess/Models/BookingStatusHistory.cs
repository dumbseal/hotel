﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BookingStatusHistory
    {
        public int BookingStatusHistoryId { get; set; }
        public int? BookingId { get; set; }
        public int? BookingStatusId { get; set; }
        public DateTime? StatusChangeDate { get; set; }

        public virtual Booking? Booking { get; set; }
        public virtual BookingStatus? BookingStatus { get; set; }
    }
}
