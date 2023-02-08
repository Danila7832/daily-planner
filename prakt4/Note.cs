using System;
namespace prakt4
{
    public class Note
    {

        private DateTime date;
        private string name;
        private string data;

        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string Data { get => data; set => data = value; }

        public Note(DateTime date, string name, string data)
        {
            this.date = date;
            this.name = name;
            this.data = data;
        }

        public DateTime getDate() {
            return this.date;
        }

        public String getName() {
            return this.name;
        }

        public String getData() {
            return this.data;
        }
    }
}

