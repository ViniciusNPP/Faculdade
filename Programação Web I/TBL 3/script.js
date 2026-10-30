
// document.querySelector('.botao').addEventListener('click', () => {
//     fetch('http://localhost:3000/usuarios')
// .then(res => res.json())
// .then(data => console.log(data))
// .catch(erro => console.error('Erro na requisição:', erro));
// });

document.querySelector('.botao').addEventListener('click', () => {
    fetch('http://localhost:3000/usuarios')
.then(res => res.json())
.then(data => console.log(data))
.catch(erro => console.error('Erro na requisição:', erro));
});