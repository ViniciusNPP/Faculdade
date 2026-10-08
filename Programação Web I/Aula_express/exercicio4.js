const express = require('express')
const app = express();

app.get('/buscar', (req, res) => {
    const nome = req.query.nome;

    res.json({resultado: nome});
});

app.listen(3000);