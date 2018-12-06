using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public List<Award> Awards { get; set; }

        public List<AwardViewModel> AvailableAwards { get; set; }

        public User ToUser()
        {
            User user = new User(Id, FirstName, LastName, Birthdate);
            user.Awards = AvailableAwards
                    .Where(r => r.Granted == true)
                    .Select(r => new Award(r.Id)).ToList();
            return user;

        }


        public static UserViewModel GetViewModel(User user, List<Award> availableRewards)
        {
            var userModel = new UserViewModel();
            if (user != null)
            {
                userModel.Id = user.Id;
                userModel.FirstName = user.FirstName;
                userModel.LastName = user.LastName;
                userModel.Birthdate = user.Birthdate;
                userModel.Awards = user.Awards;
                var rewards = new List<AwardViewModel>();
                foreach (var reward in availableRewards)
                {
                    rewards.Add(AwardViewModel.GetViewModel(reward, user.Awards));
                }
                userModel.AvailableAwards = rewards.ToList();
            }
            else
            {
                var rewards = new List<AwardViewModel>();
                foreach (var reward in availableRewards)
                {
                    rewards.Add(AwardViewModel.GetViewModel(reward, null));
                }
                userModel.AvailableAwards = rewards.ToList();
            }


            return userModel;
        }

    }
}