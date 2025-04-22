using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace tarea6
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Programador> Programadores { get; set; }
        public ICommand LeerMasCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Programadores = new ObservableCollection<Programador>
            {
                new Programador
                {
                    Nombre = "Guido van Rossum",
                    Imagen = "https://cms.qz.com/wp-content/uploads/2019/05/Guido-van-Rossum-e1558635088256.jpg",
                    DescripcionCorta = "Creador de Python. Nació en Países Bajos, 1956.",
                    Url = "https://es.wikipedia.org/wiki/Guido_van_Rossum"
                },
                new Programador
                {
                    Nombre = "Brendan Eich",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/d/d1/Brendan_Eich_Mozilla_Foundation_official_photo.jpg",
                    DescripcionCorta = "Inventor de JavaScript. Nació en EE.UU., 1961.",
                    Url = "https://es.wikipedia.org/wiki/Brendan_Eich"
                },
                new Programador
                {
                    Nombre = "Rasmus Lerdorf",
                    Imagen = "https://uwaterloo.ca/engineering/sites/ca.engineering/files/uploads/images/rasmus_lerdorf_-_head_shot.jpg",
                    DescripcionCorta = "Creador de PHP. Nació en Groenlandia, 1968.",
                    Url = "https://es.wikipedia.org/wiki/Rasmus_Lerdorf"
                },
                new Programador
                {
                    Nombre = "Matt Mullenweg",
                    Imagen = "https://cdn.facesofopensource.com/wp-content/uploads/2018/10/02182707/mm.mattmullenweg29772-1.jpg",
                    DescripcionCorta = "Creador de WordPress. Nació en EE.UU., 1984.",
                    Url = "https://es.wikipedia.org/wiki/Matt_Mullenweg"
                },
                new Programador
                {
                    Nombre = "Tim Berners-Lee",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/4/4e/Sir_Tim_Berners-Lee_%28cropped%29.jpg",
                    DescripcionCorta = "Padre de la World Wide Web. Nació en Reino Unido, 1955.",
                    Url = "https://es.wikipedia.org/wiki/Tim_Berners-Lee"
                },
                new Programador
                {
                    Nombre = "Linus Torvalds",
                    Imagen = "linus.png", // Usa una imagen local en tu proyecto
                    DescripcionCorta = "Creador de Linux y Git. Nació en Finlandia, 1969.",
                    Url = "https://es.wikipedia.org/wiki/Linus_Torvalds"
                }
            };

            LeerMasCommand = new Command<string>(async (url) =>
            {
                if (!string.IsNullOrEmpty(url))
                    await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            });

            BindingContext = this;
        }
    }

    public class Programador
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string DescripcionCorta { get; set; }
        public string Url { get; set; }
    }
}