using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _100mexicanos_dijeron
{
    class Ronda
    {
        public Pregunta pregunta;

        public Ronda(String file) {
            StreamReader reader = new StreamReader("rondas/"+file+".txt");
            String r = reader.ReadLine();
                        int cnt = 0;
                        pregunta = new Pregunta();
                        while (r != null) {
                            if (cnt == 0) { pregunta.texto = r; }
                            else {
                                Respuesta resp = new Respuesta();
                                String[] line = r.Split(',');
                                resp.texto = line[0];
                                resp.puntaje = int.Parse(line[1]);
                                pregunta.respuestas.Add(resp);
                            }
                            cnt++;
                            r = reader.ReadLine();
                        }
                        reader.Close();
        }
    }
}
