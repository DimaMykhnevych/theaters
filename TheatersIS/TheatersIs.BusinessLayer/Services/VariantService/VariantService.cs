using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.VariantRepositoryN;
using System.Linq;

namespace TheatersIs.BusinessLayer.Services.VariantService
{
    public class VariantService : IVariantService
    {
        private readonly IVariantRepository _variantRepository;


        private readonly IMapper _mapper;


        public VariantService(IVariantRepository variantRepository,
            IMapper mapper)
        {
            _variantRepository = variantRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VariantDTO>> GetVariants()
        {
            IEnumerable<Variant> variants = _variantRepository.GetAll();
            return _mapper.Map<IEnumerable<VariantDTO>>(variants);
        }

        public async Task<VariantDTO> AddVariant(VariantDTO variantDTO)
        {
            Variant varianttoAdd = _mapper.Map<Variant>(variantDTO);
            IEnumerable<Variant> variants = _variantRepository.GetAll();
            Variant existedAuthor = variants.FirstOrDefault
                (v => v.QuestionId == varianttoAdd.QuestionId && v.VariantText == varianttoAdd.VariantText);
            if(existedAuthor == null)
            {
                _variantRepository.Insert(varianttoAdd);
                _variantRepository.Save();
                return _mapper.Map<VariantDTO>(varianttoAdd);
            }

            return null;
        }

        public async Task<bool> DeleteVariant(int id)
        {
            Variant varToDelete = _variantRepository.Get(id);
            if (varToDelete == null)
                return false;
            _variantRepository.Delete(varToDelete);
            _variantRepository.Save();
            return true;
        }
    }
}
