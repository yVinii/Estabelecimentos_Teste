<a name="Estabelecimentos_Teste"></a>
# Aplicativo web de estabelecimentos


Versão: 1.0


<a name="Status do Projeto"></a>
## 🔹 Status do Projeto : 


✅Finalizado


<a name="Descrição do Projeto"></a>
## 🔹 Descrição do Projeto :


O projeto consiste em um aplicativo web para um gerenciamento completo de estabelecimentos.


<a name="Recursos Principais"></a>
## 🔹 Recursos Principais :

**Visualização de Estabelecimentos :** 📋

Tabela com os dados dos estabelecimentos, paginação, filtro de pesquisa e ordenação.
Botões interativos para navegação, criação, edição e deleção dos estabelecimentos.

**Área de Cadastro :** 📝

Formulário para criação de novos estabelecimentos, com validações e máscara quando necessário.
Botões interativos para navegação, confirmar criação e voltar.


**Área de Edição :** ✏️

Formulário para edição do estabelecimento selecionado, com validações e máscara quando necessário.
Botões interativos para navegação, confirmar edição e voltar.


**Confirmar Deleção :**  🗑️

Texto com Cnpj do estabelecimento selecionado para garantir a exclusão do dado selecionado.
Botões interativos para navegação, confirmar ou cancelar deleção.


**Objetivo :** :chart_with_upwards_trend:

Sistema para gerenciar estabelecimentos, com funções de criar, editar, buscar e deletar, garantindo integridade dos dados e com navegação facilitada devido à interface gráfica intuitiva. 


<a name="Benefícios"></a>
## 🔹Benefícios :

**Facilidade de Uso :**  🆓

Interface intuitiva para navegação rápida e eficiente.


**Informações úteis :**  :mag:

Gerenciamento completo dos estabelecimentos.


<a name="Pré-requisitos"></a>
## 🔹 Pré-requisitos :

Antes de iniciar a implementação e utilização do projeto, certifique-se de que os seguintes pré-requisitos foram atendidos:

**Banco de Dados :**  🏦


Configure um banco de dados para armazenar os estabelecimentos.
O Banco é acessado dentro do arquivo utilizando os comandos:


>  Add-Migration CriandoTabelasEstacionamento -Context 


>  Update-Database -Context BancoContext


Recomendado: Utilize um banco de dados relacional, como SQL Server.


**Git (Opcional):**  :octocat:


