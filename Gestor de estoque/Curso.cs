﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas do curso {nome}");
            Console.WriteLine("Digite a Qtd de vagas. Que você quer dar entrada: ");

            int entrada = int.Parse(Console.ReadLine());

            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Cosumir vagas do produto {nome}");
            Console.WriteLine("Digite a Qtd. Que você quer dar baixa: ");

            int entrada = int.Parse(Console.ReadLine());

            vagas -= entrada;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();
        }

        enum Edit { nome = 1, preço, autor }
        public void Editar()
        {
            Console.WriteLine($"Editando Produto {nome}");

            Console.WriteLine("Oque você deseja editar no produto");
            Console.WriteLine("1-Nome\n2-Preco\n3-Autor");

            int opt = int.Parse(Console.ReadLine());
            Edit escolha = (Edit)opt;

            switch (escolha)
            {
                case Edit.nome:
                    editarNome();
                    break;
                case Edit.preço:
                    editarPreco();
                    break;
                case Edit.autor:
                    editarAutor();
                    break;
            }
        }

        void editarNome()
        {
            Console.WriteLine($"Digite o novo nome para o produto {nome}");
            string novoNome = Console.ReadLine();
            nome = novoNome;
            Console.WriteLine("Novo nome cadastrado com sucesso");
            Console.ReadLine();
        }
        void editarPreco()
        {
            Console.WriteLine($"Digite o novo preço para o produto {nome}");
            float novopreco = float.Parse(Console.ReadLine());
            preco = novopreco;
            Console.WriteLine("Novo preço cadastrado com sucesso");
            Console.ReadLine();
        }
        void editarAutor()
        {
            Console.WriteLine($"Digite o novo autor para o produto {nome}");
            string novoAutor = Console.ReadLine();
            autor = novoAutor;
            Console.WriteLine("Novo autor editado com sucesso");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Curso");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("-===================-");
        }
    }
}
