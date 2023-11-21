var Ofertas = [
    {
        nombre: "Plan001",
        capital: 150000,
        plazo: 30,
        tasa: 0.15
    },
    {
        nombre: "Plan002",
        capital: 300000,
        plazo: 180,
        tasa: 0.1
    },
    {
        nombre: "Plan003",
        capital: 485000,
        plazo: 60,
        tasa: 0.23
    }
];

var OfertasConInteres = [];

for (var i = 0; i < FlujoDeCaja.length; i++) {
    var Actual = Ofertas[i];
    var Interes = (Actual.capital * Actual.plazo * Actual.tasa) / 100;
    OfertasConInteres.push({
        nombre: Actual.nombre,
        capital: Actual.capital,
        plazo: Actual.plazo,
        tasa: Actual.tasa,
        interes: Interes
    });
}

console.log(OfertasConInteres)
