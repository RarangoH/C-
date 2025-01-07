public static class NumericTypesDescriber
{
    
    public static string Describe(object someObject)
    {
        List<string> type = new List<string>();
        string var = someObject.GetType().ToString();
        if (someObject != null)
        {
            type = var.Split('.').ToList();
            if (type[1].Contains("String"))
            {
                return null;
            }
            else
            {
                
                if (type[1].Contains("Int"))
                {
                    type[1] = "Int";
                    return $"{type[1]} of value {someObject}";
                }
                //Console.Write(type[1]);
                return $"{type[1]} of value {someObject}";
            }
            
        }
        return null;
    }
}