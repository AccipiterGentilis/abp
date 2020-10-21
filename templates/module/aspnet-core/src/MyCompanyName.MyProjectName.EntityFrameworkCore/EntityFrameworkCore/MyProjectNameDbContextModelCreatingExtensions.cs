using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore
{
    public static class MyProjectNameDbContextModelCreatingExtensions
    {
        public static void ConfigureMyProjectName(
            this ModelBuilder builder,
            Action<MyProjectNameModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MyProjectNameModelBuilderConfigurationOptions(
                MyProjectNameDbProperties.DbTablePrefix,
                MyProjectNameDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Person>(b =>
            {
                b.ToTable("People");

                //Configure the base properties
                b.ConfigureByConvention();

                //Configure other properties (if you are using the fluent API)
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);

                b.Property(x => x.Age).IsRequired();
            });
        }
    }
}