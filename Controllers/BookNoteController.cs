using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Papyrus_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookNoteController : ControllerBase
    {
        private readonly ILogger<BookNoteController> _logger;

        public BookNoteController(ILogger<BookNoteController> logger)
        {
            _logger = logger;
        }
    }
}
