// Exercício 1
// const express = require('express');
// const cors = require('cors');
// const app = express();
// app.use(cors());
// app.get('/usuarios', (req, res) => {
//     res.json([
//         { id: 1, nome: 'Ana' }
//     ]);
// });
// app.listen(3000, () => {
//     console.log('Servidor rodando na porta 3000');
// });

// Teste 1
// const express = require('express');
// const app = express();

// app.get('/usuarios', (req, res) => {
//     res.json([
//         { id: 1, nome: 'Ana' }
//     ]);
// });
// app.listen(3000, () => {
//     console.log('Servidor rodando na porta 3000');
// });

// Teste 2
// const express = require('express');
// const cors = require('cors');
// const app = express();

// app.use(cors());
// app.get('/usuarios', (req, res) => {
//     res.json([
//         { id: 1, nome: 'Ana' }
//     ]);
// });
// app.listen(3000, () => {
//     console.log('Servidor rodando na porta 3000');
// });

// Origem igual ao do front
// const express = require('express');
// const cors = require('cors');
// const app = express();

// app.use(cors());
// app.get('/usuarios', (req, res) => {
//     res.json([
//         { id: 1, nome: 'Ana' }
//     ]);
// });
// app.listen(5500, () => {
//     console.log('Servidor rodando na porta 5500');
// });

const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors({ 
    origin: 'http://localhost:5500', 
    methods: ['GET'] 
}));

app.get('/usuarios', (req, res) => {
    res.json([
        { id: 1, nome: 'Ana' }
    ]);
});
app.listen(3000, () => {
    console.log('Servidor rodando na porta 3000');
});