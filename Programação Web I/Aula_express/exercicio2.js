const express = require('express');
const app = express();

app.get('/api/produto', (_, res) => {
    res.json({
        nome: 'Wanessa',
        preço: '19,99'
    });
});

app.listen(3000);