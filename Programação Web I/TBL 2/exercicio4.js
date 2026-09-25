const http = require('http');

let contador = 0;

const servidor = http.createServer((req, res) => {

    if (req.url == '/contador') {

        contador++;

        res.setHeader('Content-Type', 'application/json');

        res.end(JSON.stringify({
            acessos: contador
        }));

    } else {
        res.end('Página não encontrada');
    }
});

servidor.listen(3000, () => {
    console.log("Servidor rodando http://localhost/3000");
});