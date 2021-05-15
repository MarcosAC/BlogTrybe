using BlogTrybe.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogTrybe.Infrastructure.Persistence.Configurations
{
    public class PostConfigurations : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(post => post.Id);

            builder.HasOne(post => post.User)
                .WithMany(user => user.UserPosts)
                .HasForeignKey(post => post.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
