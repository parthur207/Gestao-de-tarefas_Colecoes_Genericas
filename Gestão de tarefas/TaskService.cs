using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Gestão_de_tarefas
{
    class TaskService : Task, ITaskRepository //Herda os atributos da classe "Task" e métodos da interface "ITaskRepository"
    {
        //Construtor dos atributos
        public TaskService(int id, string title, string description, DateTime duedate, Priority task_priority, StatusTask status)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = duedate;
            TaskPriority = task_priority;
            Status = status;
        }

        public TaskService()//Auxiliador nas chamadas dos métodos em "Program"
        {
        }

        public override string ToString()//Método para impressão das informações vinculadas a uma tarefa
        {
            return $"\tId: ({Id}) - Titulo: {Title} - Descrição da tarefa: {Description} - Data de vencimento: ({DueDate.Date:dd/MM/yyyy}) - Prioridade: ({TaskPriority}) | Status da tarefa: ({Status})\n";
        }

        /*CASE 1*/
        public void Add(List<TaskService> Lista_de_Tarefas, ref int aux)
        {
            DateTime duedate = DateTime.Now;//Introduzido como a data atual, pois não pode ser nulo na declaração
            DateTime CurrentDate = DateTime.Now.Date;//Data atual sem as horas
            Priority task_priority = Priority.BAIXA;//Não aceita declaração como nulo

            string title = "", description = "", format = "dd/MM/yyyy", aux_priority = "", entrada = "", resp = "";

            bool validation = false;
            StatusTask statusTask = StatusTask.Pendente;//Task é introduzida como pendente

            do
            {
                Console.WriteLine("\nNome da Tarefa:");
                title = Console.ReadLine().ToUpper();//Inclusão do "ToUpper" para melhor precisão ao tentar localizar a task pelo nome na List.

                Console.WriteLine("\nDescrição da tarefa:");
                description = Console.ReadLine();
                do
                {
                    Console.WriteLine("\nData de vencimento da tarefa:");
                    entrada = Console.ReadLine();

                    if (!DateTime.TryParseExact(entrada, format, null, System.Globalization.DateTimeStyles.None, out duedate))//Tenta a conversão da string "entrada" para o formato estipulado
                    {
                        Console.WriteLine("\nDigite uma data no formato válido (DD/MM/YYYY).");
                    }
                    else if (duedate < CurrentDate)
                    {
                        Console.WriteLine($"\nDigite uma data igual, ou superior a data de hoje ({CurrentDate.Date}).");
                    }
                }
                while (!DateTime.TryParseExact(entrada, format, null, System.Globalization.DateTimeStyles.None, out duedate) || duedate < CurrentDate);//Incremento de um loop que só quebra depois do fornecimento de uma data coesa ao formato.

                do
                {
                    Console.WriteLine("\nPrioridade da tarefa (ALTA, MEDIA, BAIXA):");
                    aux_priority = Console.ReadLine().ToUpper().Trim();

                    if (aux_priority == "ALTA" || aux_priority == "MEDIA" || aux_priority == "BAIXA")
                    {
                        task_priority = (Priority)Enum.Parse(typeof(Priority), aux_priority);
                        validation = true;
                    }
                    else
                    {
                        Console.WriteLine("\nDado inválido. Insira uma das três prioridades a seguir: (ALTA | MEDIA | BAIXA)");
                    }
                }
                while (validation != true);//Utilização de uma variavel "bool" auxiliadora para validação dos dados


                TaskService task = new TaskService(aux, title, description, duedate, task_priority, statusTask);
                Lista_de_Tarefas.Add(task);//Adicina "task" a "List"
                aux++;//Representa o "ID"

                Console.WriteLine("\nTarefa adicionada.");
                do
                {
                    Console.WriteLine("\nAdicionar nova tarefa? 'sim', ou 'não'");
                    resp = Console.ReadLine().ToLower().Trim();//Conversão para minusculo "ToLower" e retirada dos espaços para melhor coesão "Trim".

                    if (resp != "não" && resp != "nao" && resp != "sim")
                    {
                        Console.WriteLine("\nResposta inválida. Digite 'sim', ou 'nao'.");
                    }
                }
                while (resp != "não" && resp != "nao" && resp != "sim");

            }
            while (resp == "sim");//Break do método "Add", voltando ao menu
        }

        /*CASE 2*/
        public void Remove(List<TaskService> Lista_de_Tarefas)
        {
            if (Lista_de_Tarefas.Count == 0)//Verifica se a Lista não possui nenhum elemento 
            {
                Console.WriteLine("\nNenhuma tarefa pendente.\n");
                Console.WriteLine("É necessário primeiramente a adição de novas tarefas.");
            }
            else
            {
                Console.WriteLine("\nDigite o (NOME) da tarefa que deseja realizar a remoção:");
                string nome = Console.ReadLine().ToUpper();

                TaskService Identificador = Lista_de_Tarefas.Find(aux => aux.Title.Equals(nome, StringComparison.OrdinalIgnoreCase));//Expressão Lambda para encontrar o elemento correspondente

                if (Identificador != null)
                {
                    Lista_de_Tarefas.Remove(Identificador);
                    Console.WriteLine("\nTarefa removida com sucesso.");
                }
                else
                {
                    Console.WriteLine("\nTarefa não encontrada.");
                }
            }
        }
        /*CASE 3*/
        public void Update(List<TaskService> Lista_de_Tarefas)
        {
            if (Lista_de_Tarefas.Count == 0)//Verifica se a Lista não possui nenhum elemento 
            {
                Console.WriteLine("\nNenhuma tarefa pendente.\n");
                Console.WriteLine("É necessário primeiramente a adição de novas tarefas.");
            }
            else
            {
                Console.WriteLine("\nDigite o (NOME) da tarefa que deseja atualizar:");
                string nome = Console.ReadLine().ToUpper();

                TaskService Identifier = Lista_de_Tarefas.Find(aux => aux.Title.Equals(nome, StringComparison.OrdinalIgnoreCase));//Expressão Lambda para encontrar o elemento correspondente

                if (Identifier != null)
                {
                    Console.WriteLine("\nDigite 'sim' caso tenha finalizado a tarefa e 'não' em caso de pendência.");
                    string input = Console.ReadLine().ToLower();
                    if (input.Equals("sim"))//Comparação do valor de "input" com string "sim"
                    {
                        Identifier.Status = StatusTask.Finalizada;//Mudança do status da tarefa para "Finalizada"

                        Console.WriteLine("\nStatus atualizado.");
                    }
                }
                else
                {
                    Console.WriteLine("\nTarefa não encontrada");
                }
            }
        }
        /*CASE 4*/
        public void ListTask(List<TaskService> Lista_de_Tarefas)
        {
            if (Lista_de_Tarefas.Count == 0)//Verifica se a Lista não possui nenhum elemento 
            {
                Console.WriteLine("\nNenhuma tarefa pendente.\n");
                Console.WriteLine("É necessário primeiramente a adição de novas tarefas.");
            }
            else//Impressão das tarefas
            {
                Console.WriteLine("\nLista de tarefas (Pendentes, ou Finalizadas):");
                Console.WriteLine("_________________________________________________________________________________________________________________________________________________________________________\n");
                foreach (TaskService element in Lista_de_Tarefas)
                {
                    Console.Write(element.ToString());
                    Console.WriteLine("_________________________________________________________________________________________________________________________________________________________________________\n");
                }
            }
        }
        public void CheckTask(List<TaskService> Lista_de_Tarefas) //Novo método incluso com o propósito de comparar a data de uma tarefa inclusa com a data de hoje
        {

            DateTime CurrentDate = DateTime.Now.Date;
            DateTime EveOfDue = CurrentDate.AddDays(-1);//Data anterior a data atual
            foreach (var element in Lista_de_Tarefas)
            {
                if (element.Status != StatusTask.Finalizada)
                {
                    if (element.DueDate == CurrentDate)//Comparativo da data atual com a data de expiração da tarefa
                    {
                        Console.WriteLine($"\nA tarefa abaixo deve ser executada no dia de hoje ({CurrentDate.Date} até 23:59):\n\n Tarefa: {(element.Title)} - Descrição: {element.Description} - Prioridade: ({element.TaskPriority}) - Status: {element.Status}\n");
                    }
                    else if (element.DueDate == EveOfDue)//OBS: A condição só irá se validar com a implementação de um banco de dados, visto que o sistema não permite a inserção de uma tarefa na data anterior a atual.
                    {
                        element.Status = StatusTask.Expirada;
                        Console.WriteLine($"\nA tarefa abaixo não foi concluída na data proposta ({EveOfDue.Date}):\n\n Tarefa:{(element.Title)} - Descrição: {element.Description} - Prioridade: ({element.TaskPriority}) - Status: {element.Status}");
                    }
                }
            }
        }
    }
}
