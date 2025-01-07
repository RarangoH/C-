
using System.Text.Json;

namespace cookieApp.DataAccess
{
    public interface IStringsTextualRepository
    {

        List<string> Read(string filepath);
        void Write(string filepath, List<string> strings);
    
}

}
