﻿using Lab_ComponentPartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_ComponentPartialView.Components
{
    public class CommentViewComponent : ViewComponent
    {
        //public IViewComponentResult Invoke(int id)
        //{
        //    HttpClient client = new HttpClient();
        //    //ICollection<CommentViewModel> comments = client.GetFromJsonAsync<ICollection<CommentViewModel>>("https://jsonplaceholder.typicode.com/comments?postId=" +  id).Result;
        //      ICollection<CommentViewModel> comments = client.GetFromJsonAsync<ICollection<CommentViewModel>>("https://jsonplaceholder.typicode.com/comments?postId=" + id).Result;

        //    return View("~/Views/Comonents/_Comment.cshtml", comments);
        //}

        public IViewComponentResult Invoke(int id) 
        { 

            HttpClient client = new HttpClient(); 
            ICollection<CommentViewModel> comments = client.GetFromJsonAsync<ICollection<CommentViewModel>>("https://jsonplaceholder.typicode.com/comments?postId=1").Result;
            return View("~/views/components/comment.cshtml", comments);
        }
    }
}
