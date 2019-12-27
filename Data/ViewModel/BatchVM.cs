using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
    public class BatchVM
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
    }
}
