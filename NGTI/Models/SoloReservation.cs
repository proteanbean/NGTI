﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NGTI.Models
{
    public class SoloReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSoloReservation { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string TimeSlot { get; set; }
        public string Reason { get; set; }
        public string Seat { get; set; }
    }
}

