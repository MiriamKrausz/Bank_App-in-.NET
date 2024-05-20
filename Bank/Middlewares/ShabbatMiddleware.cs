namespace Bank.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var shabbat = false;
            if (shabbat)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            else
            {
                await _next(context);
            }
        }
    }
}
