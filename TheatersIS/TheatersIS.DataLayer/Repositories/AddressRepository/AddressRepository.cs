using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Entities;

namespace TheatersIS.DataLayer.Repositories.AddressRepositoryN
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(TheaterDbContext context) : base(context) { }
    }
}
