using AutoMapper;
using CleanArchitecture.Application.dtos;
using CleanArchitecture.Domain.entities;

namespace CleanArchitecture.Application.mapper
{
	public class ProductProfile : Profile
	{
		ProductProfile()
		{
			CreateMap<CreateProductRequest, Product>();
			CreateMap<Product, ProductResponse>();
		}
	}
	
}
