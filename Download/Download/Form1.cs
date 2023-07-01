using Download.Data;

namespace Download
{
    public partial class Torrent : Form
    {
        public Torrent()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            gamesListBox.Items.Clear();
            foreach (var game in Games.Game)
            {
                gamesListBox.Items.Add(game.Name);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Thread downloadThread = new Thread(DownloadData);
            downloadThread.Start();

            ProgressBar();
            DownloadCompleted();
        }

        private void ProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                downloadProgressBar.Value = i;
                Thread.Sleep(30);
            }
        }

        private void DownloadCompleted()
        {
            if (gamesListBox.SelectedItem != null)
            {
                string selectedGameName = gamesListBox.SelectedItem.ToString();

                var selectedGame = Games.Game.FirstOrDefault(game => game.Name == selectedGameName);

                if (selectedGame != null)
                {
                    completedTextBox.Text = $"Download Completed\n" +
                        $"\nName: {selectedGame.Name}\n" +
                        $"\nStudio: {selectedGame.Studio}\n" +
                        $"\nRelease Date: {selectedGame.ReleaseDate}\n" +
                        $"\nDescription: {selectedGame.Description}\n" +
                        $"\nGenre: {string.Join(", ", selectedGame.Genre)}";
                }
            }
        }

        private void DownloadData()
        {
            Thread.Sleep(2000);

            gamesListBox.Invoke(new Action(UpdateListBox));
        }
    }
}