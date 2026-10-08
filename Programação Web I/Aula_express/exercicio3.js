const express = require('express');
const app = express();

app.get('/usuarios/:id', (req, res) => {
    const id = req.params.id;

    res.json({
        id: id,
        mensagem: "Seja bem vindo usuário"
    });
});

app.listen(3000);