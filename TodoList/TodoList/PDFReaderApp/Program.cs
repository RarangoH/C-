




using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UglyToad.PdfPig.Actions;
using UglyToad.PdfPig.Content;
using static UglyToad.PdfPig.Core.PdfSubpath;


TicketHistoryApp t = new TicketHistoryApp(new FileHandler(),new TextAnalysis());
t.Run();

