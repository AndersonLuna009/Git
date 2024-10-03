using System;

namespace Pessoa
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _telefone;
        private string _endereco;
        private string _email;

        public Pessoa(string nome, int idade, string telefone, string endereco, string email)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O email não pode ser vazio.");
                }
                _email = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa("Maria", 30, "123-456-7890", "Rua A, 123", "maria@email.com");

            Console.WriteLine("Nome: " + pessoa1.Nome);
            Console.WriteLine("Idade: " + pessoa1.Idade);
            Console.WriteLine("Telefone: " + pessoa1.Telefone);
            Console.WriteLine("Endereço: " + pessoa1.Endereco);
            Console.WriteLine("Email: " + pessoa1.Email);

            pessoa1.Idade = 35;
            pessoa1.Endereco = "Rua B, 456";

            try
            {
                pessoa1.Idade = -5;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message); 
            }

            Console.ReadKey();
        }
    }
}