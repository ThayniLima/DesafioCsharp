using DesafioSupermercado;



class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao supermercado, Menor Preço!");

        Cadastro produto = new Cadastro();
        produto.nome = "smartphone";
        produto.fabricante = "Xiaomi";
        produto.codigo_barras = 22335588;
        produto.valor_unitario = 1500.99;
        produto.valor_compra = 1500.99;
        produto.quantidade_estoque = 100;

        Console.WriteLine("Nome do produto: " + produto.nome);
        Console.WriteLine("Nome do fabricante: " + produto.fabricante);
        Console.WriteLine("Código de barras: " + produto.codigo_barras);
        Console.WriteLine("Valor unitário: " + produto.valor_unitario);
        Console.WriteLine("Valor da compra: " + produto.valor_compra);
        Console.WriteLine("Quantidade de estoque: " + produto.quantidade_estoque);



        Console.ReadKey();

    }
}