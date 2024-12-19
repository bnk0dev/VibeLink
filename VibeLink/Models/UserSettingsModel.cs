using Microsoft.AspNetCore.Mvc;

namespace VibeLink.Models
{
    public class UserSettingsModel : Controller
    {
       
            public string Name { get; set; }
            public string Email { get; set; }
            public bool ReceiveNotifications { get; set; }

    }
}
