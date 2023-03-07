﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_SP2023_rggrant1.Models
{
    public class MovieActor
    {
        public int MovieActorId { get; set; }
        [ForeignKey("Movie")]

        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
        [ForeignKey("Actor")]
        public int ActorId { get; set; }    
        public Actor? Actor { get; set; }

    }
}
