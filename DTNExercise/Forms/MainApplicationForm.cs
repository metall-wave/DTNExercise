using DTNExercise.Enums;
using DTNExercise.Models;
using DTNExercise.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DTNExercise
{
    public partial class MainApplicationForm : Form
    {
        Color defaultStatusForeColor;
        private readonly IResourceService _resourceService;
        private readonly ICoordinatesConverterService _coordinatesConverter;

        public MainApplicationForm(IResourceService resourceService, ICoordinatesConverterService coordinatesConverter)
        {
            _resourceService = resourceService;
            _coordinatesConverter = coordinatesConverter;
            InitializeComponent();
            UpdateInstructionsText();
            SetDefaultStatusForeColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearReportListItems();
            GenerateReportListItems();
        }

        /// <summary>
        /// Uses the lightning.json and assets.json to display the report message.
        /// </summary>
        public void GenerateReportListItems()
        {
            try
            {
                //Parse the lighting entries from the lightning.json into an array
                Lightning[] lightningEntries = _resourceService.GetLightningEntries();

                //Parse the asset entries from the assets.json into an array
                Asset[] assetEntries = _resourceService.GetAssetEntries();

                List<long> previousLightningQuadKeys = new List<long>();

                //Display result list
                foreach (Lightning lightning in lightningEntries)
                {
                    long lightningQuadKey = _coordinatesConverter.LatLongToQuadKey(lightning.latitude,
                        lightning.longitude, Constants.DEFAULT_LOD);

                    Asset assetWithMatchingQuadKey = assetEntries.FirstOrDefault(a => a.quadKey == lightningQuadKey);

                    if (assetWithMatchingQuadKey != null)
                    {
                        //Check to see if a strike has occurred for a particular asset
                        //A time complexity of O(n). This means that the time it takes to check if an item is in a List
                        //increases linearly with the number of items already in the List.
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
                    StatusType.Error);
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

        /// <summary>
        /// Updates the instructions text box
        /// </summary>
        private void UpdateInstructionsText()
        {
            instructionsTextbox.Text = Constants.INSTRUCTIONS;
        }

        private void SetDefaultStatusForeColor()
        {
            defaultStatusForeColor = statusTextBox.ForeColor;
        }

        public ListBox GetReportListBox()
        {
            return reportListBox;
        }
    }
}