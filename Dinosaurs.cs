using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ken_s_JP1._0.Data
{
    public class Dinosaurs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }


        [ForeignKey("Diet")]
        [Display(Name = "Food Type")]
        public string DietID { get; set; }
        public Exhibits Diet { get; set; }


        [ForeignKey("Territory")]
        public string TerritoryID { get; set; }
        public Exhibits Territory { get; set; }


        [ForeignKey("EID")]
        public int EID { get; set; }
        public Exhibits Exhibits { get; set; }
    }
}
