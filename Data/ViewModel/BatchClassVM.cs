using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
   public class BatchClassVM
    {
        public int Id { get; set; }
        public int Class { get; set; }
        public string Batch { get; set; }
        public int Trainee { get; set; }
        public int Trainer { get; set; }
    }
}
