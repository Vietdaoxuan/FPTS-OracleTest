using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Config
{
    public static class SessionTypes
    {
        /// <summary>
        /// Token để truy cập api.
        /// </summary>
        public const string TOKEN = "Token";
        public const string USERNAME = "Username";
        public const string TOKEN_EXPIRE_TIME = "TokenExpireTime";
        public const string ROLEGROUPS_OF_USER = "RoleGroupsOfUser";
        public const string PURCHASE_RIGHT_CODE = "PurchaseRightCode";

        public const string USER_LIST = "UserList";
        public const string USER_LIST_BY_GROUPCODE = "UserGroupList";
        public const string USERMAP_LIST = "UserMapList";
        public const string NHAN_SU_LIST = "NhanSuList";
        public const string CODONG_LIST = "CODONG_LIST";
        public const string CODONG_CHOT_LIST = "CODONG_CHOT_LIST";

        public const string MA_CD = "MACD";
    }
}
