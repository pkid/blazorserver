using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using test2.Data;
using test2.Shared;

namespace test2.Pages
{
    public partial class AddSitterRequest
    {
        public SitterRequest SitterRequest { get; set; } = new SitterRequest();
        IReadOnlyList<IBrowserFile> selectedFiles;

        public AddSitterRequest()
        {

        }

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
            //await SaveFiles();
            await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        }

        //[Inject] IAwsS3FileManager AwsS3FileManager { get; set; }

        //protected async Task SaveFiles()
        //{
        //    foreach (var file in selectedFiles)
        //    {
        //        await AwsS3FileManager.UploadFileAsync(file.Name, file.OpenReadStream());
                
        //        //Stream stream = file.OpenReadStream();
        //        //var path = $"{file.Name}";
        //        //FileStream fs = File.Create(path);
        //        //await stream.CopyToAsync(fs);
        //        //stream.Close();
        //        //fs.Close();
        //    }
        //}

        protected async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            //Message = $"{selectedFiles.Count} file(s) selected";
            this.StateHasChanged();
        }
    }
}
