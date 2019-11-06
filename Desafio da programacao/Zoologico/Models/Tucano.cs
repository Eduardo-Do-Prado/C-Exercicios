using Zoologico.Interfaces;

namespace Zoologico.Models 
{
    public class Tucano : Animal, IGaiola 
    {
        public string AnimalGaiola() 
        {
            return this.GetType ().Name;
        }
    }
}