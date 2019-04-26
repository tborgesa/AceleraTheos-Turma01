using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoInserirViewModel
    {
    public ETamanho Tamanho { get; set; }
    public List<PedidoIngredienteInserirViewModel> ListaIngredientes { get; set; }
    public EBorda Borda { get; set; }
    public Guid IdCliente { get; set; }
}
}
