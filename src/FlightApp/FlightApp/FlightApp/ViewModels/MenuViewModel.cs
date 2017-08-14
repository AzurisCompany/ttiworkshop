using FlightApp.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class MenuViewModel
    {
        public List<Menu> MenuList { get; set; }

        public MenuViewModel()
        {
            MenuList = new List<Menu>
            {
                new Menu(){Description = "Reservar voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem1.png") },
                new Menu(){Description = "Meus voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem2.png")},
                new Menu(){Description = "Checkin", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem3.png")},
                new Menu(){Description = "Contato", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem6.png")}
            };
        }
    }
}