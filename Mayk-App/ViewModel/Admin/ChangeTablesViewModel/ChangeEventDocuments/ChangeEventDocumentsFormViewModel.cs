using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App.Event;
using Microsoft.Maui.Storage;
using System.Collections.ObjectModel;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventDocuments
{
    [QueryProperty(nameof(EventId), "eventId")]
    public partial class ChangeEventDocumentsFormViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public readonly IEventService _eventService;
        public readonly IEventDocumentService _eventDocumentService;
        public readonly IDocumentService _documentService;


        public ObservableCollection<string> SelectedFiles;
        public ChangeEventDocumentsFormViewModel(
            IEventService eventService, 
            IDocumentService documentService, 
            IEventDocumentService eventDocumentService)
        {
            _eventService = eventService;
            _documentService = documentService;
            _eventDocumentService = eventDocumentService;

            SelectedFiles = new ObservableCollection<string>();
        }

        public Event? _event;

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        bool isUpdate = false;

        [ObservableProperty]
        bool isWrong = false;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        string fileName;

        [ObservableProperty]
        string filePath;

        int DocumentId;

        [RelayCommand]
        async void PickFile()
        {
            var customFileTypes = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
            {
                {
                    DevicePlatform.iOS, new[]
                    {

                        "com.microsoft.word.doc",
                        "public.plain-text",
                        "org.openxmlformats.wordprocessingml.document"
                    }
                },
                {
                    DevicePlatform.Android, new[]
                    {
                        "application/msword",
                        "text-plain",
                        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                    }
                },
                {
                    DevicePlatform.WinUI, new[]
                    {
                        "doc","docx", "txt"
                    }
                },
            });

            FileResult result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick a File",
                FileTypes = customFileTypes
            });

            if (result == null) return;

            FileName = result.FileName;
            FilePath = result.FullPath;
        }

        [RelayCommand]
        async Task AddEventDocument()
        {
            if (string.IsNullOrWhiteSpace(FileName) ||
                string.IsNullOrWhiteSpace(FilePath) ||
                string.IsNullOrWhiteSpace(Name))
            {
                IsWrong = true;
                return;
            }

            DocumentId = await _documentService.AddAsync(new Document
            {
                Name = FileName,
                Path = FilePath
            });

            await _eventDocumentService.AddAsync(
                new Model.EventDocument
                {
                    EventId = EventId,
                    DocumentId = DocumentId
                });
            await Shell.Current.GoToAsync(nameof(EventDocumentsPage));
        }

        //[RelayCommand]
        //async Task UpdateEvent()
        //{
        //    await _eventDocumentService.UpdateAsync(new Event
        //    {
        //        Name = Name,
        //        Description = Description,
        //        Location = Location,
        //        Date = Date
        //    });
        //    await Shell.Current.GoToAsync(nameof(EventsListPage));
        //}

        [RelayCommand]
        public async Task FillEntrys()
        {
            _event = await _eventService.GetEventById(EventId);

            //if (_event is not null)
            //{
            //    IsUpdate = true;

            //    Name = _event.Name;
            //    Description = _event.Description;
            //    Location = _event.Location;
            //    Date = _event.Date;
            //}
        }
    }
}
