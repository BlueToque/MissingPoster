using BlueToque.Utility;
using MissingPoster.Properties;
using System.IO;

namespace MissingPoster
{
    public partial class Configuration : SingletonBase<Configuration>
    {
        public Configuration()
        {
            this.Contact = new ContactType();
            this.Header = new HeaderType();
            this.Footer = new FooterType();
        }

        internal static void Load()
        {
            if (!File.Exists(Paths.Expand(Settings.Default.ConfigFile)))
            {
                Configuration config = new Configuration();
                config.ToFile(Paths.Expand(Settings.Default.ConfigFile));
            }
            Configuration.Instance = Configuration.FromFile(Paths.Expand(Settings.Default.ConfigFile));        
        }

        internal static void Save()
        {
            Configuration.Instance.ToFile(Paths.Expand(Settings.Default.ConfigFile));
        }
    }
}
