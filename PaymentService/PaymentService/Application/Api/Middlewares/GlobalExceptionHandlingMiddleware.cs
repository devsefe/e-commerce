using DomainModel.UnitOfWork;
using System.Text.Json;

namespace Api.Middlewares
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        private readonly IUnitOfWork _unitOfWork;

        public GlobalExceptionHandlingMiddleware(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
                await _unitOfWork.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackTransactionAsync();

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 400;

                var responseDto = new
                {
                    error = new
                    {
                        status = 400,
                        message = ex.Message
                    }
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(responseDto));
            }
        }
    }
}
