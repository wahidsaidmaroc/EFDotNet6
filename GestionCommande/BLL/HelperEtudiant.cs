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
        contextCommande db = new contextCommande();
        public List<Etudiant> GetEtudiants()
        {
    
            return db.etudiants.OrderBy(a => a.nom).ToList();
        }

        public List<Etudiant> GetEtudiantsM()
        {
            return db.etudiants.Where(a => a.note > 10).ToList();
        }

        public List<Etudiant> GetEtudiantsByGroup(int id)
        {
            return db.etudiants.Where(a => a._idGroup == id ).ToList();
        }

        public int ajouterEtudiant(Etudiant obj)
        {
            db.etudiants.Add(obj);
            db.SaveChanges();
            return obj.idEtudiant;

        }


    }
}
