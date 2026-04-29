using System.Collections.Generic;

namespace VeriEye.Models
{
    public class ExploreViewModel
    {
        public List<string> FbiHighlights { get; set; } = new List<string>();

        public List<string> ArticleHighlights { get; set; } = new List<string>();
    }
}