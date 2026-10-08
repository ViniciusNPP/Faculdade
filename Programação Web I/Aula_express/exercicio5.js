const express = require('express')
const app = express();

app.get('/usuarios', (_, res) => {
    const alunos = [
        {
            nome: 'Beatrice',
            idade: '13'
        },
        {
            nome: 'Valência',
            idade: '10'
        },
        {
            nome: 'José Jayme',
            idade: '81'
        }
    ];

    res.json(alunos);
});

app.listen(3000);