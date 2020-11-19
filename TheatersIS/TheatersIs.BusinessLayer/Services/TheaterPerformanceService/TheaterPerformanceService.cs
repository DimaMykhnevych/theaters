using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Mappers;
using TheatersIs.BusinessLayer.Services.EmailService;
using TheatersIS.DataLayer.Builders.TheaterPerformanceN;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN;
using TheatersIS.DataLayer.Repositories.UserRepositoryN;

namespace TheatersIs.BusinessLayer.Services.TheaterPerformanceService
{
    public class TheaterPerformanceService : ITheaterPerformanceService
    {
        private readonly IMapper _mapper;
        private readonly ITheaterPerformanceRepository _theaterPerformanceRepository;
        private readonly ITheaterPerformanceQueryBuilder _query;
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public TheaterPerformanceService(IMapper mapper,
            ITheaterPerformanceRepository theaterPerformanceRepository,
            IUserAnswerRepository userAnswerRepository,
            IUserRepository userRepository,
            ITheaterPerformanceQueryBuilder theaterPerformanceQueryBuilder,
            IEmailService emailService)
        {
            _mapper = mapper;
            _theaterPerformanceRepository = theaterPerformanceRepository;
            _userAnswerRepository = userAnswerRepository;
            _userRepository = userRepository;
            _emailService = emailService;
            _query = theaterPerformanceQueryBuilder;

        }



        public async Task<TheaterPerformanceDTO> GetTheaterPerformance(int id)
        {
            TheaterPerformance theaterPerformance =
                await _theaterPerformanceRepository.GetTheaterPerformance(id);
            return _mapper.Map<TheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetPerformancesByTheaterId(int id)
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
               await _theaterPerformanceRepository.GetTheaterPerformances();
            IEnumerable<TheaterPerformance> result = theaterPerformances
                .Where(tp => tp.TheaterId == id && tp.Performance.PerformanceStatus == PerformanceStatus.ok);
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(result);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetTheaterPerformances()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
                await _theaterPerformanceRepository.GetTheaterPerformances();
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(theaterPerformances);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetActiveTheaterPerformances()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
                await _theaterPerformanceRepository.GetTheaterPerformances();
            IEnumerable<TheaterPerformance> activePerformances =
                theaterPerformances.Where(tp => tp.Performance.PerformanceStatus == PerformanceStatus.ok);
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(activePerformances);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetCanceledTheaterPerformances()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
               await _theaterPerformanceRepository.GetTheaterPerformances();
            IEnumerable<TheaterPerformance> canceledPerformances =
                theaterPerformances.Where(tp => tp.Performance.PerformanceStatus == PerformanceStatus.canceled);
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(canceledPerformances);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> GetPostponedTheaterPerformances()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
               await _theaterPerformanceRepository.GetTheaterPerformances();
            IEnumerable<TheaterPerformance> posponedPerformances =
                theaterPerformances.Where(tp => tp.Performance.PerformanceStatus == PerformanceStatus.postponed);
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(posponedPerformances);
        }

        public async Task<IEnumerable<TheaterPerformanceDTO>> SearchTheaterPerformances
            (SearchTheaterPerformanceDTO parameters)
        {
            List<TheaterPerformance> theaterPerformances =
                 _query.SetBaseTheaterPerformanceInfo()
                 .SetTheaterName(parameters.TheaterName)
                 .SetPerformanceName(parameters.PerformanceName)
                 .SetTheaterPerformanceDate(parameters.StartDate, parameters.EndDate)
                 .SetTheaterPerformancePrice(parameters.StartPrice, parameters.EndPrice)
                 .Sort(parameters.FieldToSort, parameters.Descending)
                 .Build()
                 .ToList();
            return _mapper.Map<IEnumerable<TheaterPerformanceDTO>>(theaterPerformances);

        }

        public async Task<IEnumerable<TicketSalesDTO>> GetPeriodTicketSales
            (SearchTheaterPerformanceDTO parameters)
        {
            List<TheaterPerformance> theaterPerformances =
                 _query.SetBaseTheaterPerformanceWithOrders()
                 .SetTheaterName(parameters.TheaterName)
                 .SetTheaterPerformanceDate(parameters.StartDate, parameters.EndDate)
                 .Build()
                 .ToList();

            IEnumerable<IGrouping<int, TheaterPerformance>> grouppedTheaterPerformances =
                theaterPerformances.GroupBy(t => t.TheaterId);

            IEnumerable<TicketSalesDTO> ticketSales =
               grouppedTheaterPerformances.Select(x => new TicketSalesDTO
               {
                   Id = x.Select(t => t.TheaterId).FirstOrDefault(),
                   TheaterName = x.Select(t => t.Theater.Name).FirstOrDefault(),
                   StartDate = parameters.StartDate,
                   EndDate = parameters.EndDate,
                   Revenue = x.SelectMany(t => t.Orders).Sum(t => t.TheaterPerformance.TicketPrice * t.TicketsAmount)
               }).OrderByDescending(x => x.Revenue);

            return ticketSales;

        }


