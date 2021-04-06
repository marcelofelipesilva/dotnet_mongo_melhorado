using System;


namespace Api.Models
{
    public class InfectadoDto
    {
        
        public string Id { get; set; }    
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
         public string Cidade { get; set; }
    }
}