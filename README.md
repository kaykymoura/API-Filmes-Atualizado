# 🚀 API Filmes

Esse é o projeto **API Filmes**! A ideia aqui é criar uma API simples que faz o básico de **CRUD** (Criar, Ler, Atualizar, Deletar) e se conecta a um banco de dados.

## 🛠️ O que usamos

- **Node.js**: Para rodar o servidor.
- **Express.js**: Framework que facilita criar a API.
- **MySQL Server**: Banco de dados para armazenar os dados.
- **Sequelize**: ORM para conectar o banco de dados à API.

## 🚀 Funcionalidades

A API tem essas rotas principais:

- **GET /api/genero**: Pega todos os gêneros de filmes.
- **POST /api/genero**: Cria um novo gênero de filme.
- **GET /api/genero/:id**: Pega um gênero específico.
- **PUT /api/genero/:id**: Atualiza um gênero.
- **DELETE /api/genero/:id**: Deleta um gênero.

## 🧑‍💻 Como rodar

1. Clone o repositório no seu computador.
2. Instale as dependências com o comando `npm install`.
3. Configure o banco de dados (MySQL Server) e conecte à API.
4. Rode o servidor com `npm start`.

## 🛠️ Como testar com o Postman

1. Abra o Postman e crie uma nova requisição.
2. Teste as rotas:
   - **GET /api/genero**: Vai te dar todos os gêneros.
   - **POST /api/genero**: Cria um novo gênero. Só mandar os dados no formato certo.
   - **GET /api/genero/:id**: Pega o gênero específico.
   - **PUT /api/genero/:id**: Atualiza um gênero, só mandar os novos dados.
   - **DELETE /api/genero/:id**: Deleta o gênero.

## 🚧 Tarefa Concluída

Agora você tem uma API funcionando! Usamos **Express** e **MySQL Server** para fazer tudo acontecer. Daqui pra frente, dá pra melhorar e adicionar mais funcionalidades, mas já tá bem legal!
