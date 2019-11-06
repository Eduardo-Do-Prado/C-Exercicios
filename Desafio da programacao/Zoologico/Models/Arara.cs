using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Arara : Animal, IGaiola
    {
        public string AnimalGaiola()
        {
            return this.GetType().Name;
        }
    }
}