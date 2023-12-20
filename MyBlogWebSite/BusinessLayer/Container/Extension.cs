using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extension
    {
        public static void CustomDepencies(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutRepository>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactRepository>();

            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IExperienceDal, EfExperienceRepository>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureRepository>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageRepository>();

            services.AddScoped<IPortfolioService, PortfolioManager>();
            services.AddScoped<IPortfolioDal, EfPortfolioRepository>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceRepository>();

            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISkillDal, EfSkillRepository>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaRepository>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialRepository>();

            services.AddScoped<IAnnouncementService, AnnoucementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementRepository>();

            services.AddScoped<IWriterMessageService, WriterMessageManager>();
            services.AddScoped<IWriterMessageDal, EfWriterMessageRepository>();
        }


    }
}
