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
                ChildCommentHtml.Append($"<li id='comment{child.Id}' class='comment-children'>" +
                                $"<div class='comment-avatar'>" +
                                    $"<img src='/img/Profile/{child.User.Image}' >" +
                                $"</div>" +
                                $"<div class='comment-details'>" +
                                    $"<h4 class='comment-author parent-coment' data-parent='comment{child.ParentId}'>{child.User.FullName} => {GetUserFullName(child.ParentId)}</h4>" +
                                    $"<span>{child.Date.ToShortDateString()}</span>" +
                                    $"<p>{child.Comment}</p>" +
                                    $"<a class='replay' data-add='0' data-userid='0' data-commentid='{child.Id}' href='#'>Reply</a>"+
                                $"</div>" +
                            $"</li>");

                // Recursive Algoritim
                if (IsParentComment(child.Id))
                    WriteChildComments(GetParentComments(child.Id));
            }
        }
        public void WriteChildComments(List<Commet> commets,User user)
        {
            foreach (var child in commets)
            {
                ChildCommentHtml.Append($"<li id='comment{child.Id}' class='comment-children'>" +
                                $"<div class='comment-avatar'>" +
                                    $"<img src='/img/Profile/{child.User.Image}' >" +
                                $"</div>" +
                                $"<div class='comment-details'>" +
                                    $"<h4 class='comment-author parent-coment' data-parent='comment{child.ParentId}'>{child.User.FullName} => {GetUserFullName(child.ParentId)}</h4>" +
                                    $"<span>{child.Date.ToShortDateString()}</span>" +
                                    $"<p>{child.Comment}</p>" +
                                    $"<a class='replay' data-add='0' data-userid='{user.Id}' data-commentid='{child.Id}' href='#'>Reply</a>" +
                                $"</div>" +
                            $"</li>");

                // Recursive Algoritim
                if (IsParentComment(child.Id))
                    WriteChildComments(GetParentComments(child.Id), user);
            }
        }
    }
}
