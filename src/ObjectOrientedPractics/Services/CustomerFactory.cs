﻿using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о покупателе.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о покупателе.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о покупателе.</returns>
        public static Customer DefaultCustomer()
        {
            Customer customer = new Customer();
            customer.FullName = "Full name";
            customer.Address = new Address();
            customer.Address.Apartment = "Apartment";
            customer.Address.City = "City";
            customer.Address.Building = "Building";
            customer.Address.Street = "Street";
            customer.Address.Country = "Country";
            customer.Address.Index = 100000;

            return customer;
        }
    }
}