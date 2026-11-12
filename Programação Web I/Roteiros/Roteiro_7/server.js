/*
======================================
            EXEMPLO 2
======================================
*/

// const express = require('express');
// const jwt = require('jsonwebtoken');
// require('dotenv').config();

// const app = express();
// app.use(express.json());

// const SECRET = process.env.SECRET;
// const PORT = process.env.PORT;
// // Simulação de banco de dados
// const usuarios = [
//     { id: 1, usuario: 'admin', senha: '123' }
// ];

// // Rota de login
// app.post('/login', (req, res) => {
//     const { usuario, senha } = req.body;
//     if (!usuario || !senha) {
//         return res.status(400).json({ erro: 'Preencha usuario e senha' });
//     }
//     const user = usuarios.find(u => u.usuario === usuario && u.senha === senha);
//     if (!user) {
//         return res.status(401).json({ erro: 'Credenciais inválidas' });
//     }
//     const token = jwt.sign(
//         {
//             id: user.id,
//             usuario: user.usuario
//         },
//         SECRET,
//         { expiresIn: '1h' }
//     );
//     res.json({ token });
// });

// // Middleware de autenticação
// function autenticarToken(req, res, next) {
//     const authHeader = req.headers['authorization'];
//     if (!authHeader) {
//         return res.status(401).json({ erro: 'Token não enviado' });
//     }
//     const token = authHeader.split(' ')[1];
//     jwt.verify(token, SECRET, (err, decoded) => {
//         if (err) {
//             return res.status(403).json({ erro: 'Token inválido ou expirado' });
//         }
//         req.usuario = decoded;
//         next();
//     });
// }
// // Rota protegida
// app.get('/perfil', autenticarToken, (req, res) => {
//     res.json({
//         mensagem: 'Acesso autorizado',
//         usuario: req.usuario
//     });
// });

// app.listen(3000, () => {
//     console.log('Servidor rodando em http://localhost:3000');
// });

/*
======================================
            EXEMPLO 2
======================================
*/
// require('dotenv').config();
// const express = require('express');
// const jwt = require('jsonwebtoken');
// const app = express();
// app.use(express.json());
// const SECRET = process.env.SECRET;

// // Middleware de autenticação
// function autenticarToken(req, res, next) {
//     const authHeader = req.headers['authorization'];
//     if (!authHeader) {
//         return res.status(401).json({ erro: 'Token não enviado' });
//     }
//     const token = authHeader.split(' ')[1];
//     jwt.verify(token, SECRET, (err, decoded) => {
//         if (err) {
//             return res.status(403).json({ erro: 'Token inválido ou expirado' });
//         }
//         req.usuario = decoded;
//         next();
//     });
// }

// app.post('/login', (req, res) => {
//     const { usuario, senha } = req.body;
//     if (usuario === 'admin' && senha === '123') {
//         const token = jwt.sign({ usuario }, SECRET, { expiresIn: '1h' });
//         return res.json({ token });
//     }
//     res.status(401).json({ erro: 'Credenciais inválidas' });
// });
// // Rota protegida
// app.get('/perfil', autenticarToken, (req, res) => {
//     res.json({
//         mensagem: 'Acesso autorizado',
//         usuario: req.usuario
//     });
// });
// app.listen(process.env.PORT || 3000);

/*
======================================
            EXEMPLO 3
======================================
*/

const express = require('express');
const jwt = require('jsonwebtoken');
const app = express();
app.use(express.json());
const SECRET = 'segredo_super_forte';
// "Banco de dados"
const usuarios = [
    { id: 1, usuario: 'admin', senha: '123', role: 'admin' },
    { id: 2, usuario: 'joao', senha: '123', role: 'user' }
];
// LOGIN
app.post('/login', (req, res) => {
    const { usuario, senha } = req.body;
    const user = usuarios.find(u => u.usuario === usuario && u.senha === senha);
    if (!user) {
        return res.status(401).json({ erro: 'Credenciais inválidas' });
    }
    const token = jwt.sign(
        {
            id: user.id,
            usuario: user.usuario,
            role: user.role
        },
        SECRET,
        { expiresIn: '1h' }
    );
    res.json({ token });
});
// MIDDLEWARE DE AUTENTICAÇÃO
function autenticarToken(req, res, next) {
    const authHeader = req.headers['authorization'];
    if (!authHeader) {
        return res.status(401).json({ erro: 'Token não enviado' });
    }
    const token = authHeader.split(' ')[1];
    jwt.verify(token, SECRET, (err, decoded) => {
        if (err) {
            return res.status(403).json({ erro: 'Token inválido' });
        }
        req.usuario = decoded;
        next();
    });
}
// MIDDLEWARE DE AUTORIZAÇÃO (ROLE)
function autorizarRole(roleNecessaria) {
    return (req, res, next) => {
        if (!req.usuario) {
            return res.status(500).json({ erro: 'Usuário não carregado' });
        }
        if (req.usuario.role !== roleNecessaria) {
            return res.status(403).json({ erro: 'Acesso negado' });
        }
        next();
    };
}
// ROTAS
app.get('/perfil', autenticarToken, (req, res) => {
    res.json({ usuario: req.usuario });
});
app.get('/admin',
    autenticarToken,
    autorizarRole('admin'),
    (req, res) => {
        res.json({ mensagem: 'Área administrativa' });
    }
);
app.listen(3000, () => {
    console.log('Servidor rodando em http://localhost:3000');
});

// Use npm install express para o pacote express
// Use npm install express dotenv para pacote env
// Use npm install express jsonwebtoken para o pacote jsonwebtoken
