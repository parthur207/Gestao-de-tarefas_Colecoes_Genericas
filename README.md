Parte 1: Questões Teóricas

1. Explique o que são os princípios SOLID e como cada um deles pode ser aplicado em um projeto desenvolvido em .NET.

2. Quais são os principais padrões de arquitetura de software utilizados em aplicações .NET? Descreva dois desses padrões e seus benefícios.

3. Por que é importante separar a lógica de negócios da lógica de apresentação em uma aplicação .NET? Como isso pode ser alcançado?

4. Como alcançar essa separação:

Respostas:

1. O SOLID se trata de uma metodologia utilizada no incremento de desenvolvimento de softwares, possuindo 5 pilares de grande importância, trazendo maior coesão, efetividade, legibilidade e tornando o código flexivel para ocorrer formatações, manutenções, ou novos incrementos.

Primeiro pilar: Single responsibility principle  

* Basicamente, este princípio adverte que um conteúdo pode ter somente uma função, ou dever. Isso significa que em uma codificação com a presença de uma classe, devemos atribuir somente uma responsabilidade/funcionalidade a mesma.
Como ponto positivo, isso reduz o acoplamento entre as classes e facilita muito a manutenção, leitura e implantação de novas metodologias ao código.


Segundo pilar: Open/Closed principle

* Este principio afirma que um software deve permitir a sua extensão, mas restringir sua modificação. Em esclarecimento, esse pilar recomenda a implementação/manutenção de um código sem que isso infrinja diretamente na estrutura do código fonte.
A partir desse principio, é possível efetuar ações de melhoria, ou inserções de novas funcionalidades em um sistema de forma mais segura, reduzindo bugs.


Terceiro pilar: Liskov Substition principle

* O princípio da substituição de Liskov traz a tona que uma subclasse deve ser capaz de substituir sua classe base em qualquer contexto sem que o comportamento padrão do programa seja alterado.
Com isso, este principio se relaciona com a recomendação de utilizar interfaces, definindo contratos e promovendo a alteração das classes sem alterar seu comportamento padrão.


Quarto Pilar: Interface segregation principle

* O princípio estipula que é mais benéfico a implementação de várias interfaces específicas do que apenas uma com código em abundância. 
Isso evita que as classes implementam métodos desnecessários e traz mais coesão ao programa.


Quinto pilar: Dependecy inversion principle 

* O quinto pular adverte que os módulos de alto nível devem ter dependência somente as abstrações e não a modulos de baixo nível. Tal pilar é constantemente usado, pregando que classes devem depender de interfaces, ou classes abstratas, fazendo a injeção de independência.


2. Pode-se citar o MVC (Model View Controller), MVVM (Model View ViewModel) e Microservices como os principais padrões de arquitetura utilizados nas aplicações .NET.

* O MVC é um padrão que faz a divisão da aplicação em três partes: a primeira é a 'Model', representando a lógica de dados, a segunda é a 'View' apresentando os dados ao usuário e a última se trata da 'Controller' tendo o intuito de integrar com o 'Model' e a 'View' controlando o fluxo da aplicação. 
* Microservices é outro padrão arquitetural em que cada um dos componentes de um software é dividido em serviços pequenos, com distribuição e autonomia, executando um processo único. Sua implementação é positiva por trazer escalabilidade, flexibilidade e legibilidade para as manutenções e atualizações.


3. É de grande importância separar esses termos para ter um código melhor, no sentido de fornecer melhor legibilidade, reutilização e manutenção de estruturas.
Isso fornece facilidade de testes, reutilização em outras estruturas do código e manutenção ao ter o propósito de alteração determinada lógica, estrutura ou inserções de novas ações.


3.1 - É possível separar tais termos com a utilização dos padrões de arquitetura citados na questão 2: MVC, MVVM, Microservices, etc.



