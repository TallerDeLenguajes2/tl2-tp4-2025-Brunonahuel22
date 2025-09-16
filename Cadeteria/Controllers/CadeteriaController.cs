namespace Cadeteria.Controllers;

using Cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
class CadeteriaController : ControllerBase
{


    List<Pedido> ListaPedidos = new List<Pedido>();
    List<Cadete> ListaCadetes = new List<Cadete>();


    [HttpGet]
    public IActionResult GetPedidos()
    {
        return Ok(ListaPedidos);
    }
    [HttpGet("cadetes")]
    public IActionResult GetCadetes()
    {
        return Ok(ListaCadetes);
    }

    [HttpGet("informe")]
    public IActionResult GetInforme()
    {
        var informe = new Informe
        {
            TotalPedidos = ListaPedidos.Count,
            PedidosPendientes = ListaPedidos.Count(p => p.Estado == "Pendiente"),
            PedidosRealizados = ListaPedidos.Count(p => p.Estado == "Realizado"),
            PedidosCancelados = ListaPedidos.Count(p => p.Estado == "Cancelado"),
            JornalTotal = ListaPedidos.Count(p => p.Estado == "Realizado") * 500,
            TotalCadetes = ListaCadetes.Count
        };

        return Ok(informe);
    }



    [HttpPost("agregar")]
    public IActionResult AsignarPedido(Pedido pedido)
    {
        ListaPedidos.Add(pedido);
        return Ok(ListaPedidos);
    }



    [HttpPut("cambiarestado/{idPedido}/{nuevoEstado}")]
    public IActionResult CambiarEstadoPedido(int numeroPedido, string nuevoEstado)
    {
     
    foreach (var pedido in ListaPedidos)
    {
        if (pedido.Numero == numeroPedido)
        {
            
            pedido.CambiarEstado(nuevoEstado);
            
            
            return Ok();
        }
    }
    
   
    return NotFound();
    }





}