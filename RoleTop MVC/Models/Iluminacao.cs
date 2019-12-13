using Microsoft.Extensions.Primitives;

namespace RoleTop_MVC.Models {
    public class Iluminacao : Equipamentos {
        public Iluminacao () 
        { 
            
        }

        public Iluminacao(StringValues stringValues)
        {
        }

        public Iluminacao (double preco, string tipo) {
            this.Preco = preco;
            this.Tipo = tipo;
        }
    }
}