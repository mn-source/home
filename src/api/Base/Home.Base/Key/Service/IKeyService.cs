namespace Home.Base.Key.Service
{
    public interface IKeyService<TKey>
    {
        TKey ParseKey(string keyString);

        string GetKeyString(TKey key);
    }
}
