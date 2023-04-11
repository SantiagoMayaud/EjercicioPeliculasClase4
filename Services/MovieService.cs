using EjercicioPeliculas.Models;

namespace EjercicioPeliculas.Services;

public static class MovieService{
    static List<Movie> Movies { get; set;} //Parametro de la clase servicio MovieService, una lista de objetos de tipo "Movie" (sacados del modelo) llamada "Movies"

    static MovieService(){ //Get del parametro anterior? No sé la diferencia.
        Movies = new List<Movie>
        {
            new Movie { Name = "Top Gun", Code="TG", Category="Aventura", Runtime=109},
            new Movie { Name = "John Wick", Code="JW", Category="Acción", Runtime=110},
        };
    }

    public static List<Movie> GetAll() => Movies; //no entiendo que significa esta linea

    public static void Add(Movie obj){ //Metodo para agregar objetos de tipo pelicula
       if(obj == null){
         return;
       }

       Movies.Add(obj);
    }

    public static void Delete(Movie code){ //metodo para eliminar peliculas de la lista según su "code"
        var movieToDelete = code;

        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower()); //Esta linea es para que el código funcione en mayusculas y minusculas? Cual código especificamente?

}