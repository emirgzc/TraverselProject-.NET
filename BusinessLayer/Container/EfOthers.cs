using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Announcement;
using DaatAccessLayer.Abstract;
using DaatAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class EfOthers
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			//ef bağımlılığından kurtulduk
			services.AddScoped<ICommentService, CommentManager>();
			services.AddScoped<ICommentDal, EfCommentRepository>();

			services.AddScoped<IDestinationService, DestinationManager>();
			services.AddScoped<IDestinationDal, EfDestinationRepository>();

			services.AddScoped<IAppUserService, AppUserManager>();
			services.AddScoped<IAppUserDal, EfAppUserRepository>();

			services.AddScoped<IReservationService, ReservationManager>();
			services.AddScoped<IReservationDal, EfReservationRepository>();
			
			services.AddScoped<IGuideService, GuideManager>();
			services.AddScoped<IGuideDal, EfGuideRepository>();

			services.AddScoped<IExcelService, ExcelManager>();
			services.AddScoped<IPdfService, PdfManager>();
			
			services.AddScoped<IContactUSService, ContactUSManager>();
			services.AddScoped<IContactUSDal, EfContactUSRepository>();
			
			services.AddScoped<IAnnouncementService, AnnouncementManager>();
			services.AddScoped<IAnnouncementDal, EfAnnouncementRepository>();
		}
		public static void CustomValidator(this IServiceCollection services)
		{
			services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementAddValidator>();
		}
	}
}
