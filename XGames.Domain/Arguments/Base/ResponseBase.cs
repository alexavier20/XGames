namespace XGames.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = XGames.Domain.Resource.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }

        public string Message { get; set; }
    }
}
