using DITraining.Services.Interface;

namespace DITraining.Services.Service
{
    public class AddValueService : IAddValueService
    {
        public int Esfehan(int value)
        {
            return ((value * 10) / 100 + value);
        }

        public int Shiraz(int value)
        {
            return ((value * 15) / 100 + value);
        }

        public int Tehran(int value)
        {
            return ((value * 20) / 100 + value);
        }
    }
}
