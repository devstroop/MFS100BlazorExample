using System.Net.Http;
using MFS100Example.Extensions;
using MFS100Example.Models.MFS100;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Radzen;
using Radzen.Blazor;

namespace MFS100Example.Components.Pages
{
    public partial class Index
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        protected DeviceInfo DeviceInfo { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        protected async Task GetInfoClicked(MouseEventArgs args)
        {
            try
            {
                var response = await JSRuntime.InvokeAsync<DeviceInfoResponse>("GetMFS100Info");
                if (response != null && response.HttpStaus)
                {
                    DeviceInfo = response.Data.DeviceInfo;
                }
                else
                {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error {response?.Data?.ErrorCode}", $"{response?.Data?.ErrorDescription}");
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Error", ex.Message);
            }

        }

        protected async Task CaptureClicked(MouseEventArgs args)
        {
            try
            {
                CaptureResponse captureRes = await JSRuntime.InvokeAsync<CaptureResponse>("CaptureFinger", 65, 10);
                if (captureRes != null && captureRes.HttpStaus)
                {
                    LF1 = $"data:image/png;base64,{captureRes.Data.BitmapData}";
                }
                else
                {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error {captureRes.Data.ErrorCode}", $"{captureRes.Data.ErrorDescription}");
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Error", ex.Message);
            }

        }


        protected string LF1 { get; set; }
        protected string LF2 { get; set; }
        protected string LF3 { get; set; }
        protected string LF4 { get; set; }
        protected string LF5 { get; set; }
        protected string RF1 { get; set; }
        protected string RF2 { get; set; }
        protected string RF3 { get; set; }
        protected string RF4 { get; set; }
        protected string RF5 { get; set; }
    }
}