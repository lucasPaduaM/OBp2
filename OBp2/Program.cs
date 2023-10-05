// See https://aka.ms/new-console-template for more information
using Social.NetWork.Dominio;
Sistema sistema = new Sistema();

#region precarga de datos
sistema.AddUsuarioAdministrador("lucas@gmail.com", "hola1234");
sistema.AddUsuarioAdministrador("emanuel@gmail.com", "hola1234");

sistema.AddUsuarioMiembro("jose@gmail.com", "hola1234", "jose", "rodgiruez", DateTime.UtcNow);
sistema.AddUsuarioMiembro("enrique@gmail.com", "hola1234", "enrique", "borgarello", DateTime.MinValue);
#endregion

int opcion = -1;
while (opcion != 3)
{
    Console.WriteLine("");
    Console.WriteLine("MENU Inicial");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Seleccione opcion");
    Console.WriteLine("1-Registrarse.");
    Console.WriteLine("2-Loguearse.");
    Console.WriteLine("3-Dado un email de miembro listar publicaciones (post y comentarios separados).");
    Console.WriteLine("4-Dado un email de miembro listar los post en los que haya comentado.");
    Console.WriteLine("4-Dadas dos fechas listar los post realizados entre esas fechas ");
    Console.WriteLine("3-Salir.");
    Console.WriteLine("----------------------------");
    Console.Write("Opcion: ");
    try
    {
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                bool emailValidado = false;
                bool contraseniaValidada = false;
                bool usuarioMiembroNombreValido = false;
                bool usuarioMiembroApellidoValido = false;
                bool tipoUsuarioValido = false;

                string email = "";
                string contrasenia = "";
                string nombre = "";
                string apellido = "";
                DateTime fechaNac = DateTime.UtcNow;
                while (!emailValidado)
                {
                    Console.WriteLine("");
                    Console.Write("Ingrese email: ");
                    email = Console.ReadLine();

                    if (!email.Contains('@'))
                    {
                        Console.WriteLine("Falta el @");
                    }
                    else if (!email.Contains("gmail.com") && !email.Contains("hotmail.com") && !email.Contains("outlook.com"))
                    {
                        Console.WriteLine("Falta el dominio, puede ser 'gmail.com', 'hotmail.com' u 'outlook.com'");
                    }
                    else
                    {
                        foreach (Usuario usuario in sistema.GetUsuarios())
                        {
                            if (usuario.GetEmail().Equals(email))
                            {
                                Console.WriteLine("El email ingresado ya existe");
                                break;
                            }
                            else
                            {
                                emailValidado = true;
                                break;
                            }
                        }
                    }
                }

                while (!contraseniaValidada)
                {
                    Console.Write("Ingrese la contrasenia: ");
                    contrasenia = Console.ReadLine();

                    if (contrasenia == null || contrasenia == "")
                    {
                        Console.WriteLine("La contrasenia no puede ser vacia");
                    }
                    else if (contrasenia.Length < 3)
                    {
                        Console.WriteLine("La contrasenia debe tener como minimo 3 caracteres");
                    }
                    else
                    {
                        contraseniaValidada = true;
                    }
                }

                while (!tipoUsuarioValido)
                {
                    Console.Write("Ingrese 0 para crear un Usuario Administrador, o ingrese 1 para crear un Usuario Miembro: ");
                    string tipoUsuario = Console.ReadLine();

                    if (tipoUsuario == "0")
                    {
                        sistema.AddUsuarioAdministrador(email, contrasenia);
                        Console.WriteLine("Usuario administrador creado exitosamente");
                        tipoUsuarioValido = true;
                    }

                    else if (tipoUsuario == "1")
                    {
                        while (!usuarioMiembroNombreValido)
                        {
                            Console.WriteLine("");
                            Console.Write("Ingrese nombre: ");
                            nombre = Console.ReadLine();

                            if (nombre == null || nombre == "")
                            {
                                Console.WriteLine("El nombre no puede estar vacio");
                            }
                            else
                            {
                                usuarioMiembroNombreValido = true;
                            }
                        }

                        while (!usuarioMiembroApellidoValido)
                        {
                            Console.WriteLine("");
                            Console.Write("Ingrese apellido: ");
                            apellido = Console.ReadLine();

                            if (apellido == null || apellido == "")
                            {
                                Console.WriteLine("El apellido no puede estar vacio");
                            }
                            else
                            {
                                usuarioMiembroApellidoValido = true;
                            }
                        }

                        Console.Write("Ingrese fecha de nacimiento (formato dd/mm/aaaa hh:mm:ss): ");
                        fechaNac = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Usuario Miembro creado exitosamente");
                        sistema.AddUsuarioMiembro(email, contrasenia, nombre, apellido, fechaNac);
                        tipoUsuarioValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese 0 para crear un administrador o 1 para crear un miembro");
                        Console.Write("");
                    }
                }
                break;

            case 2:
                Console.Write("Ingrese Email: ");
                string emailLogin = Console.ReadLine();

                Console.Write("Ingrese Contrasenia");
                string contraseniaLogin = Console.ReadLine();

                bool hayLogin = sistema.DoLogin(emailLogin, contraseniaLogin);

                if (hayLogin)
                {
                    if (sistema.usuarioLogueado.GetType().ToString().Contains("Miembro"))
                    {
                        int opcionMenuMiembro = -1;
                        while (opcionMenuMiembro != 3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("MENU Miembro");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Seleccione opcion");
                            Console.WriteLine("1-Crear publicacion.");
                            Console.WriteLine("2-Crear invitacion de amistad.");
                            Console.WriteLine("3-Comentar publicacion.");
                            Console.WriteLine("4-Reaccionar a publicacion.");
                            Console.WriteLine("5-Desloguearse.");
                            Console.WriteLine("----------------------------");
                            Console.Write("Opcion: ");
                            try
                            {
                                opcionMenuMiembro = int.Parse(Console.ReadLine());
                                switch (opcionMenuMiembro)
                                {
                                    case 1:
                                        break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ha ocurrido un error " + e.Message);
                            }
                        }
                    } else if (sistema.usuarioLogueado.GetType().ToString().Contains("Administrador"))
                    {
                        int opcionMenuAdministrador = -1;
                        while (opcionMenuAdministrador != 3)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("MENU Administrador");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Seleccione opcion");
                            Console.WriteLine("1-Bloquear usuario.");
                            Console.WriteLine("2-Censurar comentario.");
                            Console.WriteLine("3-Desloguearse.");
                            Console.WriteLine("----------------------------");
                            Console.Write("Opcion: ");
                            try
                            {
                                opcionMenuAdministrador = int.Parse(Console.ReadLine());
                                switch (opcionMenuAdministrador)
                                {
                                    case 1:
                                        break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ha ocurrido un error " + e.Message);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Email o contrasenia incorrectos");
                }

                break;


            case 3:
                Console.WriteLine("Programa finalizado.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error " + ex.Message);
    }
}