using System;
using System.Collections.Generic;
using System.IO;

public class Atividade {
    public static void Main(String[] args) {
    
        string caminho_arquivo = "D:\\programas e estudo\\\\ws visual estudio\\\\Atividade_extra_estrutura_de_dados_avancados\\extra.txt";
        var numeros = new List<int>();


        foreach(var numero in File.ReadAllLines(caminho_arquivo)) {
            if (int.TryParse(numero.Trim(), out int num)) {
                    numeros.Add(num);
            }
        }

        bubbleSort(numeros);
        
        foreach(var lista_ordenada in numeros) {
            Console.WriteLine(lista_ordenada);
        }
        
    }


    public static void bubbleSort(List<int> lista){
        int n = lista.Count;
        for(int i = 0; i < n - 1; i++) { 
            for(int j = 0; j < n - i - 1; j++) {
                if (lista[j] > lista[j + 1]) {
                    int temporario = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temporario;
                }
            }
        }
    }
}