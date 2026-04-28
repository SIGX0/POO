using FactoryMethodN;

class Program
{
    static void Main(string[] args)
    {
        EnvioCreator envioCorreo = new EnvioCorreoCreator();
        envioCorreo.ProcesarEnvio();

        EnvioCreator envioMoto = new EnvioMotoCreator();
        envioMoto.ProcesarEnvio();

        EnvioCreator envioCamion = new EnvioCamionCreator();
        envioCamion.ProcesarEnvio();

        EnvioCreator envioBarco = new EnvioBarcoCreator();
        envioBarco.ProcesarEnvio();

        EnvioCreator envioAvion = new EnvioAvionCreator();
        envioAvion.ProcesarEnvio();
    }
}
