document.addEventListener("keydown",ImprimirTecla);
var Dibujo = document.getElementById("AreaDibujo");
var Papel = Dibujo.getContext("2d");
var x = 150;
var y = 150;
var Teclas =
{
  UP: 38,
  DOWN: 40,
  LEFT: 37,
  RIGHT: 39
}
DibujarLineas("red",x,y,x+1,y+1,Papel);
function DibujarLineas(color,xinicial,yinicial,xfinal,yfinal,lienzo)
{
  lienzo.beginPath();
  lienzo.strokeStyle = color;
  lienzo.linewidth = 3;
  lienzo.moveTo(xinicial,yinicial)
  lienzo.lineTo(xfinal,yfinal)
  lienzo.stroke();
  lienzo.closePath();
}
function ImprimirTecla(evento)
{
  var Movimiento = 5;
  var ColorLinea = "red";
  switch (evento.keyCode)
  {
    case Teclas.LEFT:
      DibujarLineas(ColorLinea,x,y,x-Movimiento,y,Papel);
      x = x - Movimiento;
      //alert("Tecla izquierda");
      break;
    case Teclas.UP:
      DibujarLineas(ColorLinea,x,y,x,y-Movimiento,Papel);
      y = y - Movimiento;
      //alert("Tecla arriba");
      break;
    case Teclas.RIGHT:
      DibujarLineas(ColorLinea,x,y,x+Movimiento,y,Papel);
      x = x + Movimiento;
      //alert("Tecla derecha");
      break;
    case Teclas.DOWN:
      DibujarLineas(ColorLinea,x,y,x,y+Movimiento,Papel);
      y = y + Movimiento;
      //alert("Tecla abajo");
      break;
    default:
      //alert("Ninguna de las anteriores");
  }
  console.log(evento.keyCode);
}
