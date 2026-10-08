const express = require('express');
const app = express();

app.get('/', (_, res) => {
    res.send("Seja bem vindo usuário");
});

app.get('/sobre', (_, res) => {
    res.send("Quinta-feira, 8 de outubro este servidor foi criado.");
});

app.get('/contato', (_, res) => {
    res.send("Procura no insta para saber");
});

app.listen(3000);