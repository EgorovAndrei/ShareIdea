using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareIdea.Models
{
    public class IdeaModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required]
        [Display(Name="Название")]
        public string Title { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public string Choices { get; set; }


        public static IdeaModel GetIdea(int id)
        {
            ShareIdeaDBDataContext cont = new ShareIdeaDBDataContext();
            var idea = cont.Ideas.Where(i => i.id == id).FirstOrDefault();
            return new IdeaModel()
            {
                Id = idea.id,
                Title = idea.title,
                Description = idea.description,
                Choices = idea.choices
            };
        }
    }
}