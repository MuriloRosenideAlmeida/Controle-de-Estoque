using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque {
    internal class Produto {

        public string Nome { get; private set; }//Propriedade serve para os dados serem acessados normalmente no programa principal mas nao alterados
        public float Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, float preco, int quantidade) {// Construtor para que o objeto ja seja criado com valores
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public float ValorTotalEstoque() {// Faz o calculo do valor em estoque
            return Preco * Quantidade;
        }
        public void AdicinarProdutos(int quantidade) {// Adiciona produtos no estoque
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade) {// Remove produtos do estoque
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString() {// Faz com que consiga printar as informacoes sem concatenacao
            return Nome + ", R$" + Preco.ToString(CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total R$ " + ValorTotalEstoque().ToString(CultureInfo.InvariantCulture);
        }

    }
}
    

