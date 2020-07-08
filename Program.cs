﻿using System;

namespace ultimaparcela
//Receba o valor total a ser pago e a quantidade de parcelas mensais de um financiamento. Exiba a data e o valor da última parcela.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor total a ser pago: ");
            decimal valor=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Quantidade de parcelas: ");
            int parcelas=Convert.ToInt32(Console.ReadLine());
            Console.Write("Data atual: ");
            DateTime data=Convert.ToDateTime(Console.ReadLine());

            DateTime mês=DateTime.Today.AddMonths(parcelas);
            decimal UltimaParcela=valor/parcelas;
            Console.WriteLine($"A última parcela do seu carnê será em {mês}, no valor de {UltimaParcela:C}");
    }
}
}
