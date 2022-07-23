namespace StudentRecordManagementSystem.Application.Common
{
    public class BaseResponse
    {
        public bool IsSuccess { get; }

        public BaseResponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
