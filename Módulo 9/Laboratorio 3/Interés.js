function AgregarInteres(Ofertas)
{
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

	return OfertasConInteres;
}

