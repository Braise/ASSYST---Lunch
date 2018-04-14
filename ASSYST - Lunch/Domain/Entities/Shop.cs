using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Shop
    {
        [Key]
        public string Guid { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un nom!")]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une ville!")]
        [Display(Name = "Ville")]
        public string City { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un code postal!")]
        [Display(Name = "Code Postal")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une rue!")]
        [Display(Name = "Rue")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un numéro!")]
        [Display(Name = "Numéro")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un numéro de téléphone!")]
        [Display(Name = "Téléphone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un email!")]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une heure de commande!")]
        [Display(Name = "Commander avant")]
        public string OrderBefore { get; set; }

        [Required(ErrorMessage = "Veuillez préciser si le magasin est autorisé!")]
        [Display(Name = "Actif")]
        public bool IsActive { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
