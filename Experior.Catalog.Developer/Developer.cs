using System.Windows.Media;

namespace Experior.Catalog.Developer
{
    public class Developer : Experior.Core.Catalog
    {
        public Developer()
            : base("Developer")
        {
            Simulation = Experior.Core.Environment.Simulation.Physics;

            Common.Mesh = new Experior.Core.Resources.EmbeddedResourceLoader(System.Reflection.Assembly.GetExecutingAssembly());
            Common.Icon = new Experior.Core.Resources.EmbeddedImageLoader(System.Reflection.Assembly.GetExecutingAssembly());

            #region Beginner

            Add(Common.Icon.Get("Sample0"), "Beginner", "Dimensions", Simulation, Create.Sample0);
            Add(Common.Icon.Get("Sample1"), "Beginner", "Position/Orientation", Simulation, Create.Sample1);

            #endregion
        }

        public override ImageSource Logo => Common.Icon.Get("Logo");
    }
}