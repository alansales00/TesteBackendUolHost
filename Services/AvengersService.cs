using TesteBackendUol.Models;
using Newtonsoft.Json;
using System.IO;
using TesteBackendUol.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TesteBackendUol.Services;
using TesteBackendUol.Clients;

namespace TesteBackendUol.Services

{
    public class AvengersService : IAvengersService
    {
        private readonly AvengersClient _client;
        private readonly ContextoAplicacao _contexto;
        private readonly ICommonService _commonService;
        public AvengersService(ContextoAplicacao contexto, AvengersClient client, ICommonService commonService)
        {
            _contexto = contexto;
            _client = client;
            _commonService = commonService;
        }
        public async Task<string> RegisterUser(User usuario)
        {
            //puxar codinomes
            var response = await _client.GetContent();
            var codinomes = JsonConvert.DeserializeObject<Avengers>(response);

            foreach (var avenger in codinomes.Vingadores)
            {
                bool existeCodinome = _contexto.Usuarios.Any(p => p.Codinome == avenger.Codinome);
                if (!existeCodinome)
                {
                    usuario.Codinome = avenger.Codinome;
                    _contexto.Usuarios.Add(usuario);
                    await _contexto.SaveChangesAsync();
                    return "USUÁRIO CADASTRADO COM SUCESSO";
                }

            }

            return "Sem codinomes disponiveis";
        }

        public async Task<string> DeleteUser(int id)
        { 
            var response = await _commonService.DeleteUser(id);
            return response;
        }

        // public async Task<ActionResult<Usuario>> ListarUsuarios()
        // {
        //    return await _contexto.Usuarios.ToListAsync();
        // }*/
    }
}