public class Fornecedor
{
    public Fornecedor(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
    }

    public string? RazaoSocial { get; set; }
    public string? Cnpj { get; set; }
    //Tem muitos produtos
    public List<Produto> Produtos = new List<Produto>();
}