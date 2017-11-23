using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
namespace recipecontroller.Models
{
    public class RecipeComment
    {
        private string comment;

        public string Comment
        {
            get { return comment; }
            set
            {
                //Comment can be of maximum 400 characters long and consist of upper case letters, lower case letters and numbers where the symbols ".,'-" are allowed
                Regex regex = new Regex("^[a-zA-Z0-9\\s .,'-]{0,400}$");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new ArgumentException("Invalid comment");
                }
               
                comment = value;
            }
        }
    }
}