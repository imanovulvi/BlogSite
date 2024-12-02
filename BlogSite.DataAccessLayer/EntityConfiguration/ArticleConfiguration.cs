using BlogSite.Entity.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.EntityConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            

            builder.HasData(new Article()
            {
                Title = "basiq 1",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.",
                CategoryId = Guid.Parse("1A1D2850-D938-4E43-AD8E-EF588EC8DA48"),
              
                ImageId = Guid.Parse("721AA18C-3817-4F2F-A9D8-40BE9D5B52CC")



            },
            new Article()
            {
                Title = "basiq 3",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.",
                CategoryId = Guid.Parse("1A1D2850-D938-4E43-AD8E-EF588EC8DA48"),

                ImageId = Guid.Parse("721AA18C-3817-4F2F-A9D8-40BE9D5B52CC")



            },
            new Article()
            {
                Title = "basiq 2",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.",
                CategoryId = Guid.Parse("1A1D2850-D938-4E43-AD8E-EF588EC8DA48"),

                ImageId = Guid.Parse("721AA18C-3817-4F2F-A9D8-40BE9D5B52CC")



            }


            );

        }
    }
}
