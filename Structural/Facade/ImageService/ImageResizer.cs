using System.Diagnostics;

namespace Facade.Image
{
	public class ImageResizer
	{
		public void Resize(IFormFile image)
		{
			Debug.WriteLine($"- Resizing image using {nameof(Resize)} method in {nameof(ImageResizer)} class...");
		}
	}
}
