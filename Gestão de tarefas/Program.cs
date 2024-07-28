using System;
using System.Collections.Generic;

namespace Gestão_de_tarefas
{
    class Program : Task, ITaskRepository//Herança dos atributos de 'Task' (apesar de não ser necessário) e dos métodos da interface
    {
        public static void Main(string[] args)
        {

            TaskService task = new TaskService();
            List<TaskService> Lista_de_Tarefas = new List<TaskService>();
            string op = "";
            int aux = 1;

            do
            {
                //MENU
                Console.WriteLine("\nGerenciador de Tarefas\n\nEscolha uma opção:\n");
                Console.WriteLine("1 - Adicionar Tarefa.");
                Console.WriteLine("2 - Remover.");
                Console.WriteLine("3 - Atualizar status de uma tarefa.");
                Console.WriteLine("4 - Listar tarefas.");
                Console.WriteLine("5 - Encerrar aplicação.");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        task.Add(Lista_de_Tarefas, ref aux);
                        break;

                    case "2":
                        task.Remove(Lista_de_Tarefas);
                        break;

                    case "3":
                        task.Update(Lista_de_Tarefas);
                        break;

                    case "4":
                        task.ListTask(Lista_de_Tarefas);//Chamada do método "ListTask", juntamente com o método "CheckTask" 
                        task.CheckTask(Lista_de_Tarefas);//"CheckTask" irá sempre verificar se existe alguma "task" com status ("pendente") com data de expiração para o dia de hoje
                        break;

                    case "5":
                        Console.WriteLine("\nAplicação encerrada.");
                        return;//Encerra a aplicação


                    default:
                        Console.WriteLine("\nÉ necessário digitar uma opção válida (1 a 5).\n");
                        break;
                }
            }
            while (true);//Loop infinito, só quebrado com a chamada do 'case 5'
        }
    }
}
