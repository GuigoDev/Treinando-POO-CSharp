using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca;

public class Livro
{
    private string titulo;
    private string autor;
    private int paginas;
    private bool emprestado;

    public Livro(String titulo, string autor, int paginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        
        if (paginas > 0)
            this.paginas = paginas;
        else
            throw new ArgumentException("Páginas inválido!");
            
        this.emprestado = false;
    }

    public string Titulo{get{return titulo;}}
    public string Autor{get{return autor;}}
    public int Paginas{get{return paginas;}}
    public bool Emprestado{get{return emprestado;}}

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
        emprestado = false;
    }
}
