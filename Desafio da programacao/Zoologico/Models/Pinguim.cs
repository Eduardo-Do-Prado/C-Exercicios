using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Pinguim : Animal
    {
        public string AnimalPGelada(){
            return this.GetType().Name;
        }
    }
}