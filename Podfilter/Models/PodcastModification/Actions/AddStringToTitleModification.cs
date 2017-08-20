﻿using Podfilter.Models.ContentActions;

namespace Podfilter.Models.PodcastModification.Actions
{
    public class AddStringToTitleModification : BasePodcastModification
    {
        public AddStringToTitleModification(string prefix = null, string suffix = null) 
            : base(
                "//channel/title", 
                new XElementActionModification(new AddStringContentAction(prefix, suffix)))
        {
            //
        }
    }
}