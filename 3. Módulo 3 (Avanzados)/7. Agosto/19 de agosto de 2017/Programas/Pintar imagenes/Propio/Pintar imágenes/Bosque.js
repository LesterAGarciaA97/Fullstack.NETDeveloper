var VP = document.getElementById("Bosque");
var Papel = VP.getContext("2d");
var ImagenFondo={url: "Fondo.png", carga: false};
var Casa ={url: "Casa.png", carga: false};
var Llave ={url: "Llave.png", carga: false};
var Teclas ={UP: 38,DOWN: 40,LEFT: 37,RIGHT: 39}
ImagenFondo.imagen = new Image();
ImagenFondo.imagen.src = ImagenFondo.url;
ImagenFondo.imagen.addEventListener("load", CargarFondo);
Casa.imagen = new Image();
Casa.imagen.src = Casa.url;
Casa.imagen.addEventListener("load", CargarCasa);
Llave.imagen = new Image();
Llave.imagen.src = Llave.url;
Llave.imagen.addEventListener("load", CargarLlave);
function Movimiento(evento)
{
  console.log(LlaveX);
  console.log(LlaveY);
  switch(evento.keyCode)
  {
    case Teclas.UP:
      LlaveX = LlaveY - 1;
      console.log("X: " + LlaveX);
      console.log("Y: " + LlaveY);
      console.log((10+(80*LlaveX)));
      Llave.imagen.X = LlaveY;
      break;
    case Teclas.DOWN:
      LlaveX = LlaveY + 1;
      console.log("X: " + LlaveX);
      console.log("Y: " + LlaveY);
      console.log((10+(80*LlaveX)));
      break;
  }
}
function CargarFondo()
{
  ImagenFondo.carga = true;
  Papel.drawImage(ImagenFondo.imagen,0,0);
  Dibujar();
}
function CargarCasa()
{
  Casa.carga = true;
  Papel.drawImage(Casa.imagen,10,10);
  Dibujar();
}
function CargarLlave()
{
  Llave.carga = true;
  Papel.drawImage(Llave.imagen,10,10);
  Dibujar();
}
function Dibujar()
{
  if(ImagenFondo.carga)
  {
        Papel.drawImage(ImagenFondo.imagen,0,0);
  }
  if(Casa.carga)
  {
    var NumeroCasas = AleatorioCasas();
    for (var i = 0; i < NumeroCasas; i++)
    {
      var X = AleatorioPosicion();
      var Y = AleatorioPosicion();
      Papel.drawImage(Casa.imagen,10+(80*X),10+(80*Y));
    }
  }
  if(Llave.carga)
  {
    Papel.drawImage(Llave.imagen,0,0)
  }
}
function AleatorioCasas()
{
  return Aleatorio(4,10);
}
function AleatorioPosicion()
{
  return Aleatorio(0,5);
}
function Aleatorio(Minimo,Maximo)
{
  return Math.floor(Math.random()*(Maximo-Minimo+1)+Minimo)
}
