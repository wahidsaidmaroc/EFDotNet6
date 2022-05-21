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

        public Etudiant GetEtudiant(int id)
        {
            return db.etudiants.Find(id);
        }



        public bool modifierEtudiant(Etudiant objNew)
        {

            var objOld = db.etudiants.Find(objNew.idEtudiant);
            objOld.nom = objNew.nom;
            objOld.prenom = objNew.prenom;
            objOld.note = objNew.note;
            db.SaveChanges();
            return true;
        }


        public bool supperimerEtudiant(int id)
        {
            var objOld = db.etudiants.Find(id);
            db.etudiants.Remove(objOld);
            db.SaveChanges();
            return true;
        }

    }
}
