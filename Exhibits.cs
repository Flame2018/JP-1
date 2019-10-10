using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ken_s_JP1._0.Data
{
    public class Exhibits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }

        [Display(Name = "Capacity")]
        public int Cap { get; set; }

        [Display(Name = "Food Type")]
        public string Diet { get; set; }

        public string Territory { get; set; }

        [InverseProperty("Diet")]
        public ICollection<Dinosaurs> DietEx { get; set; }
        [InverseProperty("Territory")]
        public ICollection<Dinosaurs> TerritoryEx { get; set; }
        [InverseProperty("EID")]
        public ICollection<Dinosaurs> EIDEx { get; set; }
    }
}
