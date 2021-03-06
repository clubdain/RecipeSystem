//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;


namespace RecipeForDisaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
  
        private string _username;       
        private string _password;       
        private string _email;

        public user(string username, string password, string email)
        {
            username = username ?? throw new ArgumentNullException(nameof(username));
            password = password ?? throw new ArgumentNullException(nameof(password));
            email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string username { get { return _username; }
        set
        {
            //Username can be of lenght 3-15 characters consisting of lower case character, digit or special symbol "_-"
            Regex regex = new Regex("^[a-z0-9_-]{3,15}$");
            Match match = regex.Match(value);

            if (!match.Success)
            {
                throw new ArgumentException("Invalid username");
            }
            _username = value;
        }
    }

        public string password
        {
            get { return _password; }
            set
            {
                //Password has to be of at least length 6 consisting of at least one digit and contains at least one lower case or upper case character
                Regex regex = new Regex(@"(?=^[^\s]{6,}$)(?=.*\d)(?=.*[a-zA-Z])");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new ArgumentException("Invalid password");
                }

                var data = Encoding.ASCII.GetBytes(value);
                var md5 = new MD5CryptoServiceProvider();
                var hash = md5.ComputeHash(data);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                _password = sb.ToString();
            }
        }

        public string email
        {
            get { return _email; }
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException("Invalid email");
                }

                _email = value;

            }
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recipe> recipe { get; set; }
    }
}
