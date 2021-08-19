using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EditableAlbum
{
    public partial class windowAlbum : Form
    {
        AlbumRepository repository = new AlbumRepository();
        
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
            albumList = repository.Load();
            foreach (Album album in albumList)
            {
                albumsListBox.Items.Add(album);
            }
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (albumsListBox.SelectedIndex < 0)
                return;

            Album selectedAlbum = albumList?.ElementAt(listBox.SelectedIndex);

            if(selectedAlbum != null)
            {
                string details = $"Title: {selectedAlbum.Title}\n" +
                                 $"Artist: {selectedAlbum.Artist}\n" +
                                 $"Label: {selectedAlbum.Label}\n" +
                                 $"Genre: {selectedAlbum.Genre}\n" +
                                 $"Song Count: {selectedAlbum.SongCount}";

                albumDetailsRichTextBox.Text = details;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (addForm.AddedAlbum != null)
                {
                    albumsListBox.Items.Add(addForm.AddedAlbum);
                    albumList?.Add(addForm.AddedAlbum);

                    SaveAlbums();

                    albumsListBox.SelectedIndex = albumsListBox.Items.Count - 1;
                }

                addForm = null;
                return;
            }

            if (result == DialogResult.Cancel)
            {
                addForm = null;
                return;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(albumsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select album to edit.");
                return;
            }

            EditForm editForm = new EditForm();
            editForm.InitializeData(albumsListBox.SelectedItem);
            var result = editForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                if(editForm.EditedAlbum != null)
                {
                    int index = albumsListBox.SelectedIndex;
                    albumsListBox.Items.RemoveAt(index);
                    albumsListBox.Items.Insert(index, editForm.EditedAlbum);

                    albumList?.RemoveAt(index);
                    albumList?.Insert(index, editForm.EditedAlbum);

                    SaveAlbums();

                    albumsListBox.SelectedIndex = index;
                }

                editForm = null;
                return;
            }

            if(result == DialogResult.Cancel)
            {
                editForm = null;
                return;
            }
        }

        private void SaveAlbums()
        {
            repository.Save(albumList);
        }
    }
}
