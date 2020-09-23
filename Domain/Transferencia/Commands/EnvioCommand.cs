namespace Domain.Transferencia.Commands
{
    public class EnvioCommand
    {
        public string DispositivoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
