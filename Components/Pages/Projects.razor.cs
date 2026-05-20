using CaroNobre.Models;

namespace CaroNobre.Components.Pages
{
    public partial class Projects
    {
        List<Project> projects = new()
        {
            new Project {
                Id = "aurix",
                Title = "Exploring Multicore Parallelism",
                Description = "Analyzing tasks and concurrency on a single and multiple cores using an Aurix TC375LK.",
                ImageUrl = "https://raw.githubusercontent.com/carocaro22/CaroNobre/refs/heads/master/wwwroot/images/aurix.jpg",
                Url = "https://github.com/carocaro22/AURIX-Concurrency"
            },

            new Project {
                Id = "nfc",
                Title = "NFC-Based Event Attendance System",
                Description = "A kiosk application using NFC to enable event check-in and automatically record attendance.",
                ImageUrl = "images/nfc.png",
                Url = "https://github.com/carocaro22/nfc-reader"
            },

            new Project {
                Id = "rps",
                Title = "Rock, Paper, Scissors",
                Description = "LSTM to predict next move of adversary in a Rock Paper Scissors game.",
                ImageUrl = "images/rockpaperscissors.jpg",
                Url = "https://github.com/carocaro22/mar-sue"
            }
        };
    }
}