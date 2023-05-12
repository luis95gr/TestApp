﻿using System;
using System.Collections.ObjectModel;

namespace TestApp.Models
{
    public class Event
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsAllDay { get; set; }
        public string EventName { get; set; }
        public string Notes { get; set; }
        public TimeZoneInfo StartTimeZone { get; set; }
        public TimeZoneInfo EndTimeZone { get; set; }
        public Brush Background { get; set; }
        public object RecurrenceId { get; set; }
        public object Id { get; set; }
        public string RecurrenceRule { get; set; }
        public string Location { get; set; }
        public ObservableCollection<DateTime> RecurrenceExceptions { get; set; }
    }
}

