using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Model;
using System.Linq;
using WebApplicationDemoAPI.Models;

namespace WebApplicationDemoAPI.Controllers
{
    [Route("etudiant")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {


        [HttpGet(Name = "GetEtudiants")]
        public IEnumerable<EtudiantModel> Get()
        {
            BLL.HelperEtudiant helper = new BLL.HelperEtudiant();
            var list = (from a in helper.GetEtudiants()
                       select new EtudiantModel
                       
                       { 
                           nom = a.nom, prenom  = a.prenom
                       
                       })
                       
                       .ToArray();


            return list.ToArray();
            
        }


        //[HttpGet(Name = "Get/{id}")]
        //public Etudiant Get(int id)
        //{
        //    BLL.HelperEtudiant helper = new BLL.HelperEtudiant();
        //    return helper.GetEtudiant(id);

        //}


        //[HttpPost(Name = "PostEtudiants")]
        //public IEnumerable<Etudiant> Post( )
        //{
        //    BLL.HelperEtudiant helper = new BLL.HelperEtudiant();
        //    return helper.GetEtudiants().ToArray();

        //}

    }
}
