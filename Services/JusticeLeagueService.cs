using TesteBackendUol.Clients;
using TesteBackendUol.Models;
using System.Xml.Serialization;
using System;
using TesteBackendUol.Data;

namespace TesteBackendUol.Services
{
    public class JusticeLeagueService : IJusticeLeagueService
    {
        private readonly JusticeLeagueClient _client;
        private readonly ContextoAplicacao _contexto;

        public JusticeLeagueService(JusticeLeagueClient client, ContextoAplicacao contexto)
        {
            _client = client;
            _contexto = contexto;
        }
        public async Task<string> RegisterUser(User usuario)
        {
            var response = await _client.GetContent();
            var serializer = new XmlSerializer(typeof(JusticeLeague));
            using (StringReader reader = new StringReader(response))
            {
                JusticeLeague liga = (JusticeLeague)serializer.Deserialize(reader);
                foreach (var codinome in liga.Codinomes)
                {
                    bool existeCodinome = _contexto.Usuarios.Any(p => p.Codinome == codinome);
                    if (!existeCodinome)
                    {
                        usuario.Codinome = codinome;
                        _contexto.Usuarios.Add(usuario);
                        await _contexto.SaveChangesAsync();
                        return "USUÁRIO CADASTRADO COM SUCESSO";
                    }
                }

            }
            return "Sem codinomes disponiveis";
        }
    }
}
