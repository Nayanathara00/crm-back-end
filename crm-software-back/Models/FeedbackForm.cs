using System.ComponentModel.DataAnnotations;

namespace crm_software_back.Models
{
    public class FeedbackForm
    {
        [Key]
        public int FormID { get; set; }
        public string FormName { get; set; }
        public string FormDesc { get; set; }
    }
}
