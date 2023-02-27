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

					Name="FPS games",
					Photo="https://thumbs.dreamstime.com/b/illustration-vector-graphic-fps-shooter-game-logo-fps-shooter-game-logo-design-216860158.jpg"

				},
				new Game_Catagories
				{
					Id= 3,
					Name="Sport",
					Photo="https://i.pinimg.com/736x/80/32/7b/80327b25c6548d6375c55a3ffa44a726.jpg"

				}

			};
		}
        public IActionResult List()
		{


			return View(Game_Catagories);
		}
	}
}
