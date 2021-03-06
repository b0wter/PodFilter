﻿using PodfilterCore.Models.ContentActions;

namespace PodfilterCore.Models.PodcastModification
{
    public class AddStringToTitleModification : BasePodcastElementModification
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