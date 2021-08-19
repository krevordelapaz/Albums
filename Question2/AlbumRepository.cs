using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace EditableAlbum
{
    public class AlbumRepository
    {
        private string albums = "[{\"Artist\":\"NOFX\",\"Title\":\"Wolves in wolves clothing\",\"Label\":\"Fat wreck chords\",\"Genre\":\"Punk\",\"SongCount\": 18},"
                            + "{\"Artist\":\"The Tragically Hip\",\"Title\":\"Music @ work\",\"Label\":\"Universal\",\"Genre\":\"Rock\",\"SongCount\": 14},"
                            + "{\"Artist\":\"The Joel Plaskett Emergency\",\"Title\":\"Down at the Khyber\",\"Label\":\"Brobdingnagian records\",\"Genre\":\"Rock\",\"SongCount\": 12},"
                            + "{\"Artist\":\"Gorillaz\",\"Title\":\"Demon days\",\"Label\":\"EMI\",\"Genre\":\"Rock\",\"SongCount\": 15}]";


        public AlbumRepository()
        {

        }

        public List<Album> Load()
        {
            try
            {
                List<Album> albumList = null; 

                if (File.Exists("albums.json"))
                {
                    using (StreamReader r = new StreamReader("albums.json"))
                    {
                        string json = r.ReadToEnd();
                        albumList = JsonConvert.DeserializeObject<List<Album>>(json);
                    }
                }
                else
                {
                    albumList = JsonConvert.DeserializeObject<List<Album>>(albums);
                }
                
                return albumList;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public void Save(List<Album> albumList)
        {
            string json = JsonConvert.SerializeObject(albumList);
            File.WriteAllText("albums.json", json);
        }
    }
}
