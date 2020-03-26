using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Create the note to add to the editor
        /// </summary>
        Note note = new Note();
        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler for New Note button. Creates a new note and applies it to the editor
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event args</param>
        public void OnNewNote(Object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to clear contents of the note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">Routed event args</param>
        public void OnClearNote(Object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event handler to mutate note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">Event args</param>
        public void OnMutateNode(Object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splitter";
            note.Body = "There is no monster more dangerous that a lack of compassion";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
