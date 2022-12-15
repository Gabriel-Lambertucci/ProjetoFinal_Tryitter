# Boas vindas ao repositório da minha Api feita para o Projeto Final da Aceleração C#!

<details>
  <summary><strong>Como foi desenvolvido</strong></summary><br />
  
  <p> A linguagem utilizada no projeto foi C#.  </p>
  <p> Para tornar mais real as simulações feitas através da aplicação, estou utilizando um banco SqlServer conteineirizado, para guardar e buscar informações de forma dinâmica. </p>
  <p> Api produzida com camadas de controllers e models.</p>
</details>

<details>
  <summary><strong>Rodando no Docker</strong></summary><br/>

   <p> Rode o serviço de banco com o comando `docker-compose up -d`.</p>
   <p> A partir daqui você já pode rodar a aplicação com 'dotnet run' e fazer as chamadas através do Swagger para ver as respostas</p>
</details>

<details>
   <summary><strong> Rodando Testes </strong></summary><br />

  <p> Para inicar os testes da aplicação é muito simples. entre na pasta de testes e rode o comando dotnet test.</p>
   <p> São 4 testes que testam de forma bem completa a aplicação, mas claro que quanto mais melhor e isso está no meu planejamento para o futuro!</p>
   <br/>
</details>

<details>
   <summary><strong> EndPoints </strong></summary><br />

  <p> A Api está documentada através do SwaggerUI. </p>
  <p> A aplicação está configurada para que ao ser iniciada já vá diretamente para a página do Swagger </p>
</details>

<details>
  <summary><strong>Funcionamento da Api</strong></summary><br />
  
 <p> Novos usuários conseguem se cadastrar </p>
 <p> Usuários conseguem fazer suas postagens </p>
 <p> Não é possível fazer um post sem antes ter se cadstrado </p>

