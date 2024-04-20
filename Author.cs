using System;
namespace Seneca
{
    public class Author
    {
        private string Name;
        private string Email;

        public Author()
        {
            this.Name = null;
            this.Email = null;
        }

        public Author(string name, string email)
        {
            SetAuthorName(name);
            SetAuthorEmail(email);
        }

        public void SetAuthorName(string name)
        {
            this.Name = name;
        }

        public void SetAuthorEmail(string email)
        {
            this.Email = email;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetEmail()
        {
            return Email;
        }
    }
}

