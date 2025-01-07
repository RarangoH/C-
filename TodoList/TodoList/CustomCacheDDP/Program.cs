
//Here is the option if the user wants to use caching or not
//Without Caching
DataDownloaderClient dDC = new DataDownloaderClient(new SlowDataDownloader());
//With Caching
DataDownloaderClient dDC1 = new DataDownloaderClient(new CachingDataDownloader(new SlowDataDownloader()));

dDC.Run();

public class DataDownloaderClient
{
    private readonly IDataDownloader _dataDownloader;

    public DataDownloaderClient(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public void Run()
    {
        Console.WriteLine(_dataDownloader.DownloadData("id1"));
        Console.WriteLine(_dataDownloader.DownloadData("id2"));
        Console.WriteLine(_dataDownloader.DownloadData("id3"));
        Console.WriteLine(_dataDownloader.DownloadData("id1"));
        Console.WriteLine(_dataDownloader.DownloadData("id3"));
        Console.WriteLine(_dataDownloader.DownloadData("id1"));
        Console.WriteLine(_dataDownloader.DownloadData("id2"));

        Console.ReadKey();
    }
}


public interface IDataDownloader
{
    string DownloadData(string resourceId);

    /*Does not have to declare it in interface b/c method is private
     * it will only be used inside the class
     */
    //string DownloadDataWithoutCaching(string resourceId);
}

//Class Fully Dedicated on Downloading Data - If user wants to cache some data or all data it does not have to modify the class, it has the option in CatchingDataDownloader
public class SlowDataDownloader : IDataDownloader
{
    //public readonly ICache<string, string> _cache;

    public string DownloadData(string resourceId)
    {
        //let's imagine this method downloads real data,
        //and it does it slowly
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }

    //public string DownloadData(string resourceId)
    //{
    //    return _cache.handleDataOnCache(resourceId, DownloadDataWithoutCaching);

    //}

}

//Decorator Design Pattern DDP
//Class only cares about caching data
public class CachingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    public readonly ICache<string, string> _cache;

    public CachingDataDownloader(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public string DownloadData(string resourceId)
    {
        return _cache.handleDataOnCache(resourceId, _dataDownloader.DownloadData);
    }
}

/* This interface ICache is not needed in this implementation b/c the code
 * still follows the dependency inversion principle due to 
 * the Cache class (Low level) and the SlowDataDownloader class (high level)
 * are being related through a Func (abstraction). But if the interface is implemented it is not
 * incorrect. It has more validity if there were more types of caching. 
 * So the interface had different caching methods.
 */

public interface ICache<TKey, TData>
{
    TData handleDataOnCache(TKey key, Func<TKey, TData> DownloadNewData);
}



/* NOTE: This is a good implementation b/c the Cache class is decoupled from the SlowDataDownloader class
 * if the SlowDataDownloader class changes or gets modified, the Cache class does not have to change
 * And it can still keep working as it is
 * 
 * 
 */

/*TKey and TData state that there are two generic types
 * so the dictionary can be created with generic types as well as the methods
 * if this generic types were not passed to the class, the methods and fields
 * would have to be of a certain type and only that certain type
 */
public class Cache<TKey, TData> : ICache<TKey, TData>
{
    private Dictionary<TKey, TData> _cacheData = new();

    /*
     * Passes a function as parameter b/c this way it can be used by the SlowDataDownloader
     * without having an abstraction to connect them or declare the SlowDataDownloader class
     * on this class (injecting it)
     */
    public TData handleDataOnCache(TKey key, Func<TKey, TData> DownloadNewData)
    {
        if (!_cacheData.ContainsKey(key))
        {
            //If the key assigned to the data does not exists. Download the data
            _cacheData[key] = DownloadNewData(key);
        }
        //If the key assigned to the data exists. Retrieve the data from cache
        return _cacheData[key];
    }
}