using BLL;
using DAL.Model;

HelperEtudiant helperEtudiant = new HelperEtudiant();


#region "Création etudiant"

Etudiant obj = new Etudiant()
{ 
    dateCreation = DateTime.Now,
    nom = "JAWAHIR", prenom = "Sanaa", note = 18, _idGroup = 1
};
helperEtudiant.ajouterEtudiant(obj);
#endregion


Console.WriteLine("La liste des etudiants : ");
foreach (var item in helperEtudiant.GetEtudiants())
{
    Console.WriteLine(item.nom);
}



Console.WriteLine("La liste des etudiants M: ");
foreach (var item in helperEtudiant.GetEtudiantsM())
{
    Console.WriteLine(item.nom);
}


Console.WriteLine("La liste des etudiants Group LICDA : ");
foreach (var item in helperEtudiant.GetEtudiantsByGroup(1))
{
    Console.WriteLine(item.nom);
}