using System;
using System.Windows.Forms;

namespace EditableAlbum
{
    public partial class AddForm : Form
    {
        Album albumToAdd;

        public Album AddedAlbum { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                AddedAlbum = new Album();
                AddedAlbum.Title = titleTextBox.Text;
                AddedAlbum.Artist = artistTextBox.Text;
                AddedAlbum.Label = labelTextBox.Text;
                AddedAlbum.Genre = genreTextBox.Text;
                AddedAlbum.SongCount = int.Parse(songCountTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                AddedAlbum = null;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
