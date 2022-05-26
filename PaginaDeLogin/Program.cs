using PaginaDeLogin.Entities;
namespace PaginaDeLogin
{
    public class Program
    {
        static void Main(string[] arg)
        {
            var user = new List<Usuario>();
            Tela();

            void Tela()
            {
                Console.Clear();
                Console.WriteLine("===== Caixa Eletronico =====");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Signin");
                Console.WriteLine("0 - Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    //Fazer o login do usuario
                    case 1:
                        {
                            var cont = 0;
                            string userNameLogin = UserNameLogin();
                            string userPasswordLogin = UserPasswordLogin();

                            if (user.Count() == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Não existe usuário cadastrado! Por favor faça um cadastro");
                                System.Threading.Thread.Sleep(2000);
                                Tela();
                            }
                            foreach (var users in user)
                            {
                                if (users.Name == userNameLogin && users.Password == userPasswordLogin)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Bem vindo {users.Name}!");

                                    short continuarOperacoes = 1;

                                    while (continuarOperacoes != 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1- Deposito");
                                        Console.WriteLine("2- Saque");
                                        Console.WriteLine("3- Extrato");
                                        Console.WriteLine("0- Tela Inicial");

                                        int opcaoTelaOperacao = int.Parse(Console.ReadLine());

                                        switch (opcaoTelaOperacao)
                                        {
                                            case 1:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Informe a sua senha: ");
                                                    var senha = Console.ReadLine();

                                                    var cont1 = 0;
                                                    foreach (var item in user)
                                                    {
                                                        cont1++;
                                                        if (senha == item.Password)
                                                        {
                                                            users.Balance = Deposito(users.Balance);
                                                            Console.WriteLine("Valor depositado com sucesso");
                                                            Console.WriteLine($"Saldo atual: {users.Balance}");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                        if (cont1 == user.Count() && item.Password != senha)
                                                        {
                                                            Console.WriteLine("Senha inválida!");
                                                            System.Threading.Thread.Sleep(1000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                    }
                                                }
                                                break;
                                            case 2:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Informe a sua senha: ");
                                                    var senha = Console.ReadLine();

                                                    var cont1 = 0;
                                                    foreach (var item in user)
                                                    {
                                                        cont1++;
                                                        if (senha == item.Password)
                                                        {
                                                            users.Balance = Saque(users.Balance);
                                                            Console.WriteLine($"Saldo atual: {users.Balance}");
                                                            System.Threading.Thread.Sleep(2000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                        if (cont1 == user.Count() && item.Password != senha)
                                                        {
                                                            Console.WriteLine("Senha inválida!");
                                                            System.Threading.Thread.Sleep(1000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                    }
                                                }
                                                break;
                                            case 3:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Informe a sua senha: ");
                                                    var senha = Console.ReadLine();

                                                    var cont1 = 0;
                                                    foreach (var item in user)
                                                    {
                                                        cont1++;
                                                        if (senha == item.Password)
                                                        {
                                                            Console.WriteLine($"Saldo: {users.Balance}");
                                                            System.Threading.Thread.Sleep(1000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                        if (cont1 == user.Count() && item.Password != senha)
                                                        {
                                                            Console.WriteLine("Senha inválida!");
                                                            System.Threading.Thread.Sleep(1000);
                                                            Console.Clear();
                                                            Console.WriteLine("1- Continuar fazendo operações");
                                                            Console.WriteLine("0- Voltar para tela inicial");
                                                            continuarOperacoes = short.Parse(Console.ReadLine());
                                                            if (continuarOperacoes == 0)
                                                            {
                                                                Tela();
                                                            }
                                                        }
                                                    }
                                                }
                                                break;
                                            default: Tela(); break;
                                        }
                                    }
                                    break;
                                }
                                cont++;
                                Console.WriteLine(cont);
                                Console.WriteLine(user.Count());
                                System.Threading.Thread.Sleep(2000);
                                if (cont == user.Count() && users.Name != userNameLogin || users.Password != userPasswordLogin)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Usuário ou senha incorreto");
                                    System.Threading.Thread.Sleep(2000);
                                    Tela();
                                }
                            }
                        }; break;
                    case 2:
                        {
                            string userNameSignin = CreateUserName();
                            string passwordSignin = CreatePassword();

                            user.Add(new Usuario(userNameSignin, passwordSignin));
                            Console.WriteLine("Usuário criado com sucesso.");
                            System.Threading.Thread.Sleep(1000);
                            Tela();
                        }; break;
                    case 0: System.Environment.Exit(0); break;
                    default: Tela(); break;
                }
            }
            static string CreateUserName()
            {
                Console.Clear();
                Console.WriteLine("===== Tela de Signin =====");
                Console.WriteLine("Informe um nome de Usuário: ");
                string userNameSignin = Console.ReadLine();
                return userNameSignin;
            }
            static string CreatePassword()
            {
                Console.WriteLine("Informe uma senha: ");
                string passwordSignin = Console.ReadLine();
                Console.WriteLine("Confirme a senha: ");
                string passwordConfirmationSignin = Console.ReadLine();

                if (passwordSignin != passwordConfirmationSignin)
                {
                    while (passwordSignin != passwordConfirmationSignin)
                    {
                        Console.WriteLine("Senha incorreta!");
                        Console.WriteLine("Informe uma senha: ");
                        passwordSignin = Console.ReadLine();
                        Console.WriteLine("Confirme a senha: ");
                        passwordConfirmationSignin = Console.ReadLine();
                    }
                    return passwordSignin;
                }
                return passwordSignin;
            }
            static string UserNameLogin()
            {
                Console.Clear();
                Console.WriteLine("===== Tela de Login =====");
                Console.WriteLine("User: ");
                string userNameLogin = Console.ReadLine();
                return userNameLogin;
            }
            static string UserPasswordLogin()
            {

                Console.WriteLine("Password: ");
                string userPasswordLogin = Console.ReadLine();
                return userPasswordLogin;
            }
            static decimal Deposito(decimal balance)
            {
                Console.Clear();
                Console.WriteLine("Informe o valor a ser depositado: ");
                decimal valor = decimal.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    while (valor < 0)
                    {
                        Console.WriteLine("Valor inváldo!");
                        Console.WriteLine("Informe o valor a ser depositado: ");
                        valor = decimal.Parse(Console.ReadLine());
                    }
                    return balance += valor;
                }
                return balance += valor;
            }
            static decimal Saque(decimal balance)
            {
                Console.Clear();
                Console.WriteLine("Informe o valor a sacado: ");
                decimal valor = decimal.Parse(Console.ReadLine());

                if (valor > balance || balance <= 0)
                {
                    Console.WriteLine("Você não possui saldo suficiente para essa operação");
                    return balance;
                }
                else
                {
                    if (valor < 0)
                    {
                        while (valor < 0)
                        {
                            Console.WriteLine("Valor inváldo!");
                            Console.WriteLine("Informe o valor a ser sacado: ");
                            valor = decimal.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Valor sacado com sucesso");
                        return balance -= valor;
                    }
                    Console.WriteLine("Valor sacado com sucesso");
                    return balance -= valor;
                }
            }
        }
    }
}