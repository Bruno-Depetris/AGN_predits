using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Runtime.CompilerServices;
using System.Threading;
namespace AGN_predits.Notificaciones {
    public partial class Mensaje : Form {
        public Mensaje() {
            InitializeComponent();




        }

        int posicionX, posicionY;
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        private int contador = 0;       // Valor actual del contador
        bool estado = true;

        public enum TipoSonido {
            Confirmacion = 1,
            Error = 2,
            Intermedio = 3,
            Money = 4,
            start = 5,
            archive = 6,
            simple = 7,
            popTres = 8
        }

        public enum TipoIcono {
            Ok,
            Error,
            Cash,
            Admin,
            BaseDatos,
            Buscar,
            Edit,
            Delete,
            Zapatillas,
        }


        // Rutas de íconos
        string ErrorPath = Path.Combine(Application.StartupPath, "Img/Iconos", "error.png");
        string OkPath = Path.Combine(Application.StartupPath, "Img/Iconos", "check.png");
        string CashPath = Path.Combine(Application.StartupPath, "Img/Iconos", "cash.png");
        string Admin = Path.Combine(Application.StartupPath, "Img/Iconos", "admin.png");
        string BaseDatos = Path.Combine(Application.StartupPath, "Img/Iconos", "bd.png");
        string Buscar = Path.Combine(Application.StartupPath, "Img/Iconos", "buscar.png");
        string Edit = Path.Combine(Application.StartupPath, "Img/Iconos", "edit.png");
        string Delete = Path.Combine(Application.StartupPath, "Img/Iconos", "delete.png");
        string Zapatillas = Path.Combine(Application.StartupPath, "Img/Iconos", "zapatillas.png");

        // Rutas de sonidos
        string popUno = Path.Combine(Application.StartupPath, "Sonidos", "pop-1-269287.wav");
        string popDos = Path.Combine(Application.StartupPath, "Sonidos", "pop-on-269286.wav");
        string popTres = Path.Combine(Application.StartupPath, "Sonidos", "pop-sound-effect-226110.wav");
        string start = Path.Combine(Application.StartupPath, "Sonidos", "start-13691.wav");
        string archive = Path.Combine(Application.StartupPath, "Sonidos", "achive-sound-132273.wav");
        string simple = Path.Combine(Application.StartupPath, "Sonidos", "simple-notification-152054.wav");
        string ui = Path.Combine(Application.StartupPath, "Sonidos", "ui-3-sound-effect-warn-242229.wav");
        string error = Path.Combine(Application.StartupPath, "Sonidos", "error-126627.wav");


        public void Show(string titulo, string descripcion, Color panelColor, Color backColor, TipoIcono icono, TipoSonido sonido) {
            // Selección de sonido basado en el tipo
            switch (sonido) {
                case TipoSonido.Confirmacion:
                    ReproducirSonido(popUno);
                    break;
                case TipoSonido.Error:
                    ReproducirSonido(error);
                    break;
                case TipoSonido.Intermedio:
                    ReproducirSonido(ui);
                    break;
                case TipoSonido.Money:
                    ReproducirSonido(popDos);
                    break;
                case TipoSonido.start:
                    ReproducirSonido(start);
                    break;
                case TipoSonido.archive:
                    ReproducirSonido(archive);
                    break;
                case TipoSonido.simple:
                    ReproducirSonido(simple);
                    break;
                case TipoSonido.popTres:
                    ReproducirSonido(popTres);
                    break;
                default:
                    ReproducirSonido(popUno);
                    break;
            }


            string iconoPath = "";

            // Selección del ícono basado en el tipo
            switch (icono) {
                case TipoIcono.Ok:
                    iconoPath = OkPath;
                    break;
                case TipoIcono.Error:
                    iconoPath = ErrorPath;
                    break;
                case TipoIcono.Cash:
                    iconoPath = CashPath;
                    break;
                case TipoIcono.Admin:
                    iconoPath = Admin;
                    break;
                case TipoIcono.BaseDatos:
                    iconoPath = BaseDatos;
                    break;
                case TipoIcono.Buscar:
                    iconoPath = Buscar;
                    break;
                case TipoIcono.Edit:
                    iconoPath = Edit;
                    break;
                case TipoIcono.Delete:
                    iconoPath = Delete;
                    break;
                case TipoIcono.Zapatillas:
                    iconoPath = Zapatillas;
                    break;
                default:
                    iconoPath = OkPath;
                    break;
            }


            // Actualización de la interfaz
            label_Titulo.Text = titulo;
            label_Mensaje.Text = descripcion;
            panel_Color.BackColor = panelColor;
            this.BackColor = backColor;
            parrotPictureBox_ImagenNot.Image = Image.FromFile(iconoPath);

            // Mostrar el formulario
            this.Show();
        }

        private void ReproducirSonido(string rutaArchivo) {
            // Reproducir archivo MP3 usando Windows Media Player o una biblioteca compatible
            using (var player = new System.Media.SoundPlayer(rutaArchivo)) {
                player.Play();
            }
        }

        private void Mensaje_Load(object sender, EventArgs e) {
            position();
        }

        private void timer_Muestra_Tick(object sender, EventArgs e) {
            if (estado == false) {


                if (posicionY >= ScreenHeight - this.Height - 30) {
                    posicionY -= 5;

                } else {
                    estado = true;
                    contador = 200;
                }



            } else if (estado == true) {
                contador--;

                if (contador <= 100 && contador >= 0) {
                    posicionY += 5;
                    if (posicionY == ScreenHeight) {

                        timer_Muestra.Stop();
                        timer_Muestra.Dispose();
                        this.Close();

                    }
                }
            }

            this.Location = new Point(posicionX, posicionY);
        }

        private void position() {

            posicionY = ScreenHeight - this.Height; //815 
            posicionX = ScreenWidth - this.Width - 30; //900 - 300 - 30 = 570


            this.Location = new Point(posicionX, ScreenHeight);
            timer_Muestra.Start();
            estado = false;

        }

    }
}
