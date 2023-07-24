// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace Hangfire.Tags
{
    /// <summary>
    /// Configuration options for tags
    /// </summary>
    public class TagsOptions
    {
        /// <summary>
        /// Sets the maximum length for a tag. The backend storage may implement a default maximum length, which overrides the maximum length specified here, if the maximum length specified here is larger. 
        /// </summary>
        public int? MaxTagLength { get; set; }

        /// <summary>
        /// The background color of the tags in the dashboard, when it's in light mode
        /// </summary>
        public string TagColor { get; set; }

        /// <summary>
        /// The text color of the tags in the dashboard, when it's in light mode
        /// </summary>
        public string TextColor { get; set; }

        /// <summary>
        /// The background color of the tags in the dashboard, when it's in dark mode
        /// </summary>
        public string DarkTagColor { get; set; }

        /// <summary>
        /// The text color of the tags in the dashboard, when it's in dark mode
        /// </summary>
        public string DarkTextColor { get; set; }

        /// <summary>
        /// How to show tags in the dashboard, when clicking on the tags menu
        /// </summary>
        public TagsListStyle TagsListStyle { get; set; } = TagsListStyle.LinkButton; // default
    }
}