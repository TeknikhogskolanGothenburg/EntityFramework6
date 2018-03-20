﻿using System;
using System.Collections.Generic;

namespace MovieApp.Domain
{
    public class Actor
    {
        public Actor()
        {
            Movies = new List<Movie>();
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Quote> Quotes { get; set; }
    }
}
