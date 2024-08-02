// See https://aka.ms/new-console-template for more information
using POO.E1;

Console.WriteLine("Hello, World!");

/**
 *
 * EXECUCAO DE E1
 *
 */

// Criação de um objeto -> objeto é uma instância ou uma realização concreta de uma classe
// Objeto de Carro com os parâmetros fornecidos
Carro carro = new Carro("Toyota", "Corolla", 2020, "ABC-1234", "Gasolina");

// Criação de um objeto Moto com os parâmetros fornecidos
Moto moto = new Moto("Honda", "CB500", 2019, "XYZ-5678", 500);

// Exibição das informações do carro e execução de seus métodos
Console.WriteLine("Informações do Carro:");
Console.WriteLine(carro.ColetarInformacoes());
carro.Abastecer();
carro.Mover();
carro.Mover(80);

// Exibição das informações da moto e execução de seus métodos
Console.WriteLine("\nInformações da Moto:");
Console.WriteLine(moto.ColetarInformacoes());
moto.Empinar();
moto.Mover();
moto.Mover(100);