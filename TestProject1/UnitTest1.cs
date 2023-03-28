using PruebaGestor;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MensajeTest()
        {
            var mensaje = new Mensaje();
            var Remitente = new Contacto("Marce", "Jorgito@Ejemplo.com");
            mensaje.Remitente = Remitente;

            mensaje.Asunto = "Clima";
            mensaje.Cuerpo = "Nublado";
            

            Assert.Equal("Clima", mensaje.Asunto);
            Assert.Equal("Nublado", mensaje.Cuerpo);
            Assert.Equal("Marce", mensaje.Remitente.Nombre);
            Assert.Equal("Jorgito@Ejemplo.com", mensaje.Remitente.Email);

        }
        [Fact]
        public void GestorTest()
        {
            var gestor = new Gestor();
            var mensaje = new Mensaje();

            mensaje.Asunto = "Clima";

            gestor.AgregarBDE(mensaje);

            Assert.Equal("Clima", gestor.BandejaDeEntrada[0].Asunto);

        }

    }
}