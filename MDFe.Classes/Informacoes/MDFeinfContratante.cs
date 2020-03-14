using System.Xml.Serialization;

namespace MDFe.Classes.Informacoes
{
    public class MDFeInfContratante
    {
        /// <summary>
        /// Razão social ou nome do contratante
        /// </summary>
        [XmlElement(ElementName = "xNome")]
        public string xNome { get; set; }

        public string CPF { get; set; }
        public string CNPJ { get; set; }

        /// <summary>
        /// Identificador do contratante em caso de ser estrangeiro 
        /// </summary>
        [XmlElement(ElementName = "idEstrangeiro")]
        public string IdEstrangeiro { get; set; }
    }
}