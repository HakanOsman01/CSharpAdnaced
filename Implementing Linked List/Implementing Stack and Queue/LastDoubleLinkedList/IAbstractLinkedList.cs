﻿
namespace LastDoubleLinkedList
{
    public interface IAbstractLinkedList<T>:IEnumerable<T>
    {
        int Count { get; }

        void AddFirst(T item);

        T RemoveFirst();

        T GetFirst();

        void AddLast(T item);

        T RemoveLast();

        T GetLast();
    }
}
