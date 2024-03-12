using six_march.Models;

namespace six_march.ViewModels
{
    public class HomeViewModel
    {
        public List<Shipping> Shippings { get; set; }
        public List<Slider> Sliders { get; internal set; }
    }
}