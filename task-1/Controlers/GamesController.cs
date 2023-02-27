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
					Name="Pes 2022",
					 ReleaseDate=" 18 October 2012",
					 Title="What will be in eFootball 2022?\r\nNew Team Building \"Dream Team\"\r\n\r\nThis is a brand-new game mode where you can build your original team by signing players and managers, and compete against users from around the world. In \"Dream Team\", you can handpick and sign players and managers that are consonant with your football ideologies.",
					  Price="15.30$",
					  Photo="https://i.ytimg.com/vi/UJHvFQYIpeY/maxresdefault.jpg"

				},
				new Games
				{
					Id = 3,
					Name="Counter-Strike",
					 ReleaseDate=" 18 October 2012",
					 Title="The game pits two teams, Terrorists and Counter-Terrorists, against each other in different objective-based game modes. The most common game modes involve the Terrorists planting a bomb while Counter-Terrorists attempt to stop them, or Counter-Terrorists attempting to rescue hostages that the Terrorists have captured.",
					  Price="15.30$",
					  Photo="https://cdn.akamai.steamstatic.com/steam/apps/730/capsule_616x353.jpg?t=1641233427"
				},
				new Games
				{
					Id = 4,
					Name="PAYDAY",
					 ReleaseDate=" 18 October 2012",
					 Title="Pay Day comes at the end of the month, and to make it there without going broke, players will have to manage their money wisely. Earn cash, find bargains, sell items for a profit, and be the player with the most cash in the end to win the game.",
					  Price="15.30$",
					  Photo="https://upload.wikimedia.org/wikipedia/en/7/7b/Payday2cover.jpg"
				},
				new Games
				{
					Id = 5,
					Name="FIFA 2022",
					 ReleaseDate=" 18 October 2012",
					 Title="FUT 22 redesigns Division Rivals and FUT Champions to create a more accessible way to test your skills and progress against other players, gives you even more ways to make your club your own with new depths of customisation both on and off the pitch, and introduces FUT Heroes - the return of some of football's most ",
					  Price="15.30$",
					  Photo="https://i0.wp.com/mynintendonews.com/wp-content/uploads/2021/12/fifa_22.jpg?fit=1536%2C864&ssl=1"
				}

			};
		}
        public IActionResult Game()
		{
			return View(Games);
		}
	}
}
