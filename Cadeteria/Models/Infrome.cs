namespace Cadeteria.Models;

public class Informe
{
    public int TotalPedidos { get; set; }
    public int PedidosPendientes { get; set; }
    public int PedidosRealizados { get; set; }
    public int PedidosCancelados { get; set; }
    public int TotalCadetes { get; set; }
    public double JornalTotal { get; set; }

    // Constructor simple
    public Informe() { }
}