        public async Task<AddAndUpdateTheaterPerformanceDTO> AddTheaterPerformance
            (AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            TheaterPerformance theaterPerformance = _mapper.Map<TheaterPerformance>(theaterPerformanceDTO);

            _theaterPerformanceRepository.Insert(theaterPerformance);
            _theaterPerformanceRepository.Save();


            TheaterPerformance addedTheaterPerformance =
                await _theaterPerformanceRepository.GetTheaterPerformance(theaterPerformance.Id);
            IEnumerable<User> usersToSendEmail =  await GetUsersToSentEmail(addedTheaterPerformance);

            await _emailService.SendNewPerformanceEmail(_mapper.Map<IEnumerable<UserDTO>>(usersToSendEmail),
                _mapper.Map<TheaterPerformanceDTO>(addedTheaterPerformance));


            return _mapper.Map<AddAndUpdateTheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<AddAndUpdateTheaterPerformanceDTO> UpdateTheaterPerformance
            (int id, AddAndUpdateTheaterPerformanceDTO theaterPerformanceDTO)
        {
            TheaterPerformance theaterPerformance = _mapper.Map<TheaterPerformance>(theaterPerformanceDTO);
            theaterPerformance.Id = id;
            await _theaterPerformanceRepository.UpdateAsync(theaterPerformance);
            return _mapper.Map<AddAndUpdateTheaterPerformanceDTO>(theaterPerformance);
        }

        public async Task<bool> DeleteTheaterPerformance(int id)
        {
            TheaterPerformance tpToDelete = _theaterPerformanceRepository.Get(id);
            if (tpToDelete == null)
                return false;
            _theaterPerformanceRepository.Delete(tpToDelete);
            _theaterPerformanceRepository.Save();
            return true;
        }

        public async Task<IEnumerable<TheaterAttendanceDTO>> GetTheaterPerformancesWithOrders()
        {

            return await GetTheatersAttendanceObjects();
        }

        public async Task<IEnumerable<TheaterAttendanceDTO>> GetMostPopularTheaters()
        {
            IEnumerable<TheaterAttendanceDTO> theaterAttendances =
                await GetTheatersAttendanceObjects();


            IEnumerable<TheaterAttendanceDTO> mostPopularTheaters =
                theaterAttendances.Where(t => t.AttendanceAmount ==
                theaterAttendances.Max(m => m.AttendanceAmount));


            return mostPopularTheaters;
        }

        public async Task<IEnumerable<TheaterAttendanceDTO>> GetMostUnpopularTheaters()
        {
            IEnumerable<TheaterAttendanceDTO> theaterAttendances =
                await GetTheatersAttendanceObjects();


            IEnumerable<TheaterAttendanceDTO> mostUnpopularTheaters =
                theaterAttendances.Where(t => t.AttendanceAmount ==
                theaterAttendances.Min(m => m.AttendanceAmount));


            return mostUnpopularTheaters;
        }

        public async Task<IEnumerable<PerformanceAttendanceDTO>> GetPerformanceAttendances()
        {
            return await GetPerformanceAttendancesObjects();
        }

        public async Task<IEnumerable<PerformanceAttendanceDTO>> GetMostPopularPerformances()
        {
            IEnumerable<PerformanceAttendanceDTO> performanceAttendances =
               await GetPerformanceAttendancesObjects();


            IEnumerable<PerformanceAttendanceDTO> mostPopularPerformances =
                performanceAttendances.Where(t => t.AttendanceAmount ==
                performanceAttendances.Max(m => m.AttendanceAmount));


            return mostPopularPerformances;
        }

        public async Task<IEnumerable<PerformanceAttendanceDTO>> GetMostUnpopularPerformances()
        {
            IEnumerable<PerformanceAttendanceDTO> performanceAttendances =
                await GetPerformanceAttendancesObjects();


            IEnumerable<PerformanceAttendanceDTO> mostPopularPerformances =
                performanceAttendances.Where(t => t.AttendanceAmount ==
                performanceAttendances.Min(m => m.AttendanceAmount));


            return mostPopularPerformances;
        }

        public async Task<IEnumerable<PopularGenresDTO>> GetPopularGenres()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
            await _theaterPerformanceRepository.GetTheaterPerformancesWithOrders();
            IEnumerable<IGrouping<PerformanceGenre, TheaterPerformance>> attendanceAmount = 
                theaterPerformances
                .GroupBy(t => t.Performance.PerformanceGenre);

            IEnumerable<PopularGenresDTO> popularGenres =
                attendanceAmount.Select(x => new PopularGenresDTO
                {
                    Id = x.Select(t => t.Id).FirstOrDefault(),
                    PerformanceGenre = x.Key,
                    AttendanceAmount = x.SelectMany(t=>t.Orders).Count()

                }).OrderByDescending(x => x.AttendanceAmount);
            return popularGenres;

        }

        public async Task<IEnumerable<PopularAuthorsDTO>> GetPopularAuthors()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
          await _theaterPerformanceRepository.GetTheaterPerformancesWithOrders();
            IEnumerable<IGrouping<string, TheaterPerformance>> attendanceAmount =
                theaterPerformances
                .GroupBy(t => t.Performance.Author);

