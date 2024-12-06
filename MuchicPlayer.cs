using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuchicPlayer
{
    public partial class MuchicPlayer : UserControl
    {
        Queue<string> q = new Queue<string>();
        string[] Musics = new string[1000];
        int cont;
        string a;


        public MuchicPlayer()
        {
            InitializeComponent();
        }

        // Barra volumen
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = volumeScroll.Value;
        }

        // Estado reproducción
        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            String[] arr = q.ToArray();
            if (e.newState == 8)
            {
                BeginInvoke(new Action(() =>
                {
                    try
                    {
                        Ltb_Musics.SelectedIndex = Ltb_Musics.SelectedIndex + 1;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        Ltb_Musics.SelectedIndex = 0;
                    }

                    Player.URL = Musics[Ltb_Musics.SelectedIndex];
                    timer1.Start();
                }));
            }
        }

        // Búsqueda canciones
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String[] arr = q.ToArray();
            String search = searchtxt.Text;

            var items = (from a in arr
                         where a.StartsWith(search)
                         select a).ToArray<String>();

            Ltb_Musics.Items.Clear();
            Ltb_Musics.Items.AddRange(items);
        }

        // Botón Play
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }

            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Selecciona una canción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Pause
        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        // Botón Stop
        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        //Botón abre explorador de archivos para añadir música
        private void pictureBoxOpenMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (Ltb_Musics.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        var r = open.SafeFileNames.GetValue(i);
                        a = Convert.ToString(r);
                        q.Enqueue(a);
                        Musics[cont] = open.FileNames.GetValue(i).ToString();
                        cont += 1;

                    }
                }

                Ltb_Musics.Items.Clear();
                foreach (string id in q)

                {
                    Ltb_Musics.Items.Add(id);
                }

                if (Ltb_Musics.SelectedIndex < 0)
                {
                    Ltb_Musics.SetSelected(0, true);
                }
            }
        }

        // Botón limpiar canciones
        private void pictureBoxNew_Click(object sender, EventArgs e)
        {
            Ltb_Musics.Items.Clear();
            q.Clear();

            Player.Ctlcontrols.stop();
        }

        // Botón canción anterior
        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if (Ltb_Musics.SelectedIndex != 0)
            {
                Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex - 1, true);
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
            }
            else
            {
                Ltb_Musics.SelectedIndex = Ltb_Musics.Items.Count - 1;
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }
        }

        // Botón canción siguiente
        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            if (Ltb_Musics.SelectedIndex != Ltb_Musics.Items.Count - 1)
            {
                Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex + 1, true);
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }
            else
            {
                Ltb_Musics.SelectedIndex = 0;
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
                timer1.Start();
            }
        }

        // Botón primera canción
        private void pictureBoxFirstSong_Click(object sender, EventArgs e)
        {
            Ltb_Musics.SetSelected(0, true);
            Player.URL = Musics[Ltb_Musics.SelectedIndex];
        }

        // Botón última canción
        private void pictureBoxLastSong_Click(object sender, EventArgs e)
        {
            Ltb_Musics.SetSelected(Ltb_Musics.Items.Count - 1, true);
            Player.URL = Musics[Ltb_Musics.SelectedIndex];
        }

        // Botón ordenar música ascendentemente
        private void pictureBoxAscending_Click(object sender, EventArgs e)
        {
            String[] arr = q.ToArray();

            bool swap;
            string temp;

            do
            {
                swap = false;

                for (int index = 0; index < (arr.Length - 1); index++)
                {
                    if (string.Compare(arr[index + 1], arr[index]) < 0)
                    {
                        temp = arr[index + 1];
                        arr[index + 1] = arr[index];
                        arr[index] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);

            Ltb_Musics.Items.Clear();

            for (int t = 0; t < arr.Length; t++)
            {
                Ltb_Musics.Items.Add(arr[t]);
            }
        }

        // Botón ordenar música descendentemente
        private void pictureBoxDescending_Click(object sender, EventArgs e)
        {
            String[] arr = q.ToArray();
            bool swap;
            string temp;

            do
            {
                swap = false;

                for (int index = 0; index < (arr.Length - 1); index++)
                {
                    if (string.Compare(arr[index], arr[index + 1]) < 0)
                    {
                        temp = arr[index];
                        arr[index] = arr[index + 1];
                        arr[index + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);

            Ltb_Musics.Items.Clear();

            for (int t = 0; t < arr.Length; t++)
            {
                Ltb_Musics.Items.Add(arr[t]);
            }

            if (Ltb_Musics.SelectedIndex < 0)
            {
                Ltb_Musics.SetSelected(0, true);
            }
        }

        // Botón adelantar música
        private void pictureBoxFastForward_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.fastForward();
        }

        // Botón reproducir música velocidad normal
        private void pictureBoxResume_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        // Botón shuffle
        private void pictureBoxShuffle_Click(object sender, EventArgs e)
        {
            if (Ltb_Musics.Items.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(Ltb_Musics.Items.Count);

                Ltb_Musics.SetSelected(randomIndex, true);
                Player.URL = Musics[randomIndex];

                timer1.Start();
            }
            else
            {
                MessageBox.Show("La lista de canciones está vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbltime.Text != "" && Convert.ToInt32(lbltime.Text.Replace(":", ""))
                == Convert.ToInt32(lblduration.Text.Replace(":", "")) - 2)
            {
                Random random = new Random();
                Ltb_Musics.SetSelected(random.Next(Ltb_Musics.Items.Count), true);
                Player.URL = Musics[Ltb_Musics.SelectedIndex];
            }
            //TimerTick.Checked == true &&

            lbltime.Text = Player.Ctlcontrols.currentPositionString;
            lblduration.Text = Player.currentMedia.durationString;
        }
    }
}
