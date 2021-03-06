﻿using System;
using PodfilterCore.Models.ContentFilters;

namespace PodfilterCore.Models.PodcastModification
{
    public class EpisodeDurationFilterModification : BasePodcastElementModification
    {
        public readonly DurationFilter.DurationFilterMethods Method;
        public readonly long Duration;

        public EpisodeDurationFilterModification(DurationFilter.DurationFilterMethods method, long duration) 
            : base(
                "//item/itunes:duration", 
                new XElementFilterModification(new DurationFilter(method, duration))
                )
        {
            Method = method;
            Duration = duration;
        }
    }
}