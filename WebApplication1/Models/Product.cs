﻿using NHibernate.Mapping.ByCode.Conformist;

namespace WebApplication1.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual decimal Value { get; set; }
        public virtual int TypeId { get; set; }
        public virtual byte[] Imeg { get; set; }

        public virtual Menu Type { get; set; }
    }
}