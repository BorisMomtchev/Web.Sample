using System.Collections.Generic;

namespace Web.Sample.Models
{
    public class PanelItem
    {
// ReSharper disable InconsistentNaming -- names have to match the expected json format for Kendo to render them.
        public string text { get; set; }
        public string cssClass { get; set; }
        public string url { get; set; }
        public bool expanded { get; set; }
        public string content { get; set; }
        public bool encoded { get; set; }
        public string contentUrl { get; set; }
        public string imageUrl { get; set; }
        public string spriteCssClass { get; set; }
        public List<PanelItem> items { get; set; }
// ReSharper restore InconsistentNaming
    }
}