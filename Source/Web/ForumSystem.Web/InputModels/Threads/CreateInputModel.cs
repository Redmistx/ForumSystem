using ForumSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ForumSystem.Web.InputModels.Threads
{
    public class CreateInputModel
    {
        public string Title { get; set; }

        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Content { get; set; }

        public string Tags { get; set; }
    }
}
