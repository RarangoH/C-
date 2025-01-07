public class VideoGame
{
    //Init b/c we dont intend to modify the objects read from the file
    public string Title { get; init; }   
    public int ReleaserYear { get; init; }   
    public decimal Rating { get; init; }



    //So when called to WriteLine (game) as an Object it does not print VideoGame but it prints the following string
    public override string ToString() =>
        $"{Title}, released in {ReleaserYear}, rating: {Rating}";
}