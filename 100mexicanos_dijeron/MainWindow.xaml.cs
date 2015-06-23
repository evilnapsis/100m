using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;
namespace _100mexicanos_dijeron
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int allvalue;
        public static int team1;
        public static int team2;

        public static int value1;
        public static int value2;
        public static int value3;
        public static int value4;
        public static int value5;
        public static int ron = -1;
         static List<Ronda> rondas;
         
        public void cargar_ronda(int i) {
             reset();
             ronda.Content = "Ronda " + (i + 1);
             pregunta.Content = rondas[i].pregunta.texto;
             MessageBox.Show("Cargando la \'Ronda " + (i + 1) + "\'");
         }
        
        public MainWindow()
        {
            InitializeComponent();
            allvalue = 0;

            rondas = new List<Ronda>();

            rondas.Add(new Ronda("ronda1"));
            rondas.Add(new Ronda("ronda2"));
            rondas.Add(new Ronda("ronda3"));
            rondas.Add(new Ronda("ronda4"));
            rondas.Add(new Ronda("ronda5"));
            rondas.Add(new Ronda("ronda6"));
            rondas.Add(new Ronda("ronda7"));
            rondas.Add(new Ronda("ronda8"));

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                resp1.Content = rondas[ron].pregunta.respuestas[0].texto;
                value1 = rondas[ron].pregunta.respuestas[0].puntaje; ;
                marker1.Content = "" + value1;
                allvalue += value1;
                general.Text = "" + allvalue;
                value1 = 0;
            }
            else {
                MessageBox.Show("No has iniciado las rondas, para empezar debes presionar el boton \'i\' !");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                resp2.Content = rondas[ron].pregunta.respuestas[1].texto;
                value2 = rondas[ron].pregunta.respuestas[1].puntaje; ;
                marker2.Content = "" + value2;
                allvalue += value2;
                general.Text = "" + allvalue;
                value2 = 0;
            }
            else
            {
                MessageBox.Show("No has iniciado las rondas, para empezar debes presionar el boton \'i\' !");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                resp3.Content = rondas[ron].pregunta.respuestas[2].texto;
                value3 = rondas[ron].pregunta.respuestas[2].puntaje; ;
                marker3.Content = "" + value3;
                allvalue += value3;
                general.Text = "" + allvalue;
                value3 = 0;
            }
            else
            {
                MessageBox.Show("No has iniciado las rondas, para empezar debes presionar el boton \'i\' !");
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                resp4.Content = rondas[ron].pregunta.respuestas[3].texto;
                value4 = rondas[ron].pregunta.respuestas[3].puntaje; ;
                marker4.Content = "" + value4;
                allvalue += value4;
                general.Text = "" + allvalue;
                value4 = 0;
            }
            else
            {
                MessageBox.Show("No has iniciado las rondas, para empezar debes presionar el boton \'i\' !");
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                resp5.Content = rondas[ron].pregunta.respuestas[4].texto;
                value5 = rondas[ron].pregunta.respuestas[4].puntaje; ;
                marker5.Content = "" + value5;
                allvalue += value5;
                general.Text = "" + allvalue;
                value5 = 0;
            }
            else
            {
                MessageBox.Show("No has iniciado las rondas, para empezar debes presionar el boton \'i\' !");
            }
        }

        public void reset() {
            value1 = 0;
            value2 = 0;
            value3 = 0;
            value4 = 0;
            value5 = 0;
            resp1.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp2.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp3.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp4.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp5.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            marker1.Content = "0";
            marker2.Content = "0";
            marker3.Content = "0";
            marker4.Content = "0";
            marker5.Content = "0";
            general.Text = "0";
            allvalue = 0;
            team1 = 0;
            team2 = 0;
            markerteam1.Text = "000";
            markerteam2.Text = "000";
        }
        
        private void r_Click(object sender, RoutedEventArgs e)
        {
            ron = 0;
            value1 = 0;
            value2 = 0;
            value3 = 0;
            value4 = 0;
            value5 = 0;
            resp1.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp2.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp3.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp4.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            resp5.Content = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            marker1.Content = "0";
            marker2.Content = "0";
            marker3.Content = "0";
            marker4.Content = "0";
            marker5.Content = "0";
            general.Text = "0";
            allvalue = 0;
            team1 = 0;
            team2 = 0;
            markerteam1.Text = "000";
            markerteam2.Text = "000";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void toteam1_Click_1(object sender, RoutedEventArgs e)
        {
            markerteam1.Text = "" + (int.Parse(markerteam1.Text) + int.Parse(general.Text));
            general.Text = ""+0;
            allvalue = 0;
        }

        private void toteam2_Click(object sender, RoutedEventArgs e)
        {
            markerteam2.Text = "" + (int.Parse(markerteam2.Text) + int.Parse(general.Text));
            general.Text = "" + 0;
            allvalue = 0;

        }

        private void showfail_Click(object sender, RoutedEventArgs e)
        {
            markerfail.Content = "X";
        }

        private void quitfail_Click(object sender, RoutedEventArgs e)
        {
            markerfail.Content = "";
        }

        private void Window_Activated_1(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
        }

        private void iniciar_Click(object sender, RoutedEventArgs e)
        {
            ron = 0;
            cargar_ronda(ron);
            MessageBox.Show("Van a empezar las 8 rondas para moverte entre las diferentes rondas debes presionar los botones \'ronda anterior\' y \'ronda siguiente\'");
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                if (ron == 0)
                {
                    MessageBox.Show("Ya no puedes regresar mas ...");
                }
                else if (ron >= 1)
                {
                    ron = ron - 1;
                    cargar_ronda(ron);
                }
            }
            else {
                MessageBox.Show("No se han iniciado las rondas, debes presionar el boton \'i\' para iniciar !");
            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (ron != -1)
            {
                if (ron == 7)
                {
                    MessageBox.Show("Ya no puedes ir mas adelante ...");
                }
                else if (ron < 7)
                {
                    ron = ron + 1;
                    cargar_ronda(ron);
                }
            }
            else
            {
                MessageBox.Show("No se han iniciado las rondas, debes presionar el boton \'i\' para iniciar !");
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Editar.title = main_title;
            Editar es = new Editar();
            es.ShowDialog();
        }
    }
}
