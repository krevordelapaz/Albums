using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Albums
{
    public partial class windowAlbum : Form
    {
        private string albums = "[{\"Artist\":\"NOFX\",\"Title\":\"Wolves in wolves clothing\",\"Label\":\"Fat wreck chords\",\"Genre\":\"Punk\",\"SongCount\": 18},"
                                + "{\"Artist\":\"The Tragically Hip\",\"Title\":\"Music @ work\",\"Label\":\"Universal\",\"Genre\":\"Rock\",\"SongCount\": 14},"
                                + "{\"Artist\":\"The Joel Plaskett Emergency\",\"Title\":\"Down at the Khyber\",\"Label\":\"Brobdingnagian records\",\"Genre\":\"Rock\",\"SongCount\": 12},"
                                + "{\"Artist\":\"Gorillaz\",\"Title\":\"Demon days\",\"Label\":\"EMI\",\"Genre\":\"Rock\",\"SongCount\": 15}]";
        
        private List<Album> albumList;

        public windowAlbum()
        {
            InitializeComponent();
            albumsListBox.DisplayMember = "Title";
            albumsListBox.ValueMember = "Title";
            LoadAlbums();
        }

        private void LoadAlbums()
        {
            albumList = JsonConvert.DeserializeObject<List<Album>>(albums);

            foreach(Album album in albumList)
            {
                albumsListBox.Items.Add(album);
            }
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Album selectedAlbum = albumList.ElementAt(listBox.SelectedIndex);

            string details = $"Title: {selectedAlbum.Title}\n" +
                $"Artist: {selectedAlbum.Artist}\n" +
                $"Label: {selectedAlbum.Label}\n" +
                $"Genre: {selectedAlbum.Genre}\n" +
                $"Song Count: {selectedAlbum.SongCount}";

            albumDetailsRichTextBox.Text = details;

        }
    }
}
