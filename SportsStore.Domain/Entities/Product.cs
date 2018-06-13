using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="Proszę wpisać nazwę produktu")]
        [Display(Name="Nazwa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę wpisać opis produktu")]
        [DataType(DataType.MultilineText), Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Proszę wpisać cenę produktu")]
        [Range(0.01, double.MaxValue, ErrorMessage ="Proszę wpisać nieujemną wartość ceny")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [Display(Name = "Kategoria")]
        [Required(ErrorMessage = "Proszę wpisać kategorię")]
        public string Category { get; set; }

    }
}
