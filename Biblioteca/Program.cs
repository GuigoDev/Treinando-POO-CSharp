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
        Console.WriteLine("=== Sistema de Biblioteca ===\n");

        Livro livro1 = new Livro("1984","George Orwell", "978-0132350884", 328, 2008);

        livro1.ExibirInformacoes();

        Console.WriteLine("\n--- Emprestando livro ---");
        livro1.Emprestar();
        livro1.Emprestar(); 

        Console.WriteLine("\n--- Devolvendo livro ---");
        livro1.Devolver();

        Console.WriteLine("\n--- Teste de validação ---");
        try 
            {
                Livro livroInvalido = new Livro(
                    "Teste", 
                    "Autor", 
                    "123",
                    -100, // Inválido!
                    2020
                );
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine($"Erro capturado: {e.Message}");
            }
    }
}