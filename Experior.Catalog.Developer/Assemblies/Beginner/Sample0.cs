using System;
using System.ComponentModel;
using System.Windows.Media;
using System.Xml.Serialization;
using Experior.Core.Properties.TypeConverter;
using Experior.Core.Properties;
using Experior.Interfaces;

namespace Experior.Catalog.Developer.Assemblies.Beginner
{
    public class Sample0 : Experior.Core.Assemblies.Assembly
    {
        #region Fields

        private readonly Sample0Info _info;
        private readonly Experior.Core.Parts.Box _box;

        #endregion

        #region Constructor

        public Sample0(Sample0Info info) : base(info)
        {
            _info = info;

            _box = new Experior.Core.Parts.Box(Colors.Wheat, _info.length, _info.height, _info.width);
            Add(_box);
        }

        #endregion

        #region Public Properties

        [Category("Size")]
        [DisplayName("Length")]
        [PropertyOrder(0)]
        [TypeConverter(typeof(FloatMeterToMillimeter))]
        public float Length
        {
            get => _info.length;
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _info.length = value;
                InvokeRefresh();
            }
        }

        [Category("Size")]
        [DisplayName("Height")]
        [PropertyOrder(1)]
        [TypeConverter(typeof(FloatMeterToMillimeter))]
        public float Height
        {
            get => _info.height;
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _info.height = value;
                InvokeRefresh();
            }
        }

        [Category("Size")]
        [DisplayName("Width")]
        [PropertyOrder(2)]
        [TypeConverter(typeof(FloatMeterToMillimeter))]
        public float Width
        {
            get => _info.width;
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _info.width = value;
                InvokeRefresh();
            }
        }

        public override string Category => "Developer - Beginner";

        public override ImageSource Image => Common.Icon.Get("Sample0");

        #endregion

        #region Public Methods

        public override void Refresh()
        {
            if (_info == null)
            {
                return;
            }

            _box.Length = Length;
            _box.Width = Width;
            _box.Height = Height;
        }

        public override void Inserted()
        {
            base.Inserted();

            var message = "--------------------------------------------------------------------------------------------" +
                          "\n Sample 0" +
                          "\n Objective: Change of box dimensions through the property grid" +
                          "\n --------------------------------------------------------------------------------------------";

            Log.Write(message, Colors.Green, LogFilter.Information);
        }

        #endregion
    }

    [Serializable, XmlInclude(typeof(Sample0Info)), XmlType(TypeName = "Experior.Catalog.Developer.Assemblies.Beginner.Sample0Info")]
    public class Sample0Info : Experior.Core.Assemblies.AssemblyInfo
    {

    }
}