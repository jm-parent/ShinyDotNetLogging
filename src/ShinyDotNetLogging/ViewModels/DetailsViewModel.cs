using Microsoft.Extensions.Logging;
using Shiny.Logging.AppCenter;
using ShinyDotNetLogging.Services;
using ShinyDotNetLogging.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using TinyIoC;
using TinyMvvm;

namespace ShinyDotNetLogging.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {
        private readonly ILogger<DetailsViewModel> logger;

        public DetailsViewModel(ILogger<DetailsViewModel> logger)
        {
            this.logger = logger;
        }
        public async override Task Initialize()
        {
            await base.Initialize();
            logger.LogInformation($"Test de trace custom",new List<Object>()
            {
                "InitDetailPage","objString",2,new string[] {"phrase1","phrase2"},23.12,'5'
            });
            Name = QueryParameters["name"];
            var dateParameter = (DateTimeOffset)NavigationParameter;

            Date = dateParameter.ToString();
        }

        public string Name { get; set; }
        public string Date { get; set; }


        public string LabelValue { get; set; }

        public ICommand UpdateLabel => new TinyCommand(() =>
        {
            var myDataService = TinyIoCContainer.Current.Resolve<IMyDataService>();
            LabelValue = myDataService.GetMessage() ;

        });
        public ICommand CrashTheApp => new TinyCommand(() =>
        {
            double? nullData = null;
            var r = 10 / nullData;

        });
    }
}
