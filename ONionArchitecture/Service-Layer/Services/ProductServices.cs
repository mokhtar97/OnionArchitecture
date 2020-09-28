using AutoMapper;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using DomainLayer.Services;
using FluentValidation;
using RepositoryLayer.Repository;
using ServiceLayer.MappingDTOs;
using ServiceLayer.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper mapper;

        public ProductServices(IProductRepository productRepository, IMapper mapper)
        {
            this._productRepository = productRepository;
            this.mapper = mapper;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            _productRepository.Delete(id);
        }

        public Product Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return _productRepository.Find(id); 
        }

        public List<RepositoryLayer.DTOs.ProductDTO> GetAll()
        {
            var res = _productRepository.List();

            return mapper.Map<List<RepositoryLayer.DTOs.ProductDTO>>(res);
        }

        public Product Post<V>(Product product) where V : AbstractValidator<Product>
        {
            Validate(product, Activator.CreateInstance<V>());

            _productRepository.ADD(product);
            return product;
        }

        private void Validate<V>(Product product, V v) where V : AbstractValidator<Product>
        {
            throw new NotImplementedException();
        }

        public Product Put<V>(Product department) where V : AbstractValidator<Product>
        {
            Validate(department, Activator.CreateInstance<V>());

            _productRepository.Update(department.ID, department);
            return department;
        }


      

        
    }
}