using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
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
            await SaveFiles();
            await SitterRequestService.AddSitterRequestAsync(SitterRequest);
            await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        }

        protected async Task SaveFiles()
        {
            RegionEndpoint bucketRegion = RegionEndpoint.EUCentral1;
            IAmazonS3 s3Client = new AmazonS3Client(bucketRegion);
            AwsS3FileManager awsS3FileManager = new AwsS3FileManager(s3Client);


            if (selectedFiles != null)
            {
                foreach (var file in selectedFiles)
                {
                    var s3FileName = await awsS3FileManager.UploadFileAsync(file.Name, file.OpenReadStream());
                    this.SitterRequest.Image = "https://yashuawss3bucket1.s3.eu-central-1.amazonaws.com/" + s3FileName;

                }
            }
        }

        protected async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            //Message = $"{selectedFiles.Count} file(s) selected";
            this.StateHasChanged();
        }
    }
}
