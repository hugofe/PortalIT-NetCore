using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalITEdx.Domain
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Nome { get; set; }
        [BsonElement("Usuario")]
        public string UsuarioAcess { get; set; }
        [BsonElement("Senha")]
        public string Senha { get; set; }
        [BsonElement("CPF")]
        public string CPF { get; set; }
        [BsonElement("Cursos")]
        List<Usuario> Cursos = new List<Usuario>();
    }
}
