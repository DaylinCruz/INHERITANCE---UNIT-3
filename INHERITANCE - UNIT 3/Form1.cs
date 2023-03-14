namespace INHERITANCE___UNIT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Artista[] new_song;
        int numsong;
        int length = 0;
        int index = 0;

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Artista new_song = new Artista();
            new_song.Name = txtname.Text;
            new_song.Duration = txtduration.Text;
            new_song.ARTIST = txtartist.Text;
            length++;
            SONG.Items.Add(new_song);
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtnumsongs.Text);
            index = num;
            length = 0;
            new_song = new Artista[index];
        }
    }
}