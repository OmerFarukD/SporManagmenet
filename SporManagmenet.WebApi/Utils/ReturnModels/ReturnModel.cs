namespace SporManagmenet.WebApi.Utils.ReturnModels;

public sealed class ReturnModel<T>
{

    public string? Message { get; set; }

    public T? Data { get; set; }

    public bool Success { get; set; }
}
