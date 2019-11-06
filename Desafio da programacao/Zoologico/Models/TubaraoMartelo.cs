using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class TubaraoMartelo : Animal
    {
        public string AnimalPSalgado(){
            return this.GetType().Name;
        }
    }
}