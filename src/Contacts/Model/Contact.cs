using System;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Адрес электронной почты контакта.
        /// </summary>
        private string _email;


        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Адрес электронной почты контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает копию экземпляра класса <see cref="Contact"/>.
        /// </summary>
        /// <returns>Экземпляр класса Contact.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }
    }
}
