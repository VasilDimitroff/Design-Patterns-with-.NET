using System.Diagnostics;

namespace Facade.Image
{
	public class ImageConverter
	{
		public void Convert(IFormFile image)
		{
			Debug.WriteLine($"- Converting image using {nameof(Convert)} method in {nameof(ImageConverter)} class...");
		}
	}
}
