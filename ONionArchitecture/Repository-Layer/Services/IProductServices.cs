
using DomainLayer.Entities;
using FluentValidation;
using RepositoryLayer.DTOs;

using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Services
{
    public interface IProductServices 
    {
        Product Post<V>(Product model) where V : AbstractValidator<Product>;

        Product Put<V>(Product model) where V : AbstractValidator<Product>;

        void Delete(int id);

        Product Get(int id);

        List<RepositoryLayer.DTOs.ProductDTO> GetAll();
    }
}
