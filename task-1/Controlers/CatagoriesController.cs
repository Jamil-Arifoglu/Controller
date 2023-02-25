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
					Name="Simulator",
					Photo="https://dw0i2gv3d32l1.cloudfront.net/uploads/stage/stage_image/74408/optimized_large_thumb_stage.jpg"
				},
				new Game_Catagories
				{
					Id= 2,

					Name="dram",
					Photo="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbyjEu-DUXcWOAlioM_O2k5nlYxYFsLcgoQ2UqWffyAUMm_UsWsR61IbiKzkLfl_HN8uI&usqp=CAU"

				},
				new Game_Catagories
				{
					Id= 3,
					Name="dram",
					Photo="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJtPJbLfzAW2v-Ah6kXyiUBn0kv_FpmIXvPxB2omeCF2t8F4LIAa_OPlefhefmmOXrAlI&usqp=CAU"

				}

			};
		}
        public IActionResult List()
		{


			return View(Game_Catagories);
		}
	}
}