            IEnumerable<PopularAuthorsDTO> popularAuthors =
                attendanceAmount.Select(x => new PopularAuthorsDTO
                {
                    Id = x.Select(t => t.Id).FirstOrDefault(),
                    Author = x.Key,
                    AttendanceAmount = x.SelectMany(t => t.Orders).Count()

                }).Where(x => x.Author != null).OrderByDescending(x => x.AttendanceAmount);
            return popularAuthors;
        }

        public async Task<IEnumerable<PopularComposersDTO>> GetPopularComposers()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
          await _theaterPerformanceRepository.GetTheaterPerformancesWithOrders();
            IEnumerable<IGrouping<string, TheaterPerformance>> attendanceAmount =
                theaterPerformances
                .GroupBy(t => t.Performance.Composer);

            IEnumerable<PopularComposersDTO> popularComposers =
                attendanceAmount.Select(x => new PopularComposersDTO
                {
                    Id = x.Select(t => t.Id).FirstOrDefault(),
                    Composer = x.Key,
                    AttendanceAmount = x.SelectMany(t => t.Orders).Count()

                }).Where(x => x.Composer != null).OrderByDescending(x => x.AttendanceAmount);
            return popularComposers;
        }

        private async Task<IEnumerable<TheaterAttendanceDTO>> GetTheatersAttendanceObjects()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
             await _theaterPerformanceRepository.GetTheaterPerformancesWithOrders();
            IEnumerable<IGrouping<int, TheaterPerformance>> attendanceAmount = theaterPerformances
                .GroupBy(t => t.TheaterId);

            IEnumerable<TheaterAttendanceDTO> theaterAttendances =
                attendanceAmount.Select(x => new TheaterAttendanceDTO
                {
                    Id = x.Select(t => t.Theater.Id).FirstOrDefault(),
                    Name = x.Select(t => t.Theater.Name).FirstOrDefault(),
                    TheaterType = x.Select(t => t.Theater.TheaterType).FirstOrDefault(),
                    AttendanceAmount = x.SelectMany(t => t.Orders).Count(),
                }).OrderByDescending(x => x.AttendanceAmount);

            return theaterAttendances;

        }

        private async Task<IEnumerable<PerformanceAttendanceDTO>> GetPerformanceAttendancesObjects()
        {
            IEnumerable<TheaterPerformance> theaterPerformances =
             await _theaterPerformanceRepository.GetTheaterPerformancesWithOrders();
            IEnumerable<IGrouping<int, TheaterPerformance>> attendanceAmount = theaterPerformances
                .GroupBy(t => t.PerformanceId);

            IEnumerable<PerformanceAttendanceDTO> performanceAttendances =
                attendanceAmount.Select(x => new PerformanceAttendanceDTO
                {
                    Id = x.Select(t => t.Performance.Id).FirstOrDefault(),
                    Name = x.Select(t => t.Performance.Name).FirstOrDefault(),
                    PerformanceGenre = x.Select(t => t.Performance.PerformanceGenre).FirstOrDefault(),
                    Author = x.Select(t => t.Performance.Author).FirstOrDefault(),
                    AttendanceAmount = x.SelectMany(t => t.Orders).Count(),
                }).OrderByDescending(x => x.AttendanceAmount);
            return performanceAttendances;
        }


        private async Task<IEnumerable<User>> GetUsersToSentEmail( TheaterPerformance theaterPerformance)
        {
            List<User> usersToSendEmails = new List<User>();
            bool needToSendEmail = false;
            IEnumerable<UserAnswer> userAnswers = await _userAnswerRepository.GetUserAnswersWithVariants();
            IEnumerable<IGrouping<int, UserAnswer>> groupedUserAnswers =
                userAnswers.GroupBy(ans => ans.UserId);
             
            foreach(var key in groupedUserAnswers)
            {
                needToSendEmail = false;
                foreach (var ans in key)
                {
                    switch (ans.Variant.QuestionId)
                    {
                        case 1:
                            if(PerformanceGenreMapper.GetPerformanceGenre(ans.Variant.VariantText)
                                == theaterPerformance.Performance.PerformanceGenre)
                            {
                                needToSendEmail = true;
                            }
                            break;
                        case 2:
                            if(ans.Variant.VariantText.ToLower() == theaterPerformance.Performance.Author?.ToLower())
                            {
                                needToSendEmail = true;
                            }
                            break;
                        case 3:
                            if (ans.Variant.VariantText.ToLower() == theaterPerformance.Performance.Composer?.ToLower())
                            {
                                needToSendEmail = true;
                            }
                            break;
                        case 4:
                            if(TheaterTypeMapper.GetTheaterType(ans.Variant.VariantText)
                                == theaterPerformance.Theater.TheaterType)
                            {
                                needToSendEmail = true;
                            }
                            break;

                    }
                }
                if (needToSendEmail)
                {
                    usersToSendEmails.Add(_userRepository.Get(key.Key));
                }
            }



            return usersToSendEmails;
        }
   
    }
}
