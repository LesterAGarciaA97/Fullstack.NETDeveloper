var Boton = document.getElementById("btnDeterminar");
Boton.addEventListener("click", Determinar)

function Determinar()
{
  for (x = 1; x <= 100; x++)
  {
    if (Residuo(x,3))
    {
      document.write(x + " es divisible entre 3");
    }
    if(Residuo(x,5))
    {
      document.write(x + " es divisible entre 5");
    }
    if (Residuo(x,3) && Residuo(x,5))
    {
      document.write(x + " es divisible entre 3 y 5");
    }
    if(!Residuo(x,3) && !Residuo(x,5))
    {
      document.write(x);
    }
    document.write("<br>");
  }
}

function Residuo(Numero,Divisor)
{
  if (Numero % Divisor == 0)
  {
    return true;
  }
  else
  {
    return false;
  }
}
