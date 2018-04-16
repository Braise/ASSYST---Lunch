using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class EditProductViewModel
    {
        public string Guid { get; set; }

        public string GuidShop { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un nom pour le produit!")]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une description pour le produit!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un prix pour le produit!")]
        [Display(Name = "Prix")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Veuillez préciser si le produit est autorisé!")]
        [Display(Name = "Actif")]
        public bool IsActive { get; set; }

        public IEnumerable<Shop> Shops { get; set; }
    }
}