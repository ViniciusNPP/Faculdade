const http = require("http");
const metodo = "GET";

const servidor = http.createServer((http, res) => {
    if (http.url.startsWith("/teste")) {
        if (http.method === metodo) {
            res.end("Sessao de teste");
        } else {
            res.end("ERRO 405");
        }
    } else {
        res.end("Sessao normal");
    }
});

servidor.listen(3000, () => {
    console.log("Servidor rodando http://localhost/3000");
});