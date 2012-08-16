using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace MissingPoster
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class ImageType
    {
        [XmlIgnore]
        public Image Image
        {
            get
            {
                if (this.ImageBytes == null ||this.ImageBytes.Length==0)
                    return null;
                using (MemoryStream ms = new MemoryStream(this.ImageBytes))
                    return Image.FromStream(ms);
            }
            set 
            {
                if (value == null)
                    ImageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    value.Save(ms, ImageFormat.Jpeg);
                    ImageBytes = ms.GetBuffer();
                }
            }
        }
    }
}
