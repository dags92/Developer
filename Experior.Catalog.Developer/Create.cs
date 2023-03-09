using Experior.Catalog.Developer.Assemblies.Beginner;
using Experior.Core.Assemblies;

namespace Experior.Catalog.Developer
{
    internal class Common
    {
        public static Experior.Core.Resources.EmbeddedImageLoader Icon;
        public static Experior.Core.Resources.EmbeddedResourceLoader Mesh;
    }

    public class Create
    {
        #region Beginner

        public static Assembly Sample0(string title, string subtitle, object properties)
        {
            var info = new Sample0Info
            {
                name = Assembly.GetValidName("Dimensions Sample "),
                length = 0.4f,
                width = 0.4f,
                height = 0.4f
            };
            var assembly = new Sample0(info);
            return assembly;
        }

        #endregion
    }
}