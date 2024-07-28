using System;
using System.Collections.Generic;

namespace Gestão_de_tarefas
{

    class Task
    {
        public int Id { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected DateTime DueDate { get; set; }
        protected Priority TaskPriority { get; set; } //Novo atributo incluso com tipagem "Priority" com vinculação a um enum, permitindo somente três tipos de valores de atribuição.
        protected StatusTask Status { get; set; } //Novo atributo incluso de tipagem "StatusTask" com vinculação a um enum, permitindo somente três tipos de valores a se atribuir.
    }

    public enum Priority //Criação de uma tipagem "Priority", vinculada a um "Enum" dando a possibilidade de atribuir somente os tres valores a variavel "TaskPriority".
    {
        ALTA, //Alta prioridade
        MEDIA, //Media prioridade
        BAIXA //Baixa prioridade
    }
    public enum StatusTask //Criação de uma tipagem "StatusTask", vinculada a um "Enum" dando a possibilidade de atribuir somente os dois valores a variavel "TaskCompleted"
    {
        Expirada,
        Pendente,
        Finalizada
    }
}