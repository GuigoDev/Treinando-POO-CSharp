using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca;

public class Livro
{
    private string titulo;
    private string autor;
    private string isbn;
    private int paginas;
    private int anoPublicacao;
    private bool emprestado;

    public Livro(String titulo, string autor, string isbn, int paginas, int anoPublicacao)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.isbn = isbn;

        if (paginas > 0)
            this.paginas = paginas;
        else
            throw new ArgumentException("Páginas inválido!");

        this.emprestado = false;

        if (anoPublicacao >= 1000 && anoPublicacao <= DateTime.Now.Year)
            this.anoPublicacao = anoPublicacao;
        else
            throw new ArgumentException("Ano de publicação inválido!");
    }

    public string Titulo { get { return titulo; } }
    public string Autor { get { return autor; } }
    public int Paginas { get { return paginas; } }
    public string Isbn { get { return isbn; } }
    public bool Emprestado { get { return emprestado; } }
    public int AnoPublicacao { get { return anoPublicacao; } }

    public void Emprestar()
    {
        if (!emprestado)
        {
            emprestado = true;
            Console.WriteLine($"{titulo} foi emprestado.");
        }
        else
        {
            Console.WriteLine($"{titulo} já está emprestado.");
        }
    }
    public void Devolver()
    {
        emprestado = true;
        Console.WriteLine($"{titulo} Devolvido.");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"ISBN: {isbn}");
        Console.WriteLine($"Páginas: {paginas}");
        Console.WriteLine($"Ano de Publicação: {anoPublicacao}");
        Console.WriteLine($"Status: {(emprestado ? "Emprestado" : "Disponível")}");
    }
}
