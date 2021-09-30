using System;

namespace ProvaFilme.Models
{
    public class Filme
    {

        //Atributos ou propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ano { get; set; }
        public string Sinopse { get; set; }
        public String Genero { get; set; }
        

        //ToString
        public override string ToString() =>
            $"Nome: {Nome} | Ano: {Ano} | Genero: {Genero}";
    }
} 