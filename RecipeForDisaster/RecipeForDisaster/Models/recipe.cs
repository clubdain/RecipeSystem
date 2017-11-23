using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.ClientServices.Providers;

namespace recipecontroller.Models
{
    public class Recipe
    {
        private string title;
        private string author;
        private float rating;
        private string description;
        private string recipeType;

        public Recipe(string _title, string _author, float _rating, string _description, string _recipeType)
        {
            title = _title ?? throw new ArgumentNullException(nameof(title));
            author = _author ?? throw new ArgumentNullException(nameof(author));
            rating = _rating;
            description = _description ?? throw new ArgumentNullException(nameof(description));
            recipeType = _recipeType ?? throw new ArgumentNullException(nameof(recipeType));
        }

        public string Title
        {
            get { return title; }
            set
            {
                //Title can be of maximum 280 characters long and consist of upper case letters, lower case letters and numbers where the symbols ".,'-" are allowed
                Regex regex = new Regex("^[a-zA-Z0-9\\s .,'-]{0,280}$");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new ArgumentException("Invalid title");
                }
                title = value;
            }
        }

        public string Author
        {

            get { return author; }
            set
            {
                //Author can be of lenght 3-15 characters consisting of lower case character, digit or special symbol "_-"
                Regex regex = new Regex("^[a-z0-9_-]{3,15}$");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new ArgumentException("Invalid author");
                }
                author = value;
            }
        }

        public float Rating
        {
            get { return rating; }
            set
            {
                //Rating has to be a float number between 0 and 10
                if (!(rating >= 0 && rating <= 10))
                {
                    throw new ArgumentException("Invalid Rating");
                }
                rating = value;
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string RecipeType
        {
            get { return recipeType; }
            set
            {
                //Rating has to be a float number between 0 and 10
                if (!(Enum.IsDefined(typeof(Meal), recipeType)))
                {
                    throw new ArgumentException("Invalid recipe type");
                }
                recipeType = value;
            }
        }

        public enum Meal
        {
            Breakfast,
            Lunch,
            Appetizer,
            Dinner,
            Dessert
        };

    }
}