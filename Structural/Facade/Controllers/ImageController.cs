using Facade.Image.ImageUploaderFacade.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Facade.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ImageController(IImageUploaderFacade imageUploaderFacade) : ControllerBase
	{
		private readonly IImageUploaderFacade imageUploaderFacade = imageUploaderFacade;

		[HttpPost]
		[Route("upload-image")]
		public IActionResult Upload(IFormFile imageFile)
		{
			if (imageFile == null || imageFile.Length == 0)
			{
				return BadRequest("File not selected or empty");
			}

			imageUploaderFacade.UploadImage(imageFile);

			return Ok("File uploaded successfully!");
		}
	}
}
