using Microsoft.AspNetCore.Mvc;
using task_1.Models;

namespace task_1.Controlers
{
	public class GamesController : Controller
	{
		public List<Games> Games;

        public GamesController()
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

				},
				new Games
				{
					Id = 2,
					Name = "Euro Truck Simulator 2",
					ReleaseDate = " 18 October 2012",
					Title = "Euro Truck Simulator 2 biznesin idarə edilməsi elementləri ilə yük maşını sürmə simulyatorudur. Oyunçular pul və təcrübə xalları ilə kompensasiya olunmaq üçün yükləri təyin olunmuş yerlərə çatdıraraq, Avropanın açıq dünya nümayişində yük maşınlarını sürürlər .",
					Price = "15.30$",
					Photo = "https://wallpapercave.com/wp/wp2578407.jpg"
				},
				new Games
				{
					Id = 2,
					Name = "Euro Truck Simulator 2",
					ReleaseDate = " 18 October 2012",
					Title = "Euro Truck Simulator 2 biznesin idarə edilməsi elementləri ilə yük maşını sürmə simulyatorudur. Oyunçular pul və təcrübə xalları ilə kompensasiya olunmaq üçün yükləri təyin olunmuş yerlərə çatdıraraq, Avropanın açıq dünya nümayişində yük maşınlarını sürürlər .",
					Price = "15.30$",
					Photo = "https://wallpapercave.com/wp/wp2578407.jpg"
				}

			};
		}
        public IActionResult Game()
		{
			return View(Games);
		}
	}
}
