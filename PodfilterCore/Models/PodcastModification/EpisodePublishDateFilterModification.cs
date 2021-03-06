﻿using PodfilterCore.Models.ContentFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PodfilterCore.Models.PodcastModification
{
    public class EpisodePublishDateFilterModification : BasePodcastElementModification
    {
        public readonly DateTime Date;
        public readonly DateFilter.DateFilterMethods Method;

        public EpisodePublishDateFilterModification(DateTime date, DateFilter.DateFilterMethods method)
            : base(
                  "//item/pubDate",
                  new XElementFilterModification(new DateFilter(method, date))
                  )
        {
            Date = date;
            Method = method;
        }
    }
}
