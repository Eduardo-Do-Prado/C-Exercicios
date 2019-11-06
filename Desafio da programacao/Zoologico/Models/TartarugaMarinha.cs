using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class TartarugaMarinha : Animal
    {
        public string AnimalPSalgado(){
            return this.GetType().Name;
        }
    }
}