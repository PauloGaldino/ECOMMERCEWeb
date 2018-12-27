namespace ECOMMERCE.ApplicationCore.Entities
{
    public class EnderecoCliente
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int EnderecoId { get; set; }

        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
    }
}
