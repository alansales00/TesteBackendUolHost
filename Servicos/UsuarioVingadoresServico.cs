using TesteBackendUol.Models;
using Newtonsoft.Json;
using System.IO;
using TesteBackendUol.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;


namespace TesteBackendUol.Servicos

{
    public class UsuarioVingadoresServico : IUsuariosServico
    {
        private readonly HttpClient _client;
        private readonly ContextoAplicacao _contexto;
        public UsuarioVingadoresServico(IHttpClientFactory clientFactory, ContextoAplicacao contexto)
        {
            _client =  clientFactory.CreateClient("vingadores");
            _contexto = contexto;
        }
        public async Task<string> CadastrarUsuario(Usuario usuario) 
        {
            //puxar codinomes
            
            var resposta = await _client.GetAsync(_client.BaseAddress);
            var jsonString = await resposta.Content.ReadAsStringAsync();
            VingadoresLista vingadores = JsonConvert.DeserializeObject<VingadoresLista>(jsonString);

            //verificar codinome
            string codinomeUsuario;
            for (int i = 0; i < vingadores.Vingadores.Count; i++)
            {
               var  codinome = vingadores.Vingadores[i].Codinome;
               bool existeCodinome = _contexto.Usuarios.Any(p => p.Codinome == codinome);
                if (!existeCodinome)
                {
                    codinomeUsuario = codinome;
                    //atribuir codinome
                    usuario.Codinome = codinomeUsuario;
                    break;
                }
            }
           
            //cadastrar
            _contexto.Usuarios.Add(usuario);
            await _contexto.SaveChangesAsync();
            return "ususario criado";

        }
    }
}