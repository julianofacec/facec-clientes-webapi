using System;
using System.Text.Json.Serialization;

namespace Facec.Dominio.nsEntidades
{
    public class Cliente : AbstractEntidade
    {
        [JsonPropertyName("nome")]
        public string Nome { get; private set; }

        [JsonPropertyName("documento")]
        public string Documento { get; private set; }

        [JsonConstructor]
        public Cliente(string nome, string documento) : base()
        {
            Nome = nome;
            Documento = documento;

            ValidarNome();
            ValidarDocumento();
        }

        private void ValidarNome()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ArgumentException("Informe o nome do cliente!");
        }

        private void ValidarDocumento()
        {
            if (string.IsNullOrWhiteSpace(Documento))
                throw new ArgumentException("Informe o documento do cliente!");
        }
    }
}