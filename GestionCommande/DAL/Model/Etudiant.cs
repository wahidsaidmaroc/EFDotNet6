using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    [Table(name: "T_Etudiant")]
    public class Etudiant
    {

        [Key]
        [Column(name:"id")]
        public int idEtudiant { get; set; }
        public DateTime dateCreation { get; set; }
        public string? nom { get; set; }
        public string? prenom { get; set; }
        public decimal note { get; set; }

    }
}
