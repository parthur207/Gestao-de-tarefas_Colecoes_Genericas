# Documentação do Projeto: Gestão de Tarefas
<br>


## Objetivo do Projeto

* O objetivo deste projeto é desenvolver um sistema de gestão de tarefas que permita a criação, remoção, atualização e listagem de tarefas. O sistema é projetado para ser utilizado por indivíduos ou pequenas equipes que precisam organizar suas tarefas e acompanhar o progresso e prazos de suas atividades.


<br>

## Linguagem Utilizada e Fundamentos

A linguagem utilizada para o desenvolvimento deste projeto é C#. C# é uma linguagem de programação moderna, orientada a objetos, e fortemente tipada. É amplamente utilizada para desenvolvimento de aplicações desktop, web, e móveis devido à sua robustez e versatilidade.



<br>
## Bibliotecas Utilizadas

O projeto utiliza as seguintes bibliotecas:

System: Biblioteca principal que fornece classes básicas e fundamentais para a aplicação.
System.Collections.Generic: Fornece classes para definir coleções fortemente tipadas que podem ser armazenadas em memória e acessadas de maneira eficiente.


<br>
## Funcionalidades e Métodos


- Add

Adiciona uma nova tarefa à lista de tarefas.

Parâmetros:

List<TaskService> Lista_de_Tarefas
int id

Lógica:

Solicita ao usuário o título, descrição, data de vencimento e prioridade da tarefa. Cria uma nova instância de `TaskService` e a adiciona à lista de tarefas.



- Remove

Remove uma tarefa especificada pelo usuário da lista de tarefas.

Parâmetros:

List<TaskService> Lista_de_Tarefas

Lógica:

Solicita ao usuário o nome da tarefa a ser removida e remove a tarefa correspondente da lista.



- Update

Atualiza o status de uma tarefa especificada pelo usuário.

Parâmetros:

List<TaskService> Lista_de_Tarefas

Lógica:

Solicita ao usuário o nome da tarefa e atualiza seu status para "Finalizada" caso tenha sido concluída.



- ListTask

Lista todas as tarefas, exibindo suas informações.

Parâmetros:

List<TaskService> Lista_de_Tarefas

Lógica:

Exibe a lista de todas as tarefas, pendentes ou finalizadas, com suas respectivas informações.



- CheckTask

Verifica e atualiza o status das tarefas com base na data atual.

Parâmetros:

List<TaskService> Lista_de_Tarefas

Lógica:

Compara a data de vencimento das tarefas com a data atual e atualiza o status para "Expirada" se a tarefa não tiver sido concluída a tempo.



<br>
## Estrutura do Código

O código é estruturado em uma interface `ITaskRepository` que define os métodos básicos para gerenciar tarefas, e uma classe `TaskService` que implementa esta interface. A classe `Program` contém o método `Main` que serve como ponto de entrada da aplicação, gerenciando o loop principal de interação com o usuário e chamando os métodos apropriados com base na opção selecionada.


<br>
## Conclusão

Esta documentação fornece uma visão geral do projeto de Gestão de Tarefas, detalhando o objetivo, a linguagem e as bibliotecas utilizadas, além de descrever as funcionalidades implementadas. 


