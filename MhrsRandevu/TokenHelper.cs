
using System.Text.Json;
using System;
using Microsoft.IdentityModel.Tokens;

namespace MhrsRandevu
{

    public class TokenHelper
    {
        
        public DateTime GetExpiryTimestamp(string accessToken)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(accessToken))
                    return DateTime.MinValue;
                if (!accessToken.Contains("."))
                    return DateTime.MinValue;

                string[] parts = accessToken.Split('.');
                JwtToken payload = JsonSerializer.Deserialize<JwtToken>(Base64UrlEncoder.Decode(parts[1]));
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(payload.exp);
                return dateTimeOffset.LocalDateTime;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
    }

    public class JwtToken
    {
        public long exp { get; set; }
    }

}
