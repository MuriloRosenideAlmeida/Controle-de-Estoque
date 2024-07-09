namespace Estoque {
    internal class Program {
        static void Main(string[] args) {

            int qtd;
            string nome;
            float preco;
            int quantidade;
            int quantProdutos;

            Console.WriteLine("Digite a quantidade de produtos que quer acrecentar: ");
            quantProdutos = int.Parse(Console.ReadLine());

            Produto[] Produtos = new Produto[quantProdutos];

            for (int i = 0; i < quantProdutos; i++) {
                //Entrando com os dados do produto
                Console.WriteLine("Entre com os dados do produto");
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Preco: ");
                preco = float.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                quantidade = int.Parse(Console.ReadLine());

                Produto p = new Produto(nome, preco, quantidade);
                Produtos[i] = p;

                //Adiciona produtos com a funcao
                Console.WriteLine("Dados do produto: " + p);
                Console.WriteLine("Digite a quantidade de produtos a ser adicionado ao estoque:");
                qtd = int.Parse(Console.ReadLine());
                p.AdicinarProdutos(qtd);
                Console.WriteLine("Dados atualizados para: " + p);

                //Remove produtos com a funcao
                Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque:");
                qtd = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qtd);
                Console.WriteLine("Dados atualizados para: " + p);
            }
            Console.WriteLine("Resumo do estoque");
            foreach (Produto produto in Produtos) Console.WriteLine(produto.ToString());
        }

    }
}
        