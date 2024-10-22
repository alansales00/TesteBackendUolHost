using TesteBackendUol.Models;
using Newtonsoft.Json;
using System.IO;
using TesteBackendUol.Repositorios;


namespace TesteBackendUol.Servicos

{
    public class UsuarioVingadoresServico : IUsuariosServico
    {
        private readonly HttpClient _client;
        private readonly IRepository _repository;
        public UsuarioVingadoresServico(IHttpClientFactory clientFactory, IRepository repository)
        {
            _client =  clientFactory.CreateClient("vingadores");
            _repository = repository;
        }
        public async Task<VingadoresLista> CadastrarUsuario(Usuario usuario) 
        {
            //puxar codinomes
            
            var resposta = await _client.GetAsync(_client.BaseAddress);
            var jsonString = await resposta.Content.ReadAsStringAsync();
            VingadoresLista vingadores = JsonConvert.DeserializeObject<VingadoresLista>(jsonString);

            //verificar codinome

            //atribuir codinome
            //cadastrar ususario 

            // repositorio pra cadastrar
            _repository.CadastrarUsuario(usuario, vingadores);

            return vingadores;

        }
    }
}