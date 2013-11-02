﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SharpArch.Domain.DomainModel;

namespace MilesiBastos.AspNet.Identity.NHibernate
{
    public class IdentityUserClaim : EntityWithTypedId<int>
    {
        public virtual string ClaimType { get; set; }

        public virtual string ClaimValue { get; set; }

        public virtual IdentityUser User { get; set; }
    }

    public class IdentityUserClaimMap : ClassMapping<IdentityUserClaim>
    {
        public IdentityUserClaimMap()
        {
            Table("AspNetUserClaims");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
        }
    }

}
