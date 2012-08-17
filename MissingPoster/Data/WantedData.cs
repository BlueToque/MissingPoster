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
            Footer = new FooterType();
            try
            {
                Header = Configuration.Instance.Header.Clone();
                Contact = Configuration.Instance.Contact.Clone();
            }
            catch { }

            Created = DateTime.Now;
            CreatedBy = WindowsIdentity.GetCurrent().Name;
        }

        protected override WantedDataType OnPreSerialize()
        {
            Modified = DateTime.Now;
            ModifiedBy = WindowsIdentity.GetCurrent().Name;
            return base.OnPreSerialize();
        }

        public bool DOBValid
        {
            get { return this.DOBSpecified; }
            set { this.DOBSpecified = value; }
        }
    }
}
