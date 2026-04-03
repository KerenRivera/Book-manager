using System.ComponentModel.DataAnnotations;

namespace Book_manager.Models
{
    public enum ReadingStatus
    {
        [Display(Name = "Want to Read")]
        WantToRead = 0,
        Reading = 1,
        Finished = 2 
    }
}
