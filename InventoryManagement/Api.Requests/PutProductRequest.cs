using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Api.Requests
{
    public class PutProductRequestProfile : Profile
	{
		public PutProductRequestProfile()
		{
			//CreateMap<PutProductRequest, Product>()
			//	.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
			//	.ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));
		}
	}

	public class PutProductRequest
	{
		[Required]
		[MinLength(2)]
		public string Name { get; set; }

		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }
	}
}