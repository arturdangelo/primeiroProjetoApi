using System.ComponentModel.DataAnnotations;

namespace ProjetoApi1.Entities
{
    public class TABELA_PRODUTO
    {
        [Key]
        public int CODIGO_PRODUTO { get; set; }
        public string NOME_PRODUTO { get; set; }
        public double PRECO_PRODUTO { get; set; }
        public double QUANTIDADE_PRODUTO { get; set; }
        public string SITUACAO_PRODUTO { get; set; }

    }
}
