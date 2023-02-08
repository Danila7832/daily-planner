using Newtonsoft.Json;

namespace prakt4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Note> data = loadData();

            if (data == null)
            {
                data = new List<Note>();
            }

            saveData(new MainMenu().showMainMenu(data));
        }


        private static List<Note> loadData() {
            string text = File.ReadAllText("../../../../data/notes.json");
            List<Note> result = JsonConvert.DeserializeObject<List<Note>>(text);
            return result;
        }

        private static void saveData(List<Note> notes)
        {
            if (notes != null)
            {
                string json = JsonConvert.SerializeObject(notes);
                File.WriteAllText("../../../../data/notes.json", json);
            }           
        }
    }
}