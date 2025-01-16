﻿using FullFiorellaProject.Models;

namespace FullFiorellaProject.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfos { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public AboutVideo AboutVideos { get; set; }
    }
}