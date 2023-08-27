namespace QuanLySinhVien.WebApp.Commons
{
    public class ApiResult<T>
    {
        public int statusCode { get; set; }

        public string Message { get; set; }

        public T ResultObj { get; set; }
    }
}
