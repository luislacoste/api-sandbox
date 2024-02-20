
namespace Conciliac.Common.APIResponse
{
    public class APIResponseSimple<T> : APIResponse where T : new()
    {
        public APIResponseSimple()
        {
            Response = new T();
        }

        public T Response { get; set; }
    }
}
