using System;
using System.ComponentModel;

namespace MissingPoster
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class ContactType: ICloneable
    {
        public ContactType Clone()
        {
            return new ContactType()
            {
                Any = this.Any,
                EmailAddress = this.EmailAddress,
                Name = this.Name,
                PhoneNumber = this.PhoneNumber
            };
        }

        object ICloneable.Clone()
        {
            return new ContactType()
            {
                Any = this.Any,
                EmailAddress = this.EmailAddress,
                Name = this.Name,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
