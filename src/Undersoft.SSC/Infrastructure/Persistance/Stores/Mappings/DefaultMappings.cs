﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Undersoft.SSC.Infrastructure.Persistance.Stores.Mappings
{
    using Undersoft.SSC.Domain.Entities;

    public class DefaultMappings : EntityTypeMapping<Default>
    {
        const string TABLE_NAME = "Defaults";

        public override void Configure(EntityTypeBuilder<Default> builder)
        {
            builder.ToTable(TABLE_NAME, DataStoreSchema.LocalSchema);

            modelBuilder
                .LinkOneToSet<Default, Account>(ExpandSite.OnLeft)
                .LinkOneToSet<Default, Resource>(ExpandSite.OnLeft)
                .LinkOneToSet<Default, Schedule>(ExpandSite.OnLeft)
                .LinkOneToSet<Default, Setting>(ExpandSite.OnRight)
                .LinkOneToSet<Default, Activity>(
                    nameof(Activity.Default),
                    nameof(Activity.Default),
                    nameof(Default.Activities),
                    nameof(Default.Activities),
                    ExpandSite.OnLeft
                );
        }
    }
}
