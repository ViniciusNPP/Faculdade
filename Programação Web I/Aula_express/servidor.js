// const http = require('http');

// const servidor = http.createServer((req, res) => {
//     if (req.url === '/usuarios') {
//         res.setHeader('Content-Type', 'application/json');
//         res.end(JSON.stringify({nome:'Ana'}));
//     } else {
//         res.end("Rota inválida");
//     }
// });

// servidor.listen(3000);
const express = require('express')
const app = express();

app.get('/', (req, res) => {
    res.send("Página inicial");
});

// Página sobre
app.get('/sobre', (req, res) => {
    res.send("Página sobre");
});

// Página contato
app.get('/contato', (req, res) => {
    res.send("Página contato");
});

// Mostrando json
app.get('/api', (req, res) => {
    res.json({
        nome: 'Carlos',
        idade: 29
    });
});

// Captura de id dentro da url
app.get('/usuarios/:id', (req, res) => {
    const id = req.params.id;

    res.json({
        id: id,
        mensagem: "Seja bem vindo usuário"
    });
});

// Query string
app.get('/buscar', (req, res) => {
    const nome = req.query.nome;

    res.json({resultado: nome});
});

app.listen(3000);