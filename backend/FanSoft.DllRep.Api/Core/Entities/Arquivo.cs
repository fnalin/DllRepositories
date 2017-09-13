namespace FanSoft.DllRep.Api.Core.Entities
{
    public class Arquivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Conteudo { get; set; }
    }
}
