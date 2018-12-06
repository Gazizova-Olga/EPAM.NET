using Depart.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        private static UserBL users = new UserBL();
        private static AwardBL awards = new AwardBL();
        static UsersController()
        {
            users.InitList();
        }

        //
        // GET: /Users/

        public ActionResult Index()
        {
            ViewBag.HeaderText = "Список пользователей";
            return View(users.GetList());
        }


        //
        // GET: /users/Create

        public ActionResult Create()
        {

            return View(UserViewModel.GetViewModel((new User() { firstName = "", lastName = "", birthdate = DateTime.Parse("01.01.01") }), awards.GetList()));
        }

        //
        // POST: /users/Create

        [HttpPost]
        public ActionResult Create(UserViewModel userModel)
        {
            try
            {
                users.Add(userModel.ToUser());

                return RedirectToAction("Список");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /users/Edit/5

        public ActionResult Edit(int id)
        {
            var currentUser = users.GetList().FirstOrDefault(u => u.Id == id);
            return View(UserViewModel.GetViewModel(currentUser, awards.GetList()));
        }

        //
        // POST: /users/Edit/5

        [HttpPost]
        public ActionResult Edit(UserViewModel userModel)
        {
            try
            {

                var userList = users.GetList();

                var currentUser = userList.FirstOrDefault(u => u.Id == userModel.Id);
                if (currentUser != null)
                {
                    var user = userModel.ToUser();
                    currentUser.FirstName = user.FirstName;
                    currentUser.LastName = user.LastName;
                    currentUser.Birthdate = user.Birthdate;
                    currentUser.Awards = user.Awards;
                    users.Edit(user);
                }

                return RedirectToAction("Список");
            }
            catch
            {
                return RedirectToAction("Список");
            }
        }

        //
        // GET: /users/Delete/5

        public ActionResult Delete(int id)
        {
            var currentUser = users.GetList().FirstOrDefault(u => u.Id == id);
            if (currentUser != null)
            {
                users.Remove(currentUser);
            }
            return RedirectToAction("Список");
        }


    }
}