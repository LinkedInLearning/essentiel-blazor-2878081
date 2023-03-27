using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Voyages;

namespace VoyagesBack.Controllers
{
    [Authorize]
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
        /// Obtient iste des séjours d'un utilisateur
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <returns>Liste des séjours de l'utilisateur</returns>
        /// <response code="200">Requête effectuée avec succès</response>        
        /// <response code="404">Aucun utilisateur n'a été trouvé avec ce Guid</response>        
        [HttpGet("{uid}")]
        public ActionResult<IEnumerable<SejourDto>> Get(Guid uid)
        {
            var séjours = _data.GetSéjours(uid);

            if (séjours == null)
            {
                return NotFound("Utilisateur non trouvé");
            }
            else
            {
                return Ok(SejourDto.GetSejourDtos(séjours));
            }
        }

        /// <summary>
        /// Obtient le séjour d'un utilisateur d'après l'identifiant de l'utilisateur et du séjour
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <param name="id">Identifiant du séjour</param>
        /// <response code="200">Requête effectuée avec succès</response>        
        /// <response code="404">Aucun utilisateur ou aucun séjour n'a été trouvé avec ce Guid</response>        
        [HttpGet("{uid}/{id}")]
        public ActionResult<SejourDto> Get(Guid uid, Guid id)
        {
            var séjours = _data.GetSéjours(uid);

            if (séjours == null)
            {
                return NotFound("Utilisateur non trouvé");
            }
            else if (!séjours.ContainsKey(id))
            {
                return NotFound("Séjour non trouvé");
            }
            else
            {
                return new SejourDto(séjours[id]);
            }
        }

        /// <summary>
        /// Ajoute un séjour à la liste des séjour d'un utilisateur donné
        /// </summary>
        /// <param name="uid">Identifiant de l'utilisateur</param>
        /// <param name="value">Séjour à ajouter</param>
        [HttpPost("{uid}")]
        public ActionResult Post(Guid uid, [FromBody] SejourDto sejour)
        {
            try
            {
                var id = _data.AjouterSéjour(uid, sejour.GetSéjour());

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