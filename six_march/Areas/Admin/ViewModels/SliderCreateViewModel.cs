namespace six_march.Areas.Admin.ViewModels
{
    public class SliderCreateViewModel
    {
        public int Offer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
