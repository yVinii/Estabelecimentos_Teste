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
O frontend foi construído com HTML, CSS e JavaScript, aproveitando frameworks e bibliotecas populares para acelerar o desenvolvimento e garantir uma experiência visual moderna. O Bootstrap proporcionou uma base sólida para o design. O Visual Studio 2022 serviu como ambiente de desenvolvimento eficiente, oferecendo ferramentas para a criação e manutenção do código. O resultado é uma interface web interativa e funcional, projetada para atender às necessidades dos usuários finais.


<a name="Funcionalidades"></a>
## Funcionalidades ⚙️

✔️ Gerenciamento de Estabelecimentos:
    Adição, remoção e edição de informações de estabelecimentos.
    Validações, máscaras e descrição completa dos estabelecimentos.

✔️ Visualização de Estabelecimentos:
    Página desenvolvida para uma tabela com informações abrangentes dos estabelecimentos.
    Tabela possui paginação, ordenação e pesquisa.


<a name="Views do Projeto"></a>
## Tela de Início
Nessa tela encontramos a navegação pelo header intuitivo, e o futher que serão o padrão no layout do aplicativo web.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/d7557e09-8f03-4b00-bf3f-a985c44770f7)



## Listagem 📋
Na tela de listagem temos controle de todos os estabelecimentos, em uma tabela que mostra seus dados, um botão para adicionar novos estabelecimentos, e para cada elemento da tabela 2 botões, editar e apagar.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/029d08f8-a985-4748-a958-7db20d9c29e1)


Podemos observar o serviço de paginação, como temos poucos dados não é necessária a páginação dos elementos:
![estabelecimento_paginacao](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/d2f4c637-e5ad-47ad-9b7e-9185af7e7d1d)


Aqui temos o serviço de pesquisa que funciona pra todo e qualquer atributo da tabela, do nome até conta:
![estabelecimento_pesquisa](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/d79c4b73-857c-41ad-ae7d-d97d4fbb0092)


E por fim o sistema de ordenação, seja por ordem do alfabeto até de numeração
![estabelecimento_ordenação](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/c35c384d-899e-4432-a34f-7fbeeb090b4c)


## Cadastro
No cadastro encontramos o formulário e o botão de voltar, quando pressionado retornará à tela de listagem.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/a89ae974-017c-4f7f-a149-2de6b1fb6be4)


Em uma visão ampla da tela obtemos acesso ao formulário completo e o botão de enviar que sua função é por fim cadastrar o estabelecimento.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/531db1bd-8830-4337-8ffe-3ca563ba936e)


Preenchendo todos os dados em visão ampla teremos esse resultado:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/c7bd075b-d0a4-4409-9a29-2b2a37f59955)


## Edição
Na edição encontramos o formulário preenchido com as informações do estabelecimento selecionado, e um botão de voltar, que quando pressionado retornará à tela de listagem.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/45af4428-08ce-4b4e-a42d-a3ea7610791b)


Em uma visão ampla da tela obtemos acesso ao formulário preenchido e completo, e o botão de alterar que sua função é por fim cadastrar o estabelecimento.
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/4413f1fd-ce94-4fff-aaa9-1e6d4ba9dffd)


## Apagar
Na tela de confirmação de deletar, temos esse layout com o cnpj do estabelecimento selecionado, e com 2 botões, voltar ou confirmar a deleção
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/c8cc3620-ebd8-4051-a898-6be644a8234b)


## Validações
Nas telas de cadastro e edição teremos as validações


Caso o email sejá inválido:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/7ec0ffa0-fec7-4d79-b242-7200a8b7238f)


Caso o cnpj seja inválido:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/9cd33340-6673-4678-893e-97e87171d6b1)


Caso o telefone seja inválido:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/c6a8f564-ad6c-4524-b664-34e664043d4e)


Caso a data sejá inválida (futuro):
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/a69d58c5-b649-4a1a-a1f2-b712f4fdff25)


Caso a categora seja supermercado o telefone é necessário:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/a1bfd868-1ec8-4376-8c68-4237d3b6cf40)


Caso a agência não esteja de acordo com o padrão:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/efec20df-78f7-42f2-b8a8-76d231fd3e01)


Caso a conta não esteja de acordo com o padrão:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/0d50039c-1d94-4f0d-ba9d-2cf7e5df5def)


Quando o estabelecimento for cadastrado:
![estabelecimento_cadastrado](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/4cb65c39-fee9-4f85-a887-70cd352473e2)


Quando o estabelecimento for editado:
![estabelecimento_editado](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/3f292779-6c57-4096-9cc3-278dd70a6054)


Quando o estabelecimento for deletado:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/56f2a5a6-ab2d-44ff-a5a1-01185b3a6d7a)


## Máscaras
As telas de cadastro e edição também possuem em seu formulário o processo de máscara em alguns de seus itens
Começando com o cnpj que obtém esse formato preenchido:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/b2406679-6655-4c93-9a9c-aa2a3e9b69ac)


O telefone também utiliza desse recurso:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/38b49112-155f-4052-bd5c-951622ae42f8)


A data como padrão vem nesse modelo:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/24953a49-d793-427f-b810-a36805d44b7d)


Podendo ser selecionada com auxílio de um calendário:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/0c8e7179-f972-4748-89d7-fed544f832e2)


Ou de maneira padrão digitando dia, mês e ano:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/33571d66-3fe2-4025-a6cf-164071a97681)


O atributo de agência também possui o recurso:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/b2bf7f52-4a38-4d24-a3ed-a5768e3d70ed)


E por fim o modelo de conta:
![image](https://github.com/yVinii/Estabelecimentos_Teste/assets/117307556/bf7f124e-527e-4953-8d5e-c1aa9d93b13a)


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
