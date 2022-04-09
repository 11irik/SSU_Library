using System;
using System.Collections.Generic;
using Library.Entities;

namespace Library.DAL
{
    public interface IBookRepo
    {
        Book Add(Book book);

        Book Update(int id, Book book);

        List<Book> GetAll();

        Boolean Delete(int id);

    }
}
