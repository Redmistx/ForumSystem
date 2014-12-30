namespace ForumSystem.Web.ViewModels.Home
{
    using AutoMapper;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;

    public class IndexForumPostViewModel : IMapFrom<Post>
    {
        public string Title { get; set; }
    }
}