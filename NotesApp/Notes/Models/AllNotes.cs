using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Notes.Models
{
    internal class AllNotes
    {

        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public AllNotes() => LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            //Folder where notes are stored
            string appDataPath = FileSystem.AppDataDirectory;
            //Using Linq extensions to load '*.notes.txt' files
            IEnumerable<Note> notes = Directory

               //Select file names from the directory
               .EnumerateFiles(appDataPath, "*.notes.txt")

               //Each file name is used to create a new Note
               .Select(filename => new Note()
               {
                   Filename = filename,
                   Text = File.ReadAllText(filename),
                   Date = File.GetCreationTime(filename)
               })
               //With the final collection of notes, order them by creation date
               .OrderBy(note => note.Date);

            //Add each note into ObservableCollection
            foreach (Note note in notes)
            {
                Notes.Add(note);
            }

        }

    }
}
