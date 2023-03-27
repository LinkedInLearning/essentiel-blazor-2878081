using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Voyages;

namespace VoyagesBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoyagesController : ControllerBase
    {
        private readonly ILogger<VoyagesController> _logger;
        private readonly IDataContext _data;

        public VoyagesController(ILogger<VoyagesController> logger, IDataContext data)
        {
            _logger = logger;
            _data = data;
        }

        /// <summary>
        /// Obtient la liste des voyages disponibles.
        /// </summary>
        /// <returns>Liste d'instances de Voyage</returns>
        /// <response code="200">Requête effectuée avec succès</response>        
        [HttpGet]
        public IEnumerable<VoyageDto> Get() => VoyageDto.GetVoyageDtos(_data.Voyages);
    }
}
