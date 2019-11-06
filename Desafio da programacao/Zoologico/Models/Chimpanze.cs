using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Chimpanze : Animal, ICasaArvore
    {
        public string AnimalCasa()
        {
            return this.GetType().Name;
        }
    }
}