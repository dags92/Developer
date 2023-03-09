//using System;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Xml.Serialization;
//using Experior.Core.Assemblies;
//using Experior.Core.Parts;

//namespace Experior.Catalog.Developer.Assemblies.Beginner
//{
//    public class Sample1 : Experior.Core.Assemblies.Assembly
//    {
//        #region Fields

//        private readonly Sample1Info _info;

//        private readonly Experior.Core.Parts.Box _staticBox, _movableBox;

//        #endregion

//        #region Constructor

//        public Sample1(Sample1Info info) : base(info)
//        {
//            _info = info;

//            _staticBox = new Experior.Core.Parts.Box(Colors.Wheat, 0.2f, 0.2f, 0.2f);
//            Add(_staticBox);
//            Experior.Core.Environment.InvokeUiAction();
//            _movableBox = new Experior.Core.Parts.Box(Colors.Orange, 0.2f, 0.2f, 0.2f);
//            Add(_movableBox);
//        }

//        #endregion

//        #region Public Properties

//        public override string Category => "Developer - Beginner";

//        public override ImageSource Image => Common.Icon.Get("Sample1");

//        #endregion

//        #region Public Methods

//        public override void KeyDown(KeyEventArgs e)
//        {
//            base.KeyDown(e);
//        }

//        public override void Refresh()
//        {
//        }

//        #endregion
//    }

//    [Serializable, XmlInclude(typeof(Sample1Info)), XmlType(TypeName = "Experior.Catalog.Developer.Assemblies.Beginner.Sample1Info")]
//    public class Sample1Info : Experior.Core.Assemblies.AssemblyInfo
//    {

//    }
//}
