using BLL.Servicios;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Prueba Crear(Funciona)
            /////PruebaPostCliente().Wait();


            // 2. Prueba Obtener por Id (Funciona)
            ////var prueba = clienteRepository.ObtenerPorId("1");
            ////Console.WriteLine(prueba.Celular);
            ////Console.ReadKey();

            // 3. Prueba Obtener todos (Funciona)
            PruebaObtenerTodos().Wait();
            Console.ReadKey();

            // 4. Prueba Actualizar (Funciona)
            ////var respuesta = clienteRepository.Actualizar("1", miCliente);

            ////Console.WriteLine(respuesta);
            ////Console.ReadKey();

            // 5. Prueba Eliminar por Id (Funciona)
            ////var respuesta = clienteRepository.EliminarPorId("123");

            ////Console.WriteLine(respuesta);
            ////Console.ReadKey();

            // 6. Prueba Eliminar todos (Funciona)
            ////var respuesta = clienteRepository.EliminarTodos();

            ////Console.WriteLine(respuesta);
            ////Console.ReadKey();

            // Hay que mejorar las excepciones y respuestas de retorno en la capa de datos
        }

        public static async Task PruebaObtenerTodos()
        {
            ClienteService clienteService = new ClienteService();
            await Task.Delay(200);
            var lista = await clienteService.ObtenerTodos();
            foreach (Cliente cliente in lista)
            {
                Console.WriteLine($"Nombres: {cliente.Nombres}\nApellidos: {cliente.Apellidos}\nEmail: {cliente.Correo}\n");
            }
        }

        public static async Task PruebaPostCliente()
        {
            ClienteService clienteService = new ClienteService();
            Cliente miCliente = new Cliente
            {
                NumeroDocumento = "123",
                TipoDocumento = "123",
                Nombres = "123",
                Apellidos = "1",
                Celular = "1",
                Correo = "1",
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
            };

            Console.WriteLine(await clienteService.Crear(miCliente));
        }
    }
}
