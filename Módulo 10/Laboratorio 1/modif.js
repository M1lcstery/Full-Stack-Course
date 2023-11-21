let numeroActual = 0;

do {

    let numeroActual = Number(prompt("Ingrese el número actual"));
    let suma = (numeroActual) => {
        suma += numeroActual;
    };

} while ((continuar = confirm("¿Desea seguir ingresando números?")))

alert(`Total ingresado: ${suma}`);


