using BLL;

HelperEtudiant helperEtudiant = new HelperEtudiant();



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