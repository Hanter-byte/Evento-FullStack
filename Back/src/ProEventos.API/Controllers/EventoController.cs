using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento() {
            EventoId = 1,
            Tema = "Angular e dotnet",
            QtdPessoas = 5,
            Local = "Cianorte",
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            Lote = "Primeito Lote",
            ImagemUrl = "www.imagem.com/fotos/city"
            },
        new Evento() {
            EventoId = 2,
            Tema = "Angular e dotnet",
            QtdPessoas = 5,
            Local = "Cianorte",
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            Lote = "Primeito Lote",
            ImagemUrl = "www.imagem.com/fotos/city"
        }
    };

    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Post realizado!";
    }
}
