var btnGenerar = document.getElementById("btnAleatorio");
var Minimo = document.getElementById("txtMinimo");
var Maximo = document.getElementById("txtMaximo");
btnGenerar.addEventListener("click",Aleatorio);

function Aleatorio()
{
  var Resultado;
  var Min = parseInt(Minimo.value);
  var Max = parseInt(Maximo.value);
  Resultado = Math.floor(Math.random()*(Max - Min +1)) + Min;
  console.log(Resultado);
}
