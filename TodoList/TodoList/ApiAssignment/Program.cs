using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Threading;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using planets;
//var baseAddress = "https://ddragon.leagueoflegends.com/cdn/14.3.1/data/";
//var requestUri = "en_US/champion.json";



//var json = await api.Read("https://swapi.dev/", "api/planets");

//var root = JsonSerializer.Deserialize<Root>(json);



PlanetsApp planetsapp = new PlanetsApp(new Repository(), new BusinessRule(), new ConditionValidator(new BusinessRule()));
planetsapp.Run();



Console.ReadKey();
