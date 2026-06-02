 
public class Solution
{
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();

        foreach (var t in strs)
        {
            // escape backslash first, then comma
            var escaped = t.Replace("\\", "\\\\").Replace(",", "\\,");
            sb.Append(escaped);
            sb.Append(','); // separator
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var res = new List<string>();
        var cur = new StringBuilder();
        bool escaping = false;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (escaping)
            {
                // take character literally after '\'
                cur.Append(ch);
                escaping = false;
            }
            else
            {
                if (ch == '\\')
                {
                    escaping = true;
                }
                else if (ch == ',')
                {
                    // end of one token
                    res.Add(cur.ToString());
                    cur.Clear();
                }
                else
                {
                    cur.Append(ch);
                }
            }
        }

        // If the encoded string always ends with ',', loop already added the last item.
        // (If not, you could optionally add leftover here.)

        return res;
    }
}