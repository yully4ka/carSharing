//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarShareMVC6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Route
    {

        public int RouteID { get; set; }

        [Display(Name = "Departing from")]
        public string DepartingPoint { get; set; }

        [Display(Name = "Arriving to")]
        public string ArrivingPoint { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public System.DateTime DepartingDate { get; set; }

        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        public System.DateTime DepartingTime { get; set; }

        [Display(Name = "Free spots")]
        public int FreeSpots { get; set; }

        [Display(Name = "Driver's name")]
        public string Driver { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
    }
}
