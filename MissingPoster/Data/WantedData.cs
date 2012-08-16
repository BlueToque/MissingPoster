using System;
using System.Security.Principal;
using BlueToque.Utility;

namespace MissingPoster
{
    public partial class WantedDataType : Serializable<WantedDataType>
    {
        /// <summary>
        /// Create tje wanted data type
        /// </summary>
        public WantedDataType()
        {
            Image = new ImageType();
            Header = Configuration.Instance.Header.Clone();
            Footer = new FooterType();
            Contact = Configuration.Instance.Contact.Clone();

            Created = DateTime.Now;
            CreatedBy = WindowsIdentity.GetCurrent().Name;
        }

        protected override WantedDataType OnPreSerialize()
        {
            Modified = DateTime.Now;
            ModifiedBy = WindowsIdentity.GetCurrent().Name;
            return base.OnPreSerialize();
        }
    }
}
