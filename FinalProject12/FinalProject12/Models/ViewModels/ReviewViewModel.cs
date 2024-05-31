namespace FinalProject12.Models.ViewModels
{
    public class ReviewViewModel
    {
        public Int32 ReviewID { get; set; }
        public Int32 MovieRating { get; set; }
        public String Description { get; set; }
        public Status Status { get; set; }
        public String MovieName { get; set; }  
    }
}
