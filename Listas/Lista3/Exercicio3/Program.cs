using System;
//Crie um programa que receba o peso e a altura de uma pessoa, calcule e exiba seu IMC. A formula para calculo do IMC é
//imc = peso / (alltura * altura)
class Program{

    static void Main (string[]args){

        System.Console.WriteLine("Digite seu peso:");
        double peso = double.Parse (Console.ReadLine());
        System.Console.WriteLine("Digite sua altura:");
        double altura = double.Parse (Console.ReadLine());

        double calculoImc = peso / (altura * altura);
        System.Console.WriteLine("Seu IMC eh: " + calculoImc );



    }
}