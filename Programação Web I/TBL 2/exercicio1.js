const http = require("http");

const servidor = http.createServer((http, res) => {
    const url = http.url;
    let dados = {};
    
    if (url.startsWith('/usuario/')) {
        res.emit("Pagina de usuarios");

        const id = Number(url.split('/').at(-1));
        console.log(id);

        if (!isNaN(id) && id != 0) {
            dados = {
                nome: `usuario${id}`,
                id: id
            }
            res.end(JSON.stringify(dados));
        } else {
            res.end("Pagina de usuarios")
        }
    } else {
        res.end("Pagina nao encontrada")
    }
});

servidor.listen(3000, () => {
    console.log("Servidor rodando http://localhost/3000");
});