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
        public AvengersService(ContextoAplicacao contexto, AvengersClient client)
        {
            _contexto = contexto;
            _client = client;
        }
        public async Task<string> RegisterUser(User usuario)
        {
            //puxar codinomes
            var codinamesString = await _client.GetContent();
            /*ListaCodinomes codinomesLista = JsonConvert.DeserializeObject<ListaCodinomes>(codinamesString);


            string codinomeUsuario;




            for (int i = 0; i < codinomesLista.Vingadores.Count; i++)
            {
                var codinome = codinomesLista.Vingadores[i].Codinome;
                bool existeCodinome = _contexto.Usuarios.Any(p => p.Codinome == codinome);
                if (!existeCodinome)
                {
                    codinomeUsuario = codinome;
                    //atribuir codinome
                    usuario.Codinome = codinomeUsuario;
                    _contexto.Usuarios.Add(usuario);
                    await _contexto.SaveChangesAsync();
                    break;
                }
                if (i == codinomesLista.Vingadores.Count - 1 && existeCodinome)
                {
                    return "Sem codinomes disponiveis";
                }
            }

            //cadastrar*/

            return codinamesString;

        }
        // public async Task<ActionResult<Usuario>> ListarUsuarios()
        // {
        //    return await _contexto.Usuarios.ToListAsync();
        // }*/
    }
}