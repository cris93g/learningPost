using System;
using System.Collections.Generic;
using System.Text;

namespace advoop
{
    class Post
    {
        private static int currentPostId;
        
        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string sendByUsername { get; set; }
        protected bool isPublic { get; set; }

        //default constructor
        public Post()
        {
            ID = 0;
            Title = "My first Post";
            isPublic = true;
            sendByUsername = "cristian";
        }

        //
        public Post(string title,bool isPublic,string sendByUsername)
        {
            this.ID = getNextId();
            this.Title =title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;
        }
        protected int getNextId()
        {
            return ++currentPostId;
        }
        public void update(string title,bool isPublic)
        {
            this.Title = title;
            this.isPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0}-{1} - by {2}",this.ID, this.Title, this.sendByUsername);
        }
    }
}
