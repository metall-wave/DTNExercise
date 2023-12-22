using DTNExercise.Enums;
using DTNExercise.Models;
using DTNExercise.Services;
using Newtonsoft.Json;

namespace DTNExercise
{
    public partial class MainApplicationForm : Form
    {
        Color defaultStatusForeColor;

        public MainApplicationForm()
        {
            InitializeComponent();
            defaultStatusForeColor = statusTextBox.ForeColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearReportListItems();
            GenerateReportListItems();
        }

        /// <summary>
        /// Uses the lightning.json and assets.json to display the report message.
        /// </summary>
        private void GenerateReportListItems()
        {
            try
            {
                //Parse the lighting entries from the lightning.json into an array
                Lightning[] lightningEntries = ResourceManager.GetLightningEntries();

                //Parse the asset entries from the assets.json into an array
                Asset[] assetEntries = ResourceManager.GetAssetEntries();

                List<long> previousLightningQuadKeys = new List<long>();

                //Display result list
                foreach (Lightning lightning in lightningEntries)
                {
                    long lightningQuadKey = QuadKeyConverterService.LatLongToQuadKey(lightning.latitude,
                        lightning.longitude, Constants.DEFAULT_LOD);

                    Asset assetWithMatchingQuadKey = assetEntries.FirstOrDefault(a => a.quadKey == lightningQuadKey);

                    if (assetWithMatchingQuadKey != null)
                    {
                        if (!previousLightningQuadKeys.Contains(lightningQuadKey))
                        {
                            string resultItem = $"lightning alert for {assetWithMatchingQuadKey.assetOwner}:{assetWithMatchingQuadKey.assetName}";

                            AddReportListItem(resultItem);
                            previousLightningQuadKeys.Add(lightningQuadKey);
                        }
                    }
                }

                ShowStatus($"{Constants.SUCCESS_MESSAGE}{Environment.NewLine}" +
                    $"{Constants.NUMBER_OF_ITEMS_MESSAGE}: {reportListBox.Items.Count}",
                    StatusType.Success);
            }
            catch (Exception ex)
            {
                ShowStatus($"{Constants.ERROR_MESSAGE}:{Environment.NewLine}{ex.Message}",
                    StatusType.Success);
            }
        }

        /// <summary>
        /// Deletes all the existing entries of the report list box
        /// </summary>
        private void ClearReportListItems()
        {
            reportListBox.Items.Clear();
        }

        /// <summary>
        /// Append an item to the report list box
        /// </summary>
        /// <param name="itemToAdd">The text to append to the report list box</param>
        private void AddReportListItem(string itemToAdd)
        {
            reportListBox.Items.Add(itemToAdd);
        }

        /// <summary>
        /// Updates the status text box using the message provided
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="statusType">The status type affects the color of the meesage being displayed</param>
        private void ShowStatus(string message, StatusType statusType = StatusType.Info)
        {
            statusTextBox.Text = message;

            switch (statusType)
            {
                case StatusType.Info:
                    statusTextBox.ForeColor = defaultStatusForeColor;
                    break;

                case StatusType.Success:
                    statusTextBox.ForeColor = Color.Green;
                    break;

                case StatusType.Error:
                    statusTextBox.ForeColor = Color.Red;
                    break;
            }
        }
    }
}