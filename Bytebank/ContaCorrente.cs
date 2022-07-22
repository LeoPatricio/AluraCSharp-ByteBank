using Bytebank.Titular;

namespace Bytebank
{
    public class ContaCorrente
    {


        public Cliente Titular { get; set; }

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numeroAgencia = value;
                }
            }
        }

        public string NomeAgencia { get; set; }


        private double saldo;



        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;

            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }


        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }



        }

        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
        }
        
        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    saldo = valor;

        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }

    }
}