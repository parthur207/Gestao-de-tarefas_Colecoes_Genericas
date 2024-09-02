<h1 align="center"> Gerenciador de Tarefas - Coleções genéricas</h1>

## Descrição

Este projeto é um Sistema de gestão de Tarefas desenvolvido em C#. O sistema oferece muitas funcionalidades úteis, permitindo adicionar, remover, atualizar, listar e verificar o status de tarefas.

## Funcionalidades Principais

### 1. Adição de tarefas

- Realiza adições de tarefas diretamente a uma lista, sendo necessário o informe de variados atributos que terão importancia para o restante das funcionalidades do sistema.
Propriedades na inserção de uma nova tarefa: Titulo da tarefa, descrição da tarefa, Data de vencimento e Prioridade da tarefa.

<br>

### 2. Descarte de tarefas
- O segundo método presente é a remoção de tarefas pelo informe de seu nome, isso fornece ao usuário a tomada de decisão por tarefas irrelevantes, concluídas ou errôneas.

<br>

### 3. Atualização do status das tarefas
- Oferece a possibilidade de mudança do status da tarefa após sua conclusão, podendo alterar seu status para "Finalizada", ou manter como "pendente".

<br>

### 4. Listagem de Tarefas

- O método possui o propósito de listar todas as tarefas inseridas na lista, independente de seu status, sendo essencial para uma visualização precisa das tarefas, seus atributos e seu status atual.
- Além disso, o mesmo efetua uma listagem de tarefas com datas próximas a vencer, trazendo a exibição de tarefas na véspera da data da máquina do usuário e tarefas com 

<br>

## Tecnologias Utilizadas
- **Linguagem de Programação**: C#
- Framework: .NET
- **Fundamentos**: Programação orientada a objetos, Interface, Herança, estruturação de dados, listas, e lógica de programação.
- **Bibliotecas Utilizadas**: `System`, `System.Collections.Generic`
 
<br>

## Como Executar:
1. Clone o repositório:
   ```bash
   
   git clone (https://github.com/parthur207/Gestao-de-tarefas.git)
   

<br>
   
## Estrutura do Projeto

#### Interface.cs: 
- ITaskRepository:
Define a estrutura básica para as operações de adicionar, remover, atualizar, listar e verificar tarefas.

#### Task.cs:
- Classe Task:
  Possui a declaração de todos os atributos utilizados pelo sistema, ja ditando suas respectivas regras/restrições. 

#### TaskService.cs:
- Classe TaskService:
Implementa a interface ITaskRepository e define a estrutura das tarefas, além de conter os métodos para gerenciar as tarefas.

#### Program.cs:
- Classe Program/Main:
Contém o método Main que gerencia a interação com o usuário e executa as operações disponíveis.

<br>

## Contato:

Email: parthur207@gmail.com 
| Telefone: 31 9 8965-0406 |
LinkedIn: www.linkedin.com/in/paulo-andrade-836956237


