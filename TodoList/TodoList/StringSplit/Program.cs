public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        string originalSeparator,
        string targetSeparator)
    {
        string[] res = input.Split(originalSeparator);
        string anw = string.Join(targetSeparator, res);

        return anw;
    }

}