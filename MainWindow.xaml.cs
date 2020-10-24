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
            loadReplays();
        }

        private void loadReplays() // Function to load the replays from the default directory containing them
        {
            try
            {
                Debug.WriteLine("Loading replays");
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string AccountName = Environment.UserName.ToLower(); // profile username used to find the "my documents" folder specific to the user.
                replayDir = "C:\\Users\\" + AccountName + "\\Documents\\My Games\\Rocket League\\TAGame\\Demos\\";

                var sortedFiles = new DirectoryInfo(replayDir).GetFiles().OrderByDescending(f => f.LastWriteTime).ToList(); // Order the list so the latest modified file is shown at the top.
                sortedFiles.ForEach(f => listbox_replays.Items.Add(f.Name.Replace(".replay", "") + " - " + f.LastWriteTime)); // Clean the file names before importing them into the list.
                Debug.WriteLine("Loaded replays");
                txt_info.Text = "Loaded replays";
            } catch(SystemException err)
            {
                Debug.WriteLine(err);
            }
            
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listbox_replays.SelectedIndex != -1 && replayDir != null)
                {
                    Debug.WriteLine("Copying replay to desktop");
                    File.Copy($"{replayDir}{listbox_replays.SelectedItem.ToString().Split('-')[0].Trim()}.replay", $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{listbox_replays.SelectedItem.ToString().Split('-')[0].Trim()}.replay"); // Get the filename from the selected list item, remove unnecessary clutter, and copy the file to the desktop.
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
