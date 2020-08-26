using System;
using System.Collections.Generic;
using System.Text;

namespace advoop
{
    //derives from post
    class ImagePost:Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() {}

        public ImagePost(string title,string sendByUsername,string imageUrl,bool isPublic) {
            //gets from post
            this.ID = getNextId();
            this.Title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;
            //post doesnt know this property
            this.ImageUrl = imageUrl;
        }
        public override string ToString()
        {
            return String.Format("{0}-{1} -{2} by {3}", this.ID, this.Title,this.ImageUrl, this.sendByUsername);
        }

    }
}
