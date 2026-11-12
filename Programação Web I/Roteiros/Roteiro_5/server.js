const express = require('express');
const app = express();

// Importa o conjunto de rotas de usuários
const usuariosRoutes = require('./routes/usuariosRoutes');

// Todas as rotas desse conjunto começarão com /usuarios
app.use('/usuarios', usuariosRoutes);
app.listen(3000, () => {
    console.log('Servidor rodando em http://localhost:3000');
});

//Use npm install express para instalar o pacote express
