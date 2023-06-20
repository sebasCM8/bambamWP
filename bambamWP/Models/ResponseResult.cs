namespace bambamWP.Models
{
    public class ResponseResult
    {
        public bool ok { get; set; } = false;
        public string msg { get; set; } = "";

        public ResponseResult() { }

        public ResponseResult(bool theOk, string theMsg)
        {
            ok = theOk;
            msg = theMsg;
        }
    }
}
