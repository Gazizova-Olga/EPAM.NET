﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class AwardViewModel
    {
        public int Id { get; set; }

        public string Title{ get; set; }
        public string Description { get; set; }

        public bool Granted { get; set; }

        public static AwardViewModel GetViewModel(Award reward, List<Award> userRewards)
        {
            var model = new AwardViewModel();
            model.Id = reward.Id;
            model.Title = reward.Name;
            model.Description = reward.Description;
            if (userRewards != null)
            {
                model.Granted = userRewards.Any(r => r.Id == reward.Id);
            }

            return model;
        }
    }
}