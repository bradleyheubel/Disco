﻿using Disco.Models.UI.Config.JobPreferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Disco.Web.Areas.Config.Models.JobPreferences
{
    public class IndexModel : ConfigJobPreferencesIndexModel
    {
        public int LongRunningJobDaysThreshold { get; set; }
        public int StaleJobMinutesThreshold { get; set; }

        public List<KeyValuePair<int, string>> LongRunningJobDaysThresholdOptions()
        {
            var options = new List<KeyValuePair<int, string>>() {
                new  KeyValuePair<int, string>(1, "1 Day"),
                new  KeyValuePair<int, string>(2, "2 Days"),
                new  KeyValuePair<int, string>(3, "3 Days"),
                new  KeyValuePair<int, string>(4, "4 Days"),
                new  KeyValuePair<int, string>(5, "5 Days"),
                new  KeyValuePair<int, string>(6, "6 Days"),
                new  KeyValuePair<int, string>(7, "1 Week"),
                new  KeyValuePair<int, string>(14, "2 Weeks"),
                new  KeyValuePair<int, string>(21, "3 Weeks"),
                new  KeyValuePair<int, string>(28, "4 Weeks"),
                new  KeyValuePair<int, string>(35, "5 Weeks"),
                new  KeyValuePair<int, string>(42, "6 Weeks"),
                new  KeyValuePair<int, string>(49, "7 Weeks"),
                new  KeyValuePair<int, string>(56, "8 Weeks")
            };

            var current = this.LongRunningJobDaysThreshold;
            if (!options.Any(o => o.Key == current))
            {
                options.Add(new KeyValuePair<int, string>(current, string.Format("{0} Days", current)));
                options = options.OrderBy(o => o.Key).ToList();
            }

            return options;
        }

        public List<KeyValuePair<int, string>> StaleJobMinutesThresholdOptions()
        {
            var options = new List<KeyValuePair<int, string>>() {
                new KeyValuePair<int, string>(0, "<None>"),
                new KeyValuePair<int, string>(15, "15 minutes"),
                new KeyValuePair<int, string>(30, "30 minutes"),
                new KeyValuePair<int, string>(60, "1 hour"),
                new KeyValuePair<int, string>(60 * 2, "2 hours"),
                new KeyValuePair<int, string>(60 * 4, "4 hours"),
                new KeyValuePair<int, string>(60 * 8, "8 hours"),
                new KeyValuePair<int, string>(60 * 24, "1 day"),
                new KeyValuePair<int, string>(60 * 24 * 2, "2 days"),
                new KeyValuePair<int, string>(60 * 24 * 3, "3 days"),
                new KeyValuePair<int, string>(60 * 24 * 4, "4 days"),
                new KeyValuePair<int, string>(60 * 24 * 5, "5 days"),
                new KeyValuePair<int, string>(60 * 24 * 6, "6 days"),
                new KeyValuePair<int, string>(60 * 24 * 7, "1 week"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 2, "2 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 3, "3 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 4, "4 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 5, "5 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 6, "6 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 7, "7 weeks"),
                new KeyValuePair<int, string>(60 * 24 * 7 * 8, "8 weeks")
            };

            var current = this.StaleJobMinutesThreshold;
            if (!options.Any(o => o.Key == current))
            {
                options.Add(new KeyValuePair<int, string>(current, string.Format("{0} Minutes", current)));
                options = options.OrderBy(o => o.Key).ToList();
            }

            return options;
        }
    }
}