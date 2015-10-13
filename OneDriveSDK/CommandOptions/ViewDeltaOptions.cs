using System;

namespace OneDrive
{
    public class ViewDeltaOptions : RequestOptions
    {
        internal const string ViewDeltaTokenKey = "token";
        
        public string StartingToken 
        {
            get { return ValueForQueryString(ViewDeltaTokenKey); }
            set { SetValueForQueryString(ViewDeltaTokenKey, value); }
        }

        public int? PageSize 
        {
            get { return ValueForQueryString(ApiConstants.PageSizeQueryParameterKey).ToNullableInt(); }
            set { SetValueForQueryString(ApiConstants.PageSizeQueryParameterKey, value.ToString()); }
        }

        public static ViewDeltaOptions Default
        {
            get { return new ViewDeltaOptions(); }
        }
    }
}
