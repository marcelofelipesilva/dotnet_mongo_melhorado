using System;
using System.Xml;
using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectadoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _infectadosCollection;

        public InfectadoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarInfectado([FromBody] InfectadoDto dto)
        {
            var infectado = new Infectado(dto.Id, dto.DataNascimento, dto.Sexo, dto.Estado, dto.Cidade);

            _infectadosCollection.InsertOne(infectado);

            return StatusCode(201, "Infectado adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult ObterInfectados()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

            return Ok(infectados);
        }

         [HttpPut]
        public ActionResult AtualizarInfectados([FromBody] InfectadoDto dto)
        {

            var infectados = _infectadosCollection.UpdateOne(
                Builders<Infectado>.Filter.Where(_ => _.DataNascimento == dto.DataNascimento),
                 Builders<Infectado>.Update.Set("sexo", dto.Sexo)
                  );
            

            return Ok("Atualizado com sucesso");
        }
       
        //deleta infectado por id

        [HttpDelete("{Id}")]
        public ActionResult DeletarInfectado(int Id)
        {

            var infectados = _infectadosCollection.DeleteOne(
                Builders<Infectado>.Filter.Where(_ => _.Id ==Convert.ToString(Id)));
            

            return Ok("Deletado com sucesso");
        }
    }
}
