using Microsoft.AspNetCore.Mvc;
using Voyages;

namespace VoyagesBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SejoursController : ControllerBase
    {
        private IDataContext _data;

        public SejoursController(IDataContext data)
        {
            _data = data;
        }

        /// <summary>
        /// Obtient iste des s�jours d'un utilisateur
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <returns>Liste des s�jours de l'utilisateur</returns>
        /// <response code="200">Requ�te effectu�e avec succ�s</response>        
        /// <response code="404">Aucun utilisateur n'a �t� trouv� avec ce Guid</response>        
        [HttpGet("{uid}")]
        public ActionResult<IEnumerable<SejourDto>> Get(Guid uid)
        {
            var s�jours = _data.GetS�jours(uid);

            if (s�jours == null)
            {
                return NotFound("Utilisateur non trouv�");
            }
            else
            {
                return Ok(SejourDto.GetSejourDtos(s�jours));
            }
        }

        /// <summary>
        /// Obtient le s�jour d'un utilisateur d'apr�s l'identifiant de l'utilisateur et du s�jour
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <param name="id">Identifiant du s�jour</param>
        /// <response code="200">Requ�te effectu�e avec succ�s</response>        
        /// <response code="404">Aucun utilisateur ou aucun s�jour n'a �t� trouv� avec ce Guid</response>        
        [HttpGet("{uid}/{id}")]
        public ActionResult<SejourDto> Get(Guid uid, Guid id)
        {
            var s�jours = _data.GetS�jours(uid);

            if (s�jours == null)
            {
                return NotFound("Utilisateur non trouv�");
            }
            else if (!s�jours.ContainsKey(id))
            {
                return NotFound("S�jour non trouv�");
            }
            else
            {
                return new SejourDto(s�jours[id]);
            }
        }

        /// <summary>
        /// Ajoute un s�jour � la liste des s�jour d'un utilisateur donn�
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <param name="value">S�jour � ajouter</param>
        [HttpPost("{uid}")]
        public ActionResult Post(Guid uid, [FromBody] SejourDto sejour)
        {
            try
            {
                var id = _data.AjouterS�jour(uid, sejour.GetS�jour());

                sejour.Id = id;
                return Created($"{Request.Scheme}://{Request.Host}{Request.Path}/{id}", sejour);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}