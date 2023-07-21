using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponId);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponByIdAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponByIdAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponByIdAsync(int id);
    }
}
