using DomainLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {


        public ProductValidator()
        {
            RuleFor(d => d)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });

            RuleFor(d => d.ProductName)
                .NotEmpty().WithMessage("Is necessary to inform the Department Name.")
                .MaximumLength(100).WithMessage("Department Name must be no longer than 100 characters.")
                .NotNull().WithMessage("Is necessary to inform the Departmentname Name.")
                .Must(ValidateProductName).WithMessage("Department name  must be greater than 2");


        }


        private bool ValidateProductName(string ProductName)
        {

            if (ProductName.Length < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
