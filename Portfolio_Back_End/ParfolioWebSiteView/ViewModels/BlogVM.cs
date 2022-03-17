using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Commet> Commets { get; set; }
        public List<Tag> Tags { get; set; }

        public string GetUserFullName( int? id)
        {
            return Commets.Find(dr => dr.Id == id).User.FullName.ToString();
        }

        public List<Commet> GetParentComments(int? Parentid)
        {
            List<Commet> coment = Commets.FindAll(dr => dr.ParentId == Parentid);
            return coment;
        }

        public bool IsParentComment(int? Parentid)
        {
            return (Commets.Find(dr => dr.ParentId == Parentid) != null);
        }

        public StringBuilder ChildCommentHtml = new StringBuilder();


        public void WriteChildComments(List<Commet> commets)
        {
            foreach (var child in commets)
            {
                ChildCommentHtml.Append($"<li class='comment-children'>" +
                                $"<div class='comment-avatar'>" +
                                    $"<img src='/img/Profile/{child.User.Image}' >" +
                                $"</div>" +
                                $"<div class='comment-details'>" +
                                    $"<h4 class='comment-author'>{child.User.FullName} => {GetUserFullName(child.ParentId)}</h4>" +
                                    $"<span>{child.Date.ToShortDateString()}</span>" +
                                    $"<p>{child.Comment}</p>" +
                                    $"<a href='3'>Reply</a>" +
                                $"</div>" +
                            $"</li>");

                // Recursive Algoritim
                if (IsParentComment(child.Id))
                    WriteChildComments(GetParentComments(child.Id));
            }
        }
    }
}
