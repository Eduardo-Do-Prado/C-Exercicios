using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Leao : Animal
    {
        public string AnimalCaverna(){
            return this.GetType().Name;
        }
    }
}