using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ProjectFont.AppCodes
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static void ClearObject(this ISession session, string key)
        {
            session.Remove(key);
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        /// <summary>
        /// Xóa toàn bộ dữ liệu trong session 
        /// </summary>
        /// <param name="session"></param>
        public static void ClearOldSession(this ISession session)
        {
            //session muốn xóa để ở đây
            session.Clear();            
        }
    }
}
