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

namespace _100mexicanos_dijeron
{
    public partial class Editar : Form
    {
        public static System.Windows.Controls.Label title;
        public Editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            if (File.Exists("rondas/ronda1.txt") && File.Exists("rondas/ronda2.txt") && File.Exists("rondas/ronda3.txt") && File.Exists("rondas/ronda4.txt") && File.Exists("rondas/ronda5.txt") && File.Exists("rondas/ronda6.txt") && File.Exists("rondas/ronda7.txt") && File.Exists("rondas/ronda8.txt"))
            {
                rondas.Items.Add("Ronda 1");
                rondas.Items.Add("Ronda 2");
                rondas.Items.Add("Ronda 3");
                rondas.Items.Add("Ronda 4");
                rondas.Items.Add("Ronda 5");
                rondas.Items.Add("Ronda 6");
                rondas.Items.Add("Ronda 7");
                rondas.Items.Add("Ronda 8");
            }
            else
            {
                MessageBox.Show("No se localizaron las rondas, recuerda pegar esta aplicacion en la misma ubicacion de la aplicacion \"100mexicanos_dijeron.exe\".");
                Close();
            }

        }
        public String ronda;

        private void rondas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ronda = rondas.SelectedItem.ToString();
            label_ronda.Text = "Seleccion: " + ronda;
            // MessageBox.Show(ronda);
            StreamReader reader = null;
            int c = 0;
            if (ronda == "Ronda 1")
            {
                reader = new StreamReader("rondas/ronda1.txt");
            }
            else if (ronda == "Ronda 2") {
                reader = new StreamReader("rondas/ronda2.txt");            
            }
            else if (ronda == "Ronda 3")
            {
                reader = new StreamReader("rondas/ronda3.txt");
            }
            else if (ronda == "Ronda 4")
            {
                reader = new StreamReader("rondas/ronda4.txt");
            }
            else if (ronda == "Ronda 5")
            {
                reader = new StreamReader("rondas/ronda5.txt");
            }
            else if (ronda == "Ronda 6")
            {
                reader = new StreamReader("rondas/ronda6.txt");
            }
            else if (ronda == "Ronda 7")
            {
                reader = new StreamReader("rondas/ronda7.txt");
            }
            else if (ronda == "Ronda 8")
            {
                reader = new StreamReader("rondas/ronda8.txt");
            }
            if (reader != null)
                c = 0;
                String r = reader.ReadLine();
                while (r != "") {
                    if (c == 0)
                    {
                        question.Text = r;
                    }
                   // else {
                    if (c > 0)
                    {
                        String[] data = r.Split(',');
                        if (c == 1)
                        {
                            ans1.Text = data[0];
                            pts1.Text = data[1];
                        }
                        else if (c == 2)
                        {
                            ans2.Text = data[0];
                            pts2.Text = data[1];
                        }
                        else if (c == 3)
                        {
                            ans3.Text = data[0];
                            pts3.Text = data[1];
                        }
                        else if (c == 4)
                        {
                            ans4.Text = data[0];
                            pts4.Text = data[1];
                        }
                        else if (c == 5)
                        {
                            ans5.Text = data[0];
                            pts5.Text = data[1];
                        }

                    }
                //}
                    r = reader.ReadLine();
                    c++;
                    if (c == 6) { break; }
                }
                reader.Close();
            ///}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (question.Text != "")
            {
                if (ans1.Text != "" && ans2.Text != "" && ans3.Text != "" && ans4.Text != "" && ans5.Text != "")
                {
                    if (pts1.Text != "" && pts2.Text != "" && pts3.Text != "" && pts4.Text != "" && pts5.Text != "")
                    {
                        String[] rs = { "Ronda 1", "Ronda 2", "Ronda 3", "Ronda 4", "Ronda 5", "Ronda 6", "Ronda 7", "Ronda 8" };
                        String[] fs = { "ronda1", "ronda2", "ronda3", "ronda4", "ronda5", "ronda6", "ronda7", "ronda8" };
                        String r = "", f = "";
                        for (int i = 0; i < 8; i++) {
                            if (ronda == rs[i]) {
                                r = rs[i];
                                f = fs[i];
                                break;
                            }
                        }
                        if (r != "" && f != "")
                        {
                            StreamWriter w = new StreamWriter("rondas/" + f + ".txt");
                            w.WriteLine(question.Text);
                            w.WriteLine(ans1.Text+","+pts1.Text);
                            w.WriteLine(ans2.Text + "," + pts2.Text);
                            w.WriteLine(ans3.Text + "," + pts3.Text);
                            w.WriteLine(ans4.Text + "," + pts4.Text);
                            w.WriteLine(ans5.Text + "," + pts5.Text);
                            w.Close();
                            MessageBox.Show("Datos guardados exitosamente en la ronda:" + ronda);
                        }
                        else {
                            MessageBox.Show("Wtf! No se encontro la ronda !");
                        }
                    }
                    else {
                        MessageBox.Show("No puedes dejar ningun campo de puntaje vacio.");                    
                    }

                }
                else {
                    MessageBox.Show("No puedes dejar ningun campo de respuesta vacio.");
                }
            }
            else {
                MessageBox.Show("No puedes dejar el campo de pregunta vacio.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                title.Content = textBox1.Text;
            }
            else {
                MessageBox.Show("No puedes dejar el titulo vacio.");
            
            }
        }


    }
}
