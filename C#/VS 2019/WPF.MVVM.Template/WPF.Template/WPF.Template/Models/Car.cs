using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Template.Models
{
    public class Car
    {
        public Car(string name, string model, string imagePath)
        {
            Name = name;
            Model = model;
            ImagePath = imagePath;
        }

        public string Name { get; set; }
        public string  Model { get; set; }
        public string  ImagePath { get; set; }
    }
}
