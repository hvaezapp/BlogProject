using BlogProject.Infrastructure.Enums;

namespace BlogProject.Application
{
    public class ApiResponseResult
    {
        public string message { get; set; }
        public ApiResponseStatus status { get; set; }
        public List<string> errors { get; set; } = new();
        public object data { get; set; }


        //.............

        public void Success(object value=null)
        {
            status = ApiResponseStatus.Success;
            message = nameof(ApiResponseStatus.Success);
            data = value;
            
        }



        public void Error(string error)
        {
            
            status = ApiResponseStatus.Error;
            message = nameof(ApiResponseStatus.Error);
            errors.Add(error);
        }



        public void ValidationError(List<string> validErrors)
        {
            status = ApiResponseStatus.ValidationError;
            message = nameof(ApiResponseStatus.ValidationError);
            errors.AddRange(validErrors);
        }


    }
}
