using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL;

namespace BLL
{
    public class HelperEtudiant
    {
        public List<Etudiant> GetEtudiants()
        {
            contextCommande db = new contextCommande();
            return db.etudiants.ToList();
        }

        public List<Etudiant> GetEtudiantsM()
        {
            contextCommande db = new contextCommande();
            return db.etudiants.Where(a => a.note > 10).ToList();
        }


    }
}
