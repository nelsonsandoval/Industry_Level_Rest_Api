using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService{
    void CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid guid);
    /*
BreakfastResponse GetBreakfast(Guid id);

BreakfastResponse UpdateBreakfast(Guid id, UpsertBreakfastRequest request);

BreakfastResponse DeleteBreakfast(Guid id);
*/
}