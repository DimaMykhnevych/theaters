using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.VariantService
{
    public interface IVariantService
    {
        Task<IEnumerable<VariantDTO>> GetVariants();

        Task<VariantDTO> AddVariant(VariantDTO variant);

        Task<bool> DeleteVariant(int id);
    }
}
