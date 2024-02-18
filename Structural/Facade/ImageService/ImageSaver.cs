using System.Diagnostics;

namespace Facade.ImageService
{
	public class ImageSaver
	{
		public void Save(IFormFile file, string path)
		{
			Debug.WriteLine($"- Saving image using {nameof(Save)} method in {nameof(ImageSaver)} class...");
		}
	}
}
