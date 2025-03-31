using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;

namespace DSVBooking.Pages
{


    public class IndexModel : PageModel
    {
        private readonly RoomService _rs;
        [BindProperty]
        public List<Room> Rooms { get; private set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomService rs)
        {
            _logger = logger;
            _rs = rs;
        }

        public void OnGet()
        {   

        }
    }
}
