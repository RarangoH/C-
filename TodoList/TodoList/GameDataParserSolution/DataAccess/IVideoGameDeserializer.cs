using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParserSolution.DataAccess
{
    public interface IVideoGameDeserializer
    {
        List<VideoGame> DeserializeFrom(string fileName, string fileContents);
    }
}
