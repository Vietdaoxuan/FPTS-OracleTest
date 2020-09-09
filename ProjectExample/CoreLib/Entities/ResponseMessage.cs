using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class ResponseMessage
    {
        /// <summary>
        /// Gets or sets mã lỗi.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets nội dung.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets dữ liệu đi kèm.
        /// </summary>
        public object Data { get; set; }

        public ResponseMessage()
        {
        }

        public ResponseMessage(string code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
