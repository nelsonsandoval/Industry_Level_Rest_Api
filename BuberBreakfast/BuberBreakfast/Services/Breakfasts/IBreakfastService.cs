using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
    ErrorOr<Deleted> DeleteBreakfast(Guid guid);
    /*
BreakfastResponse GetBreakfast(Guid id);

BreakfastResponse UpdateBreakfast(Guid id, UpsertBreakfastRequest request);

BreakfastResponse DeleteBreakfast(Guid id);
*/
}