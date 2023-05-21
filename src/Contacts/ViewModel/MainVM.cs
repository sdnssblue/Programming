using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для окна MainWindow.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит булевое значение доступности кнопки редактирования.
        /// </summary>
        private bool _isEdit;

        /// <summary>
        /// Хранит булевое значение доступности редактирования текстовых полей.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.Deserialize();
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact);
            RemoveCommand = new RelayCommand(RemoveContact);
            ApplyCommand = new RelayCommand(ApplyChangesContact);
            IsReadOnly = true;
            IsEdit = false;
        }

        /// <summary>
        /// Возвращает и задаёт коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает исходную версию редактируемого контакта.
        /// </summary>
        public ContactVM ContactClone { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (ContactClone != null && Contacts.IndexOf(SelectedContact) != -1)
                {
                    Contacts[Contacts.IndexOf(SelectedContact)] = ContactClone;
                    ContactClone = null;
                }

                _selectedContact = value;
                IsReadOnly = true;

                if (SelectedContact == null)
                {
                    IsReadOnly = true;
                }
                else
                {
                    IsEdit = true;
                }

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду принятия изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает и задаёт значение доступности редактирования текстовых полей.
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set => SetProperty(ref _isReadOnly, value);
        }

        /// <summary>
        /// Возвращает и задаёт значение доступности кнопки редактирования.
        /// </summary>
        public bool IsEdit
        {
            get => _isEdit;
            set => SetProperty(ref _isEdit, value);
        }

        /// <summary>
        /// Вызывает редактирование нового экземпляра класса <see cref="ContactVM"/>.
        /// </summary>
        private void AddContact()
        {
            SelectedContact = null;
            SelectedContact = new ContactVM(new Contact());
            IsReadOnly = false;
            IsEdit = false;

        }

        /// <summary>
        /// Вызывает редактирование выбранного контакта.
        /// </summary>
        private void EditContact()
        {
            ContactClone = (ContactVM)SelectedContact.Clone();
            IsReadOnly = false;
            IsEdit = false;
        }

        /// <summary>
        /// Удаляет выбранный контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null)
            {
                return;
            }

            int index = Contacts.IndexOf(SelectedContact);
            Contacts.RemoveAt(index);

            if (Contacts.Count == 0)
            {
                SelectedContact = null;
            }
            else if (index == Contacts.Count)
            {
                SelectedContact = Contacts[index - 1];
            }
            else
            {
                SelectedContact = Contacts[index];
            }

            ContactSerializer.Serialize(Contacts);
        }

        /// <summary>
        /// Принимает изменения редактирования контакта.
        /// </summary>
        private void ApplyChangesContact()
        {
            if (!Contacts.Contains(SelectedContact))
            {
                Contacts.Add(SelectedContact);
            }
            IsReadOnly = true;
            ContactClone = null;
            IsEdit = true;
            IsReadOnly = true;
            ContactSerializer.Serialize(Contacts);
        }
    }
}