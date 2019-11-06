using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Orangotango : Animal
    {
        public string AnimalCasa(){
            return this.GetType().Name;
        }
    }
}