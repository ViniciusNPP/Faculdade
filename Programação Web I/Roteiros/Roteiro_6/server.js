const express = require('express');
const cors = require('cors');
const app = express();

app.use(express.json());
app.use(cors());
// Middleware de log
app.use((req, res, next) => {
    console.log(`${req.method} ${req.url}`);
    console.log(req.body);
    next();
});
let usuarios = [];
// CREATE
app.post('/usuarios', (req, res) => {
    const { nome, idade } = req.body;
    if (!nome || idade === undefined) {
        return res.status(400).json({
            sucesso: false,
            erro: 'Dados inválidos'
        });
    }
    const usuario = {
        id: usuarios.length + 1,
        nome,
        idade
    };
    usuarios.push(usuario);
    res.status(201).json({
        sucesso: true,
        dados: usuario
    });
});
// READ — listar
app.get('/usuarios', (req, res) => {
    res.json({
        sucesso: true,
        dados: usuarios
    });
});
// READ — buscar por ID
app.get('/usuarios/:id', (req, res) => {
    const id = parseInt(req.params.id, 10);
    const usuario = usuarios.find(u => u.id === id);
    if (!usuario) {
        return res.status(404).json({
            sucesso: false,
            erro: 'Não encontrado'
        });
    }
    res.json({
        sucesso: true,
        dados: usuario
    });
});
// UPDATE
app.put('/usuarios/:id', (req, res) => {
    const id = parseInt(req.params.id, 10);
    const { nome, idade } = req.body;

    const usuario = usuarios.find(u => u.id === id);
    if (!usuario) {
        return res.status(404).json({
            sucesso: false,
            erro: 'Não encontrado'
        });
    }
    if (!nome || idade === undefined) {
        return res.status(400).json({
            sucesso: false,
            erro: 'Dados inválidos'
        });
    }
    usuario.nome = nome;
    usuario.idade = idade;
    res.json({
        sucesso: true,
        dados: usuario
    });
});
// DELETE
app.delete('/usuarios/:id', (req, res) => {
    const id = parseInt(req.params.id, 10);
    const index = usuarios.findIndex(u => u.id === id);
    if (index === -1) {
        return res.status(404).json({
            sucesso: false,
            erro: 'Não encontrado'
        });
    }
    usuarios.splice(index, 1);
    res.json({
        sucesso: true,
        mensagem: 'Removido'
    });
});
app.listen(3000, () => {
    console.log('Servidor rodando em http://localhost:3000');
});

// Use npm install express para instalar o express
// Use npm install express cors para instalar o cors
