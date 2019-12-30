using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
    public class TraineeVM
    {
        public int Id { get; set; }
        public int AttitudeScore { get; set; }
        public int ProjectScore { get; set; }
        public int CourseScore { get; set; }
        public int TotalScore { get; set; }
        public int Grade { get; set; }
        public int BatchClass { get; set; }
    }
}
