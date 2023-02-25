using Microsoft.AspNetCore.Mvc;
using task_1.Models;

namespace task_1.Controlers
{
	public class CatagoriesController : Controller
	{
		public List<Game_Catagories> Game_Catagories;
		public CatagoriesController()
        {
			Game_Catagories = new List<Game_Catagories>()
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
        public IActionResult About()
		{


			return View(Game_Catagories);
		}
	}
}
