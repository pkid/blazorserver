using System;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using test2.Data;

 

namespace test2.Pages
{
    public partial class AddSitterRequest
    {
        public SitterRequest SitterRequest { get; set; } = new SitterRequest();

        //private SitterRequestService sitterRequestService;

        public AddSitterRequest()
        {

        }

        //public AddSitterRequest(SitterRequestService sitterRequestService)
        //{
        //    this.sitterRequestService = sitterRequestService;
        //}

        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        async Task Close() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));

        private void ResetDialog()
        {
            SitterRequest = new SitterRequest { };
        }


        [Parameter]
        public EventCallback<bool> CloseEventCallback
        {
            get;
            set;
        }


        [Inject] SitterRequestService SitterRequestService { get; set; }

        protected async Task HandleValidSubmit()
        {
            await SitterRequestService.AddSitterRequestAsync(SitterRequest);
            await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        }
    }
}
