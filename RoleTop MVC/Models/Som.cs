using Microsoft.Extensions.Primitives;

namespace RoleTop_MVC.Models
{
    public class Som : Equipamentos
    {
        public Som(){
        }
        public Som(double preco, string tipo){
            this.Preco = preco;
            this.Tipo = tipo;
        }
    }
}