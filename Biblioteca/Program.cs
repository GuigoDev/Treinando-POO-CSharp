//projeto Sistema de Biblioteca Interativo
/*
Uma biblioteca deseja implementar um sistema interativo para gerenciar seus livros e usuários. O sistema deve permitir que os usuários façam o login, pesquisem livros, façam empréstimos e devoluções. Além disso, o sistema deve manter um registro dos livros disponíveis e dos livros emprestados.
Requisitos: 
    título livro
    nome do autor
    número de páginas - não pode ser negativo
    status (disponível ou emprestado)

Objetivo é usar classes, objetos e encapsulamento.
*/
using System;
using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro(   
                                    "1984",
                                    "George Orwell",
                                    328
                                );

        Console.WriteLine($"Título: {livro1.Titulo}");
        Console.WriteLine($"Autor: {livro1.Autor}");
        Console.WriteLine($"Páginas: {livro1.Paginas}");
        livro1.Emprestar();
        livro1.Emprestar(); // Tentativa de emprestar novamente
        livro1.Devolver();
        livro1.Devolver();

    }
}