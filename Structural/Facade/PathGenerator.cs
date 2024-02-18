using System.Diagnostics;

namespace Facade
{
    public class PathGenerator
    {
        public string GeneratePath(string fileName)
        {
            Debug.WriteLine($"- Generating path using {nameof(GeneratePath)} in {nameof(PathGenerator)} class...");
            return "generated-path-to-save-image";
        }
    }
}
