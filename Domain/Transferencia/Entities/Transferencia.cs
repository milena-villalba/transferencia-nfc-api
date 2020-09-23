namespace Domain.Transferencia.Entities
{
    public class Transferencia : EntityBase
    {
        public string DispositivoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativa { get; set; }
    }
}
