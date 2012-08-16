using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace MissingPoster
{
    public partial class HeaderType : ICloneable
    {
        [XmlIgnore]
        public Image Image
        {
            get
            {
                if (this.ImageBytes == null || this.ImageBytes.Length == 0)
                    return null;
                using (MemoryStream ms = new MemoryStream(this.ImageBytes))
                    return Image.FromStream(ms);
            }
            set
            {
                if (Image == null)
                    ImageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    value.Save(ms, ImageFormat.Jpeg);
                    ImageBytes = ms.GetBuffer();
                }
            }
        }

        public HeaderType Clone()
        {
            return new HeaderType()
            {
                Any = this.Any,
                EmailAddress = this.EmailAddress,
                Name = this.Name,
                PhoneNumber = this.PhoneNumber,
                ImageBytes = this.ImageBytes
            };
        }

        object ICloneable.Clone()
        {
            return new HeaderType()
            {
                Any = this.Any,
                EmailAddress = this.EmailAddress,
                Name = this.Name,
                PhoneNumber = this.PhoneNumber,
                ImageBytes = this.ImageBytes
            };
        }
    }
}
