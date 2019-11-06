using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Golfinho : Animal, IAquario
    {
        public string AnimalPSalgado(){
            return this.GetType().Name;
        }
    }
}