namespace Tobe.Core
{
    public interface IListContainer
    {
        void Clear();
        void Append<TListPrefab>(TListPrefab instance);
    }
}