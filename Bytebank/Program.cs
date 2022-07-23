using System;
using Bytebank;
using Bytebank.Titular;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao seu banco, ByteBank");

            //Cliente cliente0 = new Cliente();
            //ContaCorrente conta0 = new ContaCorrente();
            //cliente0.nome = "Leonardo Patricio";
            //cliente0.cpf = "45698562355";
            //cliente0.profissao = "Programador CSharp";

            //conta0.conta = "28041-x";
            //conta0.numeroAgencia = 23;
            //conta0.nomeAgencia = "Agencia Central";
            //conta0.saldo = 95.50;

            //Cliente cliente1 = new Cliente();
            //ContaCorrente conta1 = new ContaCorrente();
            //cliente1.nome = "Pedro Paulo";
            //cliente1.cpf = "41554112569";
            //cliente1.profissao = "Medico";

            //conta1.conta = "15025-x";
            //conta1.numeroAgencia = 01;
            //conta1.nomeAgencia = "Agencia Sul";
            //conta1.saldo = 985.52;

            //Console.WriteLine("Saldo do Pedro pre-saque: " + conta1.saldo);
            //conta1.Sacar(50);

            //Console.WriteLine("Saldo do Pedro pos-saque: " + conta1.saldo);

            //conta1.Depositar(100);
            //Console.WriteLine("Saldo do Pedro pos-deposito:" + conta1.saldo);

            //Console.WriteLine("Saldo do Leonardo pre-transferencia: " + conta1.saldo);
            //Console.WriteLine("Saldo do Pedro pre-transferencia: " + conta1.saldo);

            //bool transferencia = conta1.Transferir(50, conta1);
            //Console.WriteLine("Transferencia realizada com sucesso? " + transferencia);
            //Console.WriteLine("Saldo do Leonardo pos-transferencia: " + conta1.saldo);
            //Console.WriteLine("Saldo do Pedro pos-transferencia: " + conta1.saldo);


            //Cliente cliente = new Cliente();

            //cliente.nome = "Leonardo Patricio";
            //cliente.cpf = "12556366658";
            //cliente.profissao = "Programador CSharp";
            //Console.WriteLine(cliente.nome);
            //Console.WriteLine(conta2.titular.nome);


            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = new Cliente();
            //conta2.titular.nome = "Leonardo Patricio";
            //conta2.titular.profissao = "Programador CSharp";
            //conta2.titular.cpf = "12556999655";
            //conta2.conta = "12541-x";
            //conta2.numeroAgencia = 35;
            //conta2.nomeAgencia = "Agencia Central";

            //Console.WriteLine(conta2.titular.nome);

            //if (conta2.titular == null) 
            //{
            //    Console.WriteLine("O campo titular esta nulo.");
            //}



            //Cliente sarah = new Cliente();
            //sarah.Nome = "Sarah Silva";

            //ContaCorrente conta4 = new(253, "12345-x");
            //conta4.Saldo = 50;
            //conta4.Titular = sarah;


            //Console.WriteLine(conta4.Titular.Nome);
            //Console.WriteLine(conta4.Saldo);
            //Console.WriteLine(conta4.NumeroAgencia);
            //Console.WriteLine(conta4.Conta);


            ContaCorrente conta0 = new("Leonardo", "Agencia Delta", 15, "15040-x");
            ContaCorrente conta1 = new("Pedro", "Agencia PI", 25, "14600-x");
            


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Cliente cliente0 = new("Leonardo", "1252533365");
            Cliente cliente1 = new("Padro", "36547131616");
            Cliente cliente2 = new("Paulo", "12555556900");


            Console.WriteLine(Cliente.TotalDeClientesCriados);
            
            Console.ReadKey();
            
        }
    }
}
