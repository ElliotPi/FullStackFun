
namespace APIFun.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private FoodContext _foodcontext;
        public EFFoodRepository(FoodContext temp) {
            _foodcontext = temp;
        }
        public IEnumerable<MarriottFood> Foods => _foodcontext.Foods;
    }
}
