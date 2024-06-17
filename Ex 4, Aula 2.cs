using System;

namespace Geometria
{
   
    public interface IFormaGeometrica
    {
        double CalcularArea();
        double CalcularPerimetro();
    }

    
    public class Retangulo : IFormaGeometrica
    {
        public double Largura { get; }
        public double Altura { get; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea() => Largura * Altura;

        public double CalcularPerimetro() => 2 * (Largura + Altura);
    }

    public class Circulo : IFormaGeometrica
    {
        public double Raio { get; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea() => Math.PI * Math.Pow(Raio, 2);

        public double CalcularPerimetro() => 2 * Math.PI * Raio;
    }

  
    public class Triangulo : IFormaGeometrica
    {
        public double Base { get; }
        public double Altura { get; }
        public double LadoA { get; }
        public double LadoB { get; }
        public double LadoC { get; }

        public Triangulo(double @base, double altura, double ladoA, double ladoB, double ladoC)
        {
            Base = @base;
            Altura = altura;
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double CalcularArea() => (Base * Altura) / 2;

        public double CalcularPerimetro() => LadoA + LadoB + LadoC;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFormaGeometrica retangulo = new Retangulo(5.0, 3.0);
            IFormaGeometrica circulo = new Circulo(4.0);
            IFormaGeometrica triangulo = new Triangulo(3.0, 4.0, 3.0, 4.0, 5.0);

            ExibirInformacoesForma(retangulo, "Retângulo");
            ExibirInformacoesForma(circulo, "Círculo");
            ExibirInformacoesForma(triangulo, "Triângulo");
        }

        static void ExibirInformacoesForma(IFormaGeometrica forma, string nome)
        {
            Console.WriteLine($"{nome} -> Área: {forma.CalcularArea()} | Perímetro: {forma.CalcularPerimetro()}");
        }
    }
}