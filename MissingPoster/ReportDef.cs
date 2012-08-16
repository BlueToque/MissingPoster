
namespace MissingPoster
{
    public class ReportDef
    {
        public ReportDef(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileNameWithoutExtension(path);
        }
        public string Path { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
