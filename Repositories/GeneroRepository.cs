using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using API_Filmes_SENAI.Context;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// classe que vai implementar a interface IGeneroRepository ou seja vamos implementar os metodos, toda a logica dos metodos.
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// variavel privada e somente leitura que "guarda" os dados do contexto
        /// </summary>
        private readonly Filme_Context _context;
        /// <summary>
        /// construtor de repositorio
        /// aqui, toda vez que o construtor for chanmado, os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto">dados do contexto</param>
        public GeneroRepository(Filme_Context contexto) 
        { 
        _context = contexto;

        }
        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero">objeto genero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo genero na tabel Generos(BD)
                _context.Genero.Add(novoGenero);

                //Após o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {

            try
            {
            List<Genero> ListaGeneros = _context.Genero.ToList();

            return ListaGeneros;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
