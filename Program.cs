using Twitch;


List <Videogame> videogames = new List<Videogame>();
List <Streamer> streamers = new List<Streamer>(); 

  while(true){
    int option = 0;
    Console.WriteLine("[1] Agregar Videojuego");
    Console.WriteLine("[2] Agregar Streamer");
    Console.WriteLine("[3] Mostrar Videojuegos");
    Console.WriteLine("[4] Mostrar Streamers");
    Console.WriteLine("[5] Salir");
    option = Convert.ToInt32(Console.ReadLine());

    if(option == 5)
    break;

    switch (option){
        case 1: AddGame();
        break;
        case 2: AddStreamer();
        break;
        case 3: InfoGames();
        break;
        case 4: InfoStreamers();
        break;

        default: Console.WriteLine("Opcion incorrecta");
        break;
    }
  }

  void AddGame(){
    Videogame NewGame = new Videogame();
    Console.WriteLine("Nombre del juego:");
    NewGame.Name= Console.ReadLine();

     Console.WriteLine("Selecciona el genero de juego:");
NewGame.Genero = Console.ReadLine();

videogames.Add(NewGame);
  }

  void AddStreamer(){
    Streamer NewStreamer = new Streamer();
    Console.WriteLine("Nombre del Streamer:");
    NewStreamer.Name = Console.ReadLine();

    Console.WriteLine("Selecciona el juego principal del streamer: ");
    int i = 1;
    foreach (Videogame videogame in videogames){
        Console.WriteLine($"{i} - {videogame.Name}");
        i++;
    }
    var Index = Convert.ToInt32(Console.ReadLine());
    Videogame JuegoElegido = videogames[Index-1];
    NewStreamer.MainGame = JuegoElegido;

    streamers.Add(NewStreamer);
  }

  void InfoGames(){
    int i = 1;
    foreach (Videogame videogame in videogames){
        Console.WriteLine($"{i} - {videogame.Name}");
        Console.WriteLine($"{i} - {videogame.Genero}");
        i++;
  }
  }

  void InfoStreamers(){
    int i = 1;
    foreach (Streamer streamer in streamers){
        Console.WriteLine($"{i} - {streamer.Name}");
        Console.WriteLine($"{i} - {streamer.MainGame.Name}");
        i++;
  }
  }