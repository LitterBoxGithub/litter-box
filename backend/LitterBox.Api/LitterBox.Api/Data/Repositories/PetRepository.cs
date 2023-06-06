using LitterBox.Api.Data;
using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using Microsoft.Extensions.Logging;

namespace LitterBox.Api.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly ILogger<PetRepository> _logger;

        private readonly LitterBoxContext _ctx;

        public PetRepository(ILogger<PetRepository> logger, LitterBoxContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
    }
}
