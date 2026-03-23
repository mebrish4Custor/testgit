using System.Collections.Generic;

namespace LMSN.DATA.ViewModels
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            Init();
        }

        public string EventCommand { get; set; }
        public string EventArgument { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }
        public bool IsDetailAreVisible { get; set; }
        public bool IsListAreVisible { get; set; }
        public bool IsSearchAreVisible { get; set; }
        public bool IsPersonVisible { get; set; }  
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        protected virtual void ListMode()
        {
            if (Mode == null)
            {
                Mode = "List";
            }
            IsValid = true;
            //Mode = "List";
            IsListAreVisible = false;
            IsSearchAreVisible = true;
            IsDetailAreVisible = true;
            //IsPersonVisible = false;
        }

        protected virtual void Init6()
        {
            EventCommand = "search";
            EventArgument = string.Empty;
            ValidationErrors = new List<KeyValuePair<string, string>>();
            //ListMode();
        }
        protected virtual void Init()  
        {
            if (EventCommand == null)
            {
                EventCommand = "List";
            }
            //EventCommand = "List";
            EventArgument = string.Empty;
            ValidationErrors = new List<KeyValuePair<string, string>>();
            ListMode();
        }

        protected virtual void AddMode()
        {
            IsListAreVisible = false;
            IsSearchAreVisible = true;
            IsDetailAreVisible = true;

            Mode = "Add";
        }

        protected virtual void EditMode()
        {
            IsListAreVisible = false;
            IsSearchAreVisible = false;
            IsDetailAreVisible = true;

            Mode = "Edit";
        }

        public virtual void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;

                case "save":
                    Save();
                    if (IsValid)
                    {
                        Get();
                    }
                    break;
                case "listgender":
                    Getgender();
                    break;
                case "edit":
                    IsValid = true;
                    Edit();
                    break;

                case "delete":
                    ResetSearch();
                    Delete();
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                case "add":
                    Add();
                    break;

                default:
                    break;

            }
        }

        protected virtual void Getgenders()
        {
            Get();
        }

        protected virtual void Get() { }
        protected virtual void Getgender() { }
        protected virtual void ResetSearch() { }

        protected virtual void Add()
        {
            AddMode();
        }

        protected virtual void Edit()
        {
            EditMode();
        }

        protected virtual void Delete()
        {
            ListMode();
        }

        protected virtual void Save()
        {
            if (ValidationErrors.Count > 0)
            {
                IsValid = false;
            }

            if (!IsValid)
            {
                if (Mode == "Add")
                {
                    AddMode();
                }
                else
                {
                    EditMode();
                }
            }
        }
    }
}
