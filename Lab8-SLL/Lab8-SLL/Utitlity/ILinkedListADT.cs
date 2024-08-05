namespace Utility
{
    public interface ILinkedListADT<T>
    {
        void Add(T item);

        void AddFirst(T item);
        void AddLast(T item);
        void Remove(int index);
        void RemoveFirst();
        void RemoveLast();
        void InsertAt(int index, T item);
        void Replace(int index, T item);
        T GetValue(int index);
        int IndexOf(T item);
        bool Contains(T item);
        void Clear();
        int Count();
        bool IsEmpty();
        void Reverse();
    }
}
