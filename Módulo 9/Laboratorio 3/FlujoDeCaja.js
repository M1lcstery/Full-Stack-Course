function VerificarFlujoDeCaja()
{
	var Ingresos = 0;
	var Egresos = 0;

	for (var i = 0; i < FlujoDeCaja.length; i++) {
		var Actual = FlujoDeCaja[i];
		Ingresos += Actual.ingresos;
		Egresos += Actual.egresos;    
	}

	if(Ingresos > Egresos)
		return 1;
	else if(Ingresos < Egresos)
		return -1;
	else
		return 0;
}

