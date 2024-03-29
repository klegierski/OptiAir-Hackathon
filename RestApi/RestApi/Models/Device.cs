﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class Device
    {
        //public int DeviceId { get; set; }
        [Required]
        [Key]
        public string MAC { get; set; }
        //[Required]
        public string Name { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [DefaultValue(false)]
        public bool IsVerified { get; set; } = false;

        public virtual List<Measurement> Measurements { get; set; }

    }
}
