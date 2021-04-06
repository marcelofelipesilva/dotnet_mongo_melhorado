using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(string id,DateTime dataNascimento, string sexo, string estado, string cidade)
        {
            this.Id = id;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Estado = estado;
            this.Cidade = cidade;
        }

        public string Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
         public string Cidade { get; set; }
    }
}