using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using task_1.Models;
using task_1.ViewsModel;

namespace task_1.Controlers
{
    public class HomeController : Controller
    {
		public List<Games> Games;
		public List<Game_Catagories> Catagories;
		public HomeController()
		{
			Games = new List<Games>()
			{
				new Games
				{
					Id = 1,
					Name="Euro Truck Simulator 2",
					 ReleaseDate=" 18 October 2012",
					 Title="Euro Truck Simulator 2 biznesin idarə edilməsi elementləri ilə yük maşını sürmə simulyatorudur. Oyunçular pul və təcrübə xalları ilə kompensasiya olunmaq üçün yükləri təyin olunmuş yerlərə çatdıraraq, Avropanın açıq dünya nümayişində yük maşınlarını sürürlər .",
					  Price="15.30$",
					  Photo="https://wallpapercave.com/wp/wp2578407.jpg"
				},
				new Games
				{
					Id = 2,
					Name="Euro Truck Simulator 2",
					 ReleaseDate=" 18 October 2012",
					 Title="Euro Truck Simulator 2 biznesin idarə edilməsi elementləri ilə yük maşını sürmə simulyatorudur. Oyunçular pul və təcrübə xalları ilə kompensasiya olunmaq üçün yükləri təyin olunmuş yerlərə çatdıraraq, Avropanın açıq dünya nümayişində yük maşınlarını sürürlər .",
					  Price="15.30$",
					  Photo="https://wallpapercave.com/wp/wp2578407.jpg"
				}

			};
			Catagories = new List<Game_Catagories>()
			{
				new Game_Catagories
				{
					Id= 1,
					Name="dram"
				},
				new Game_Catagories
				{
					Id= 2,
					Name="dram"
				},
				new Game_Catagories
				{
					Id= 3,
					Name="dram"
				}

			};

		}
        public IActionResult Index()
        {
			Common model = new Common()
			{
				Games = Games,
				Catagories = Catagories
			};


            return View(model);
        }
	
    }
	
	
}
