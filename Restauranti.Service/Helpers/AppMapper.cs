using Mapster;

namespace Restauranti.Service.Helpers
{
    public class AppMapper
    {
        public static T Map<T>(object source) {
            return source.Adapt<T>();
        }

    }
}

