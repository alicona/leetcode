namespace _468.ValidateIPAddress;
public class Solution
{
    public string ValidIPAddress(string queryIP) {
        if(ProcessPossibleIpv4(queryIP)) return "IPv4";
        if(ProcessPossibleIpv6(queryIP)) return "IPv6";

        return "Neither";
    }

    private bool ProcessPossibleIpv4(string queryIP)
    {
        const int ipv4Length = 4;
        var numStrings = queryIP.Split('.');

        if(numStrings.Length != ipv4Length) return false;

        foreach(var p in numStrings)
        {
            if(p == String.Empty) return false;
            var total = 0;
            // stop processing if there is a leading zero.
            if(p[0] == '0' && p.Length > 1) return false;

            for(int i = 0;  i< p.Length; i++)
            {
                if(p[i] < '0' || p[i] > '9') return false;

                // Manually convert to number;
                total *= 10;
                total += p[i] - '0';
                if(total > 255) return false;
                Console.WriteLine(total);
            }
           
        }

        return true;
    }

    private bool ProcessPossibleIpv6(string queryIP)
    {
        const int ipv6Length = 8;
        var numStrings = queryIP.Split(':');

        if(numStrings.Length != ipv6Length) return false;

        foreach (var p in numStrings)
        {
            if(p == String.Empty) return false;
            if(p.Length > 4) return false;

            for (int i = 0; i < p.Length; i++)
            {
                var c = p[i];
                if( !((c >= '0' && c <= '9') || 
                    (c >= 'A' && c <= 'F') || 
                    (c >= 'a' && c <= 'f')))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
