using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Email { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }

    public class ParticipantResult
    {
        public int ParticipantId { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }
}