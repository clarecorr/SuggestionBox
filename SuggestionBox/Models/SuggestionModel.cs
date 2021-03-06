﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        private string topic;
        private string suggestion;

        [Key]
        public int RecordNum { get; set; }

        public string Topic { get; set; }

        public string Suggestion { get; set; }
    }
}