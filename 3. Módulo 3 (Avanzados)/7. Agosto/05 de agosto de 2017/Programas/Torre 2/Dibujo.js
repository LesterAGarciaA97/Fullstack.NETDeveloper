alert("Pintar Torre2");
var Texto = document.getElementById('txtLineas');
var Boton = document.getElementById('btnDibujar');
Boton.addEventListener("click", Dibujar);
var Dibujo = document.getElementById("Dibujo");
var Ancho = Dibujo.width;
var Lienzo = Dibujo.getContext("2d");

function Dibujar()
{
  var Lineas = parseInt(Texto.value);
  var L = 0;
  var ColorPreferido = "#FF0000";
  var Espacio = Ancho/Lineas;
  for (L=0;L < Lineas;L++)
  {
    yI = Espacio *L;
    xF = Espacio *(L+1);
    DibujarLineas(ColorPreferido,0,yI,xF,300);
  }
  DibujarLineas("#000",1,1,1,299);
  DibujarLineas("#000",1,299,299,299)
}

function DibujarLineas(color,xinicial,yinicial,xfinal,yfinal)
{
  Lienzo.beginPath();
  Lienzo.strokeStyle = color;
  Lienzo.moveTo(xinicial,yinicial);
  Lienzo.lineTo(xfinal,yfinal);
  Lienzo.stroke();
  Lienzo.closePath();
}
