using System;
using System.Collections.Generic;
using System.Text;

namespace Caranga
{
    class Carro
    {
        private string cor;
        private string modelo;
        private int ano;
        private int velAtual = 0;
        private int velMax;
        private bool ifLigado = false;
        private bool carroMorreu = false;

        public Carro(string cor, string modelo, int ano, int velMax)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.ano = ano;
            this.velMax = velMax;
        }

        public string Cor { get => cor; }
        public string Modelo { get => modelo; }
        public int Ano { get => ano; }
        public int VelAtual { get => velAtual; }
        public int VelMax { get => velMax; }
        public bool IfLigado { get => ifLigado; }
        public bool CarroMorreu { get => carroMorreu; }       

        public void Ligar()
        {
            if (IfLigado == true)
            {
                Console.WriteLine("o carro ja esta ligado");
                Console.ReadLine();
            }
            else
            {
                this.ifLigado = true;
                Console.WriteLine("carro ligado");
                Console.ReadLine();
            }
        }
        public void Desligar()
        {
            if (IfLigado == true)
            {
                this.ifLigado = false;
                Console.WriteLine("carro desligado");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("voce desligou o carro mesmo ele ja estando desligado");
                Console.ReadLine();
            }
            if(IfLigado == true && VelAtual > 20)
            {
                this.carroMorreu = true;
                Console.WriteLine("voce desligou o carro mesmo com ele em movimento... wow.");
                Console.ReadLine();
            }
        }
        public void Acelerar()
        {
            if (IfLigado == true)
            {
                if (this.velAtual + 10 < this.velMax)
                {
                    this.velAtual = +10;
                    Console.WriteLine("o carro esta a: {0}", VelAtual);
                    Console.ReadLine();
                }
                else
                {
                    this.velAtual = 0;
                    this.carroMorreu = true;
                    Console.WriteLine("o carro esta a: {0}", VelAtual);
                    Console.WriteLine("voce derreteu o motor");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine(" o pedal afunda, mas nada acontece. o carro esta desligado");
                Console.ReadLine();
            }
        }
        public void Frear()
        {
            if (IfLigado == true)
            {
                if (this.velAtual > 10)
                {
                    this.velAtual = -10;
                    Console.WriteLine("o carro esta a: {0}", this.velAtual);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("o carro esta parado");
                    Console.ReadLine();
                }           
            }
            else
            {
                Console.WriteLine(" o pedal afunda, mas nada acontece. o carro esta desligado");
                Console.ReadLine();
            }
        }
    }
}
