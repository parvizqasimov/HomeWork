using libary.DataModels;

namespace libary.İnfastuctue
{
    public interface IManager <T>
    {
        void Add(T item);
        void Edit(T item);
        void Remove(T item);

        T GetBiyID(int id);

       // T [] FindByName (string name);

    }
}
