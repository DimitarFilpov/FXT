using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXTrader.Model;
using FXTrader.Repository;

namespace FXTrader.Service
{
    public class PairService : EntityService<Pair>, IPairService
    {

        IUnitOfWork _unitOfWork;
        IPairRepository _pairRepository;

        public PairService(IUnitOfWork unitOfWork, IPairRepository pairRepository) : base(unitOfWork, pairRepository)
        {
            _unitOfWork = unitOfWork;
            _pairRepository = pairRepository;
        }

        public Pair GetById(int id)
        {

            return _pairRepository.GetById(id);

        }

      
    }
}
