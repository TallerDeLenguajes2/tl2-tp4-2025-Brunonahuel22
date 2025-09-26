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
        int totalpedidos = ListaPedidos.Count;
        int pedidosPendientes = ListaPedidos.Count(p => p.Estado == "Pendiente");
        int PedidosRealizados = ListaPedidos.Count(p => p.Estado == "Realizado");
        int PedidosCancelados = ListaPedidos.Count(p => p.Estado == "Cancelado");
        double JornalTotal = ListaPedidos.Count(p => p.Estado == "Realizado") * 500;
        int TotalCadetes = ListaCadetes.Count;

        Informe informe = new Informe(totalpedidos,pedidosPendientes,PedidosRealizados,PedidosCancelados,TotalCadetes,JornalTotal);

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