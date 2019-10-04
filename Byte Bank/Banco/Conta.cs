using System;
namespace Banco {

    public class Conta {

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Conta (string Nome, string Cpf, string Email) {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocaSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.Senha = senha;
                return true;
            } else {
                return false;
            }
        }
        /*===================== Conta corrente =================================================*/
        public string  Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta (int Agencia, int Conta, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Conta;
            this.Titular = Titular;
            this.Saldo = 0.0;

        }

        public double Deposito (double valor) {
            this.Saldo += valor;
            this.Saldo = this.Saldo = valor;
            return this.Saldo;
        }

        public bool Saque (double valor) {
            if (valor <= this.Saldo) {
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }

        public bool Transferencia (Conta destino, double valor) {
            if (this.Saque (valor)) {
                destino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}