using System;
using System.Windows.Forms;

namespace EditableAlbum
{
    public partial class EditForm : Form
    {
        Album albumToEdit;

        public Album EditedAlbum { get; private set; }

        public EditForm()
        {
            InitializeComponent();
        }

        public void InitializeData(object selectedItem)
        {
            albumToEdit = selectedItem as Album;
            titleTextBox.Text = albumToEdit.Title;
            artistTextBox.Text = albumToEdit.Artist;
            labelTextBox.Text = albumToEdit.Label;
            genreTextBox.Text = albumToEdit.Genre;
            songCountTextBox.Text = albumToEdit.SongCount.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                EditedAlbum = new Album();
                EditedAlbum.Title = titleTextBox.Text;
                EditedAlbum.Artist = artistTextBox.Text;
                EditedAlbum.Label = labelTextBox.Text;
                EditedAlbum.Genre = genreTextBox.Text;
                EditedAlbum.SongCount = int.Parse(songCountTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                EditedAlbum = null;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
