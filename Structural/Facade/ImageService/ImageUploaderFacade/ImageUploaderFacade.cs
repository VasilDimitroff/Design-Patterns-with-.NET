using Facade.Image.ImageUploaderFacade.Interface;
using Facade.ImageService;

namespace Facade.Image.ImageUploaderFacade
{
	public class ImageUploaderFacade : IImageUploaderFacade
	{
		private readonly PathGenerator pathGenerator = new PathGenerator();
		private readonly ImageConverter imageConverter = new ImageConverter();
		private readonly ImageResizer imageResizer = new ImageResizer();
		private readonly ImageSaver imageSaver = new ImageSaver();

		public void UploadImage(IFormFile image)
		{
			imageConverter.Convert(image);
			imageResizer.Resize(image);
			var path = pathGenerator.GeneratePath(image.FileName);
			imageSaver.Save(image, path);
		}
	}
}
