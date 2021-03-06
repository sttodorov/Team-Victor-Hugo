﻿namespace OnlineBooking.WebForms.App_Data
{
    using OnlineBooking.WebForms.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IOnlineBookingContext
    {
        IDbSet<Country> Counties { get; set; }

        IDbSet<City> Cities { get; set; }

        IDbSet<Place> Places { get; set; }

        IDbSet<Service> Services { get; set; }

        IDbSet<Night> Nights { get; set; }

        IDbSet<Reservation> Reservations { get; set; }

        IDbSet<Notification> Notifications { get; set; }

        IDbSet<T> SetEntity<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();
    }
}
