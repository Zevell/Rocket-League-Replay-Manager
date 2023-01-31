using System;
using System.Windows;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace Rocket_League_Replay_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string replayDir;
        public MainWindow()
        {
            InitializeComponent();
            // Let the user know we are loading the replays, and call the function to do so.
            txt_info.Text = "Loading";
            Loaded += formLoaded;
        }

        private void formLoaded(object sender, RoutedEventArgs e)
        {
            loadReplays();
        }
        private void loadReplays() // Function to load the replays from the default directory containing them
        {
            try
            {
                Debug.WriteLine("Loading replays");
                replayDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Rocket League\\TAGame\\Demos\\";
                Debug.WriteLine("Replay Directory: " + replayDir);

                var sortedFiles = new DirectoryInfo(replayDir).GetFiles("*.replay").OrderByDescending(f => f.LastWriteTime).ToList(); // Order the list so the last modified file is shown at the top.

                int i = 0;
                foreach (FileInfo file in sortedFiles) // Clean the file names, and fetch them using RocketLeagueReplayParser. If none exist, use the file name instead.
                {
                    string finalName = "";
                    try
                    {
                        finalName = RocketLeagueReplayParser.Replay.Deserialize(replayDir + file.Name).Properties["ReplayName"].Value.ToString();
                    } catch { }
                    if (finalName == "") finalName = file.Name.Replace(".replay", "");
                    listbox_replays.Items.Add(finalName + " - " + file.LastWriteTime);
                    i += 1;
                }
                Debug.WriteLine("Loaded replays");
                txt_info.Text = "Loaded replays";
            } catch(SystemException err)
            {
                Debug.WriteLine(err);
            }
            
        }

        public void btn_export_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listbox_replays.SelectedIndex != -1 && replayDir != null)
                {
                    Debug.WriteLine("Copying replay to desktop");
                    var sortedFiles = new DirectoryInfo(replayDir).GetFiles("*.replay").OrderByDescending(f => f.LastWriteTime).ToList(); // Order the list so the last modified file is shown at the top.
                    string fileName = sortedFiles[listbox_replays.SelectedIndex].Name;
                    File.Copy($"{replayDir}{fileName}", $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{fileName}"); // Get the filename from the selected list item, remove unnecessary clutter, and copy the file to the desktop.
                    txt_info.Text = "Exported to desktop";
                    Debug.WriteLine("Copied replay to desktop");
                }
            } catch(SystemException err)
            {
                Debug.WriteLine(err);
            }
        }

        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            refreshReplayList();
        }

        private void refreshReplayList()
        {
            try
            {
                Debug.WriteLine("Clearing replay list");
                listbox_replays.Items.Clear(); // Remove all items from the list containing the replay names and dates
                loadReplays();
            } catch(SystemException err)
            {
                Debug.WriteLine(err);
            }
        }

        private void frm_main_Drop(object dropped, DragEventArgs e)
        {
            try
            {
                if (dropped == null) return;
                if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return; // If what the user has dropped is not a file, then ignore it.

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); // Create a string array containing all file names and/or paths (unclear).
                short ignoredFileCount = 0;
                Debug.WriteLine("Checking droppeded file(s)");
                foreach (var file in files)
                {
                    var ext = Path.GetExtension(file);
                    if (ext.Equals(".replay"))
                    {
                        Debug.WriteLine("Importing replay");
                        File.Move(file, $"{replayDir}\\{file.Substring(file.LastIndexOf('\\'))}");
                        Debug.WriteLine("Imported replay");
                    }
                    else
                    {
                        Debug.WriteLine("File ignored");
                        ignoredFileCount += 1;
                    }
                }

                if (ignoredFileCount > 0)
                {
                    txt_info.Text = ignoredFileCount.ToString() + " files ignored";
                }
                else
                {
                    txt_info.Text = "All imported";
                }
                refreshReplayList();
            } catch(SystemException err)
            {
                Debug.WriteLine(err);
            }
        }
    }
}
