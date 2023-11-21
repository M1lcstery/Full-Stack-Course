function changeColor(color) {

    var enunciado = document.getElementById("main");

    switch (color) {

        case "rojo":
        default:
            enunciado.innerHTML = "<h1 style=\"background-color: red;\"> Hola, mi color es Rojo </h1>";
            break

        case "azul":
            enunciado.innerHTML = "<h1 style=\"background-color: blue;\"> Hola, mi color es Azul </h1>";
            break

        case "verde":
            enunciado.innerHTML = "<h1 style=\"background-color: green;\"> Hola, mi color es Verde </h1>";
            break

        case "amarillo":
            enunciado.innerHTML = "<h1 style=\"background-color: yellow;\"> Hola, mi color es Amarillo </h1>";
            break
    }
}