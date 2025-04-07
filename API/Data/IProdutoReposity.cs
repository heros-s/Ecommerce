namespace API.Data;

public interface IProdutoReposity
{
    void Cadastrar(Produto produto);
    List<Produto> Listar();
}