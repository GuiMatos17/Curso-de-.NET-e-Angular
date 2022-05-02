using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Eventos> _eventos = new Eventos[] {
            new Eventos() {
                EventosId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo - SP",
                Lote = "3º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Eventos() {
                EventosId = 2,
                Tema = "Exemplo de Eventos",
                Local = "São Bernardo do Campo - SP",
                Lote = "1º Lote",
                QtdPessoas = 140,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto2.png"
                }
            };
        public EventosController()
        {
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        { 
            return  _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Eventos> GetById(int id)
        { 
            return  _eventos.Where(evento => evento.EventosId == id);
        }
    }
}
