
namespace cookieApp.FileAccess
{
    public class FileMetadata
    {
        public string Name { get; }
        public FileFormat format { get; }

        public FileMetadata(string name, FileFormat format)
        {
            Name = name;
            format = format;
        }
        public string ToPath() => $"{Name}.{format.AsFileExtension()}";
    }
}
