const menu_botao = document.querySelector("#menu-botao");
const sobre_botao = document.querySelector("#botao-sobre");
const projetos_botao = document.querySelector("#botao-projetos");
const tema_botao = document.querySelector("#botao-tema");

const janela_sobre = document.querySelector(".sobre");
const janela_projetos = document.querySelector(".projetos")

let monstrando_sobre = false;

sobre_botao.addEventListener("click", () => {
    if (monstrando_sobre) {
        janela_sobre.style.display = "none";
        monstrando_sobre = false;
    } else if (!monstrando_sobre) {
        janela_sobre.style.display = "block";
        monstrando_sobre = true;
    }
});

let monstrando_projetos = false;

projetos_botao.addEventListener("click", () => {
    if (monstrando_projetos) {
        janela_projetos.style.display = "none";
        monstrando_projetos = false;
    } else if (!monstrando_projetos) {
        janela_projetos.style.display = "flex";
        monstrando_projetos = true;
    }
})

let tema = true;
const header_container = document.querySelector(".header-container");
const footer_container = document.querySelector(".footer-container");

tema_botao.addEventListener("click", () => {
    if (tema) {
        tema = false;
        tema_botao.textContent = "Claro";

        header_container.style.backgroundColor = "#ffff";
        footer_container.style.backgroundColor = "#ffff";
    } else if (!tema) {
        tema = true;
        tema_botao.textContent = "Escuro";

        header_container.style.backgroundColor = "rgb(90, 90, 90)";
        footer_container.style.backgroundColor = "rgb(90, 90, 90)";
    }
});