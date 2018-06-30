using System;
using System.Threading.Tasks;

namespace TheBestSeries.Services.Dialog
{
    public class DialogService : IDialogService
    {
        public DialogService()
        {
        }

        public Task<string> ActionSheetAsync(string title, string cancel, string destruction, params string[] buttons)
        {
            throw new NotImplementedException();
        }

        public Task AlertAsync(string title, string message, string cancel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AlertAsync(string title, string message, string accept, string cancel)
        {
            throw new NotImplementedException();
        }
    }
}
