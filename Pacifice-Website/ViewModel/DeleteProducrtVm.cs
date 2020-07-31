﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacifice_Website.ViewModel
{
    public class DeleteProducrtVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public string Grade { get; set; }
        public string CarCc { get; set; }
        public string Seating { get; set; }
        public string Fuel { get; set; }
        public string Condition { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string Transmission { get; set; }
        public string Option { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        //Navigation Prop
        public string CategoryName { get; set; }

    }
}
