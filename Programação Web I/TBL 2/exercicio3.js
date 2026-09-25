const http = require('http');

const produtos = [
    { id: 1, nome: 'Camisa', preco: 50 },
    { id: 2, nome: 'tenis', preco: 100 },
    { id: 3, nome: 'cueca', preco: 200 }
];

const servidor = http.createServer((req, res) => {

    if (req.url == '/api/produtos') {
        res.setHeader('Content-Type', 'application/json');
        res.end(JSON.stringify(produtos));
    }

    else if (req.url == '/api/produtos/1') {
        res.end(JSON.stringify(produtos[0]));
    }

    else if (req.url == '/api/produtos/2') {
        res.end(JSON.stringify(produtos[1]));
    }

    else if (req.url == '/api/produtos/3') {
        res.end(JSON.stringify(produtos[2]));
    }

    else {
        res.end('Página não encontrada');
    }
});

servidor.listen(3000, () => {
    console.log("Servidor rodando http://localhost/3000");
});