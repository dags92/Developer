using System;
using System.Numerics;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using Experior.Core.Mathematics;
using Experior.Interfaces;

namespace Experior.Catalog.Developer.Assemblies.Beginner
{
    public class Sample1 : Experior.Core.Assemblies.Assembly
    {
        #region Fields

        private readonly Sample1Info _info;

        private readonly Experior.Core.Parts.Box _staticBox, _movableBox;

        #endregion

        #region Constructor

        public Sample1(Sample1Info info) : base(info)
        {
            _info = info;

            _staticBox = new Experior.Core.Parts.Box(Colors.Wheat, _info.length, _info.height, _info.width);
            Add(_staticBox);

            _movableBox = new Experior.Core.Parts.Box(Colors.Orange, _info.length, _info.height, _info.width);
            Add(_movableBox, new Vector3(0.5f, 0f, 0f));
        }

        #endregion

        #region Public Properties

        public override string Category => "Developer - Beginner";

        public override ImageSource Image => Common.Icon.Get("Sample1");

        #endregion

        #region Public Methods

        public override void KeyDown(KeyEventArgs e)
        {
            var deltaX = 0.2f;
            var deltaAngle = 5f.ToRadians();

            switch (e.Key)
            {
                case Key.W:
                    _movableBox.LocalPosition += new Vector3(deltaX, 0, 0);
                    break;
                case Key.S:
                    _movableBox.LocalPosition -= new Vector3(deltaX, 0, 0);
                    break;
                case Key.Z:
                    _movableBox.LocalYaw += deltaAngle;
                    break;
                case Key.X:
                    _movableBox.LocalRoll += deltaAngle;
                    break;
                case Key.C:
                    _movableBox.LocalPitch += deltaAngle;
                    break;
                case Key.V:
                    Yaw += deltaAngle;
                    break;
            }
        }

        public override void Inserted()
        {
            base.Inserted();

            var message = "--------------------------------------------------------------------------------------------" +
                          "\n Sample 1" +
                          "\n Objective: modification of Local/Global Position and Local/Global Pitch, Yaw, and Roll" +
                          "\n 1. Select the component and press any of the following keys:" +
                          "\n   W to move forward" +
                          "\n   S to move backward" +
                          "\n   Z to rotate (LocalYaw)" +
                          "\n   X to rotate (LocalRoll)" +
                          "\n   C to rotate (LocalPitch)" +
                          "\n   V to rotate (Yaw)" +
                          "\n 2. Reset the scene using CTRL + R to return to default values" +
                          "\n --------------------------------------------------------------------------------------------";

            Log.Write(message, Colors.Green, LogFilter.Information);
        }

        public override void Reset()
        {
            _staticBox.LocalPosition = Vector3.Zero;
            _movableBox.LocalPosition = new Vector3(0.5f, 0f, 0f);

            _movableBox.LocalYaw = 0f;
            _movableBox.LocalRoll = 0f;
            _movableBox.LocalPitch = 0f;

            Yaw = Pitch = Roll = 0f;
        }

        #endregion
    }

    [Serializable, XmlInclude(typeof(Sample1Info)), XmlType(TypeName = "Experior.Catalog.Developer.Assemblies.Beginner.Sample1Info")]
    public class Sample1Info : Experior.Core.Assemblies.AssemblyInfo
    {

    }
}
