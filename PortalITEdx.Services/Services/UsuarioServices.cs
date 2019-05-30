using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PortalITEdx.Services.Usuario;


namespace PortalITEdx.Services.Services
{
    public class UsuarioServices : IUsuario
    {
        private readonly IMongoCollection<PortalITEdx.Domain.Usuario> _usuario;

        public UsuarioServices(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("PortalITDb"));
            var database = client.GetDatabase("PortalITDb");
            _usuario = database.GetCollection<PortalITEdx.Domain.Usuario>("Usuario");
        }

        public Domain.Usuario Create()
        {
            throw new NotImplementedException();
        }

       // public void Update(string Id, Domain.Usuario)
        //{
          //  throw new NotImplementedException();
        //}
    }
}
