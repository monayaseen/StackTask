
namespace stackTask
{
    public interface IMyStack<T>
    {
        public void Push(T value);
        public T Pop();
        public T Peek();
        public void Clear();
        public void Print();

    }
    
    
}