Para colaboração e controle de versão, é útil ter o Git instalado. Você pode baixá-lo em [git](https://git-scm.com/.)


**Configuração do Ambiente :**  🖥️


Configure as variáveis de ambiente necessárias, como as credenciais do banco de dados e outras informações sensíveis.
Certifique-se de seguir as instruções de instalação específicas do projeto no README para garantir uma configuração adequada.


<a name="Como rodar a aplicação"></a>
## 🔹 Como rodar a aplicação :


### Para rodar a aplicação Estabelecimento_Teste localmente, siga estas instruções ⚠️


**Clone este repositório : :octocat:**

>git clone https://github.com/yVinii/Estabelecimentos_Teste.git


Navegue até o diretório do projeto:

Configure as variáveis de ambiente:

>Altere o arquivo na raiz do projeto no arquivo Program.cs e defina as variáveis necessárias, como as credenciais do banco de dados.


Abra o prompt do projeto

Utilize o comando pra utilizar o banco de dados localmente:

>  Add-Migration CriandoTabelasEstacionamento -Context 


>  Update-Database -Context BancoContext


Execute a Aplicação em sua IDE

Acesse a aplicação no navegador:

>http://localhost:5013

### Observações:

Certifique-se de ter o banco de dados configurado corretamente antes de iniciar a aplicação.
Modifique as configurações no arquivo Program.cs conforme necessário para o seu ambiente.
Consulte a documentação do projeto para informações específicas sobre a configuração.

<a name="Testes realizados"></a>
## 🔹 Testes realizados : 

O projeto passou por uma bateria de testes para garantir o correto funcionamento de suas funcionalidades no backend como realizar operações CRUD (Create, Read, Update, Delete) nas entidades do sistema. 

Conclusão:
Os testes do backend garantiram que o CRUD estava totalmente funcional, manipulando corretamente as entidades do sistema. Asseguramos que todas as funções respondessem conforme esperado, proporcionando uma base sólida para o desenvolvimento e a entrega bem-sucedidos do projeto.

<a name="Banco de Dados"></a>
## 🔹 Banco de Dados 🗂️

O banco de dados utilizado no projeto foi o SQL Server 

<a name="Linguagens, dependências e bibliotecas utilizadas"></a>
## 🔹 Linguagens utilizadas 📚

O Backend foi desenvolvido utilizando um conjunto específico de tecnologias e linguagens. Abaixo está uma descrição detalhada desses componentes:

Linguagens Utilizadas:
C#: A linguagem para o desenvolvimento do backend.

Conclusão:
O backend foi construído com base em tecnologias modernas, aproveitando as vantagens para desenvolvimento web.

Descrição Técnica do Frontend

O frontend do projeto foi desenvolvido com foco na criação de uma experiência de usuário interativa e intuitiva. Abaixo estão as tecnologias e linguagens utilizadas:

Linguagens Utilizadas:

HTML (HyperText Markup Language):
Descrição: Linguagem de marcação que define a estrutura básica de uma página web.
Uso: Responsável por estruturar o conteúdo da página.

CSS (Cascading Style Sheets):
Descrição: Linguagem de estilo que controla a apresentação visual de documentos HTML.
Uso: Aplica estilos, como layout, cores e fontes, para melhorar a estética e a usabilidade.

JavaScript:
Descrição: Linguagem de programação que permite a criação de interações dinâmicas e reativas em páginas web.
Uso: Manipula o DOM (Document Object Model) para criar comportamentos interativos.
Bibliotecas e Frameworks:

Bootstrap:
Descrição: Framework de código aberto que simplifica o design responsivo e a criação de interfaces web.
Uso: Fornece estilos predefinidos e componentes para melhorar a consistência visual e a responsividade.

Visual Studio 2022:
Descrição: Visual Studio é uma IDE da Microsoft que oferece ferramentas abrangentes para desenvolvimento de aplicativos para diversas plataformas, incluindo Windows, web, móveis e nuvem.

Conclusão:
O frontend foi construído com HTML, CSS e JavaScript, aproveitando frameworks e bibliotecas populares para acelerar o desenvolvimento e garantir uma experiência visual moderna e responsiva. O Bootstrap proporcionou uma base sólida para o design. O Visual Studio 2022 serviu como ambiente de desenvolvimento eficiente, oferecendo ferramentas robustas para a criação e manutenção do código. O resultado é uma interface web interativa e funcional, projetada para atender às necessidades dos usuários finais.


<a name="Funcionalidades"></a>
## Funcionalidades ⚙️

✔️ Gerenciamento de Estabelecimentos:
    Adição, remoção e edição de informações de estabelecimentos.
    Validações, máscaras e descrição completa dos estabelecimentos.

✔️ Visualização de Estabelecimentos:
    Página desenvolvida para uma tabela com informações abrangentes dos estabelecimentos.
    Tabela possui paginação, ordenação e pesquisa.

<a name="Distribuição"></a>
## 🔹 Distribuição :

Finalizado:

O sistema foi finalizado e pode ser acessado por meio do repositório no GitHub.
Os usuários podem explorar o código-fonte, testar funcionalidades em desenvolvimento e fornecer feedback valioso.
Infelizmente, não consegui subir meu projeto, pois para o funcionamento completo do aplicativo web, era necessário um servidor na Azure ou outro serviço de hospedagem.

Ambiente Local de Desenvolvimento:
Desenvolvedores podem configurar um ambiente local para executar o sistema e testar o sistema.
Consulte o arquivo README no repositório para instruções de configuração do ambiente.

Código-Fonte Aberto:
O código-fonte do sistema é totalmente aberto e disponível para consulta, aprendizado e colaboração.
Acesse o repositório no GitHub para explorar o código.

Licença Open Source:
O sistema é distribuído sob uma licença de código aberto para promover a transparência e a participação da comunidade no desenvolvimento.

Copyright ©️ 2024 - Estabelecimentos_Teste
