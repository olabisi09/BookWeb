﻿using BookWeb.Data;
using BookWeb.Entities;
using BookWeb.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Services
{
    public class AuthorService : IAuthor
    {
        private BookWebDataContext _context;
        public AuthorService(BookWebDataContext context)
        {
            _context = context;
        }

        public void Add(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Author author)
        {
            try
            {
                await _context.AddAsync(author);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var author = await _context.Authors.FindAsync(Id);

            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {

            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetById(int Id)
        {
            var author = await _context.Authors.FindAsync(Id);

            return author;
        }

        public async Task<bool> Update(Author author, int Id)
        {
            var aut = await _context.Authors.FindAsync(Id);
            if (aut != null)
            {
                aut.Title = author.Title;
                aut.Name = author.Name;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
