using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastras(Filme novoFilme);
        List<Filme> Listar();
        void Deletar(Guid id);

        Filme BuscarPorId(Guid id);
    }
}
