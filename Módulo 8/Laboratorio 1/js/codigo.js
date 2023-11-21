
var respuesta = window.prompt('Cuál es su rol?');
if (respuesta == 'admin' || respuesta == 'recursos') {

    var clave = prompt('Cual es su clave?')




    if (clave == 1234) {


        var usuario = prompt('Cual es su nombre de usuario?')





    }

}

else { window.location.href = 'error.html' }








document.querySelector('#header').innerHTML = '<h1> Hola ' + usuario + ' bienvenido a nuestra aplicación</h1>'

var empleados = [{ nombre: 'Juan', apellido: 'Pedro', edad: 40 }, { nombre: 'Ana', apellido: 'García', edad: 25 }, { nombre: 'Maria', apellido: 'Zarate', edad: 34 }]



mensaje = '<tr><th> Nombre </th><th>Apellido</th><th>Edad</th></tr>'
for (i = 0; i < empleados.length; i++) {

    mensaje += '<tr><td>' + empleados[i].nombre + '<td>' + empleados[i].apellido + '</td><td>' + empleados[i].edad + '</td></tr>'


}


document.getElementById('caja').innerHTML += mensaje



