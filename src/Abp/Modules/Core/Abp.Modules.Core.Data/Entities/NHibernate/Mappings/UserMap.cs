﻿namespace Abp.Modules.Core.Entities.NHibernate.Mappings
{
    public class UserMap : EntityMap<User>
    {
        public UserMap()
            : base("AbpUsers")
        {
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.EmailAddress);
            Map(x => x.Password);
            HasMany(x => x.Tenancies).Inverse().Cascade.All();
        }
    }
}
