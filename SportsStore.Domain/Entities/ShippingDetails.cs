using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="Proszę podać imię i nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres.")]
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Proszę podać województwo.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Proszę podać kod pocztowy.")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Proszę podać kraj.")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

    }
}
