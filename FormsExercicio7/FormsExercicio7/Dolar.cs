using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercicio7
{
    class Dolar
    {
        double valor;
        double cotacao;
        double convertido;

        public Dolar()
        {
            this.valor = 0;
            this.cotacao = 0;
        }

        public Dolar(double cotacao, double valor)
        {
            this.valor = valor;
            this.cotacao = cotacao;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public void SetCotacao(double cotacao)
        {
            this.cotacao = cotacao;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public double GetCotacao()
        {
            return this.cotacao;
        }

        public double GetConvertido()
        {
            return this.convertido;
        }

        public double ConverterDolarParaReal()
        {
            this.convertido = this.valor * this.cotacao;
            return convertido;
        }
    }
}
