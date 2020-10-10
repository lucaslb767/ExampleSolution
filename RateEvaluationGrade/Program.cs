using System;

namespace RateEvaluationGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do parça");
            var grade = float.Parse(Console.ReadLine());

            if (grade > 10)
                Console.WriteLine("NOTA MUITO ALTA, NAO VALE");
            else if(grade == 10)
                Console.WriteLine("Parabéns!");
            else if (grade >= 8)
                Console.WriteLine("Falta pouco");
            else if (grade >= 5)
                Console.WriteLine("Tem que estudar mais...");
            else if (grade > 0 )
                Console.WriteLine("Precisa de MUITO, MAS MUITO estudo");
            else if (grade == 0)
                Console.WriteLine("que vergonha");
            else
                Console.WriteLine("Nota negativa, não vale");
                
        }
    }
}
