using System;

namespace NamespaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recebendo arquivo...");
            string notOrdened = System.IO.File.ReadAllText("./assets/notOrdened.txt");
            Console.WriteLine("Arquivo recebido com sucesso!");
            
            Console.WriteLine("Definindo tamanho do array em relação a quantidade de linhas do arquivo...");
            string [] array = notOrdened.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            Console.WriteLine("Tamanho do array definido com sucesso!");
            Console.WriteLine("Inserindo valores do arquivo no array...");
            int [] arrayInt = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayInt[i] = int.Parse(array[i]);
            }
            Console.WriteLine("Valores inseridos com sucesso!");
            Console.WriteLine("Ordenando array...");
            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = 0; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] < arrayInt[j])
                    {
                        int aux = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = aux;
                    }
                }
            }
            Console.WriteLine("Array ordenado com sucesso!");
            Console.WriteLine("Mostando array ordenado...");
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine(arrayInt[i]);
            }

            Console.WriteLine("Salvando valores ordenados em uma Collection...");
            List<int> list = new List<int>();
            for (int i = 0; i < arrayInt.Length; i++)
            {
                list.Add(arrayInt[i]);
            }
            Console.WriteLine("Valores salvos com sucesso na Colletion!");
            
            Console.WriteLine("Array ordenado: ");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Collection ordenada: ");
            Console.WriteLine(list);

            Console.WriteLine("Salvando valores ordenados em um arquivo...");
            System.IO.File.WriteAllLines("./assets/Ordened.txt", list.Select(x => x.ToString()));
            Console.WriteLine("Valores salvos com sucesso em um arquivo!");



           
            
            
            






            

        }
    }
}