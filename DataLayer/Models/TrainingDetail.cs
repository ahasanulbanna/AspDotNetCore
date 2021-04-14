using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class TrainingDetail
    {
        public int UserTrainingId { get; set; }
        public int? UserId { get; set; }
        public int? TrainingId { get; set; }
        public DateTime? TrainingDate { get; set; }
    }
}
