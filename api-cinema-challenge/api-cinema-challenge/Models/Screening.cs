﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set;}
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class ScreeningResponseDTO
    {
        public int id { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ScreeningResponseDTO(Screening screening)
        {
            id = screening.MovieId;
            screenNumber = screening.ScreenNumber;
            capacity = screening.Capacity;
            startsAt = screening.StartsAt;
            createdAt = screening.CreatedAt;
            updatedAt = screening.UpdatedAt;
        }
    }
    public record ScreeningPayload(int screenNumber, int capacity, DateTime startsAt);
}