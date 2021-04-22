using System.Collections;
using System.Collections.Generic;

namespace Tema2.collections
{
    public class ListaGen<T> : IEnumerable<T>
    {
        private Nod end;
        private Nod start;

        public ListaGen()
        {
            start = null;
            end = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = start;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void insertToFront(T type)
        {
            var nod = new Nod(type);
            nod.Next = start;
            start = nod;
            if (end == null) end = nod;
        }

        public void insertToEnd(T type)
        {
            var node = new Nod(type);
            if (start == null) start = node;
            if (end != null) end.Next = node;
            end = node;
        }

        public void delete(T type)
        {
            var current = start;
            current = GetCurrent(type, current);
            if (current == null) return;
            while (current.Next != null)
                current = DeleteNodes(type, current);
        }

        private Nod DeleteNodes(T t, Nod current)
        {
            if (current.Next.Data.Equals(t)) PerformDeletion(current);
            else current = current.Next;

            return current;
        }

        private void PerformDeletion(Nod current)
        {
            if (end == current.Next) DeleteLast(current);
            else DeleteNode(current);
        }

        private void DeleteLast(Nod current)
        {
            end = current;
            end.Next = null;
        }

        private static void DeleteNode(Nod current)
        {
            var delNod = current.Next;
            current.Next = current.Next.Next;
            delNod.Next = null;
        }

        private Nod GetCurrent(T t, Nod current)
        {
            while (current != null && current.Data.Equals(t))
            {
                start = start.Next;
                current = start;
            }

            return current;
        }

        private class Nod
        {
            public Nod(T data)
            {
                this.Data = data;
            }

            public T Data { get; set; }

            public Nod Next { get; set; }
        }
    }
}