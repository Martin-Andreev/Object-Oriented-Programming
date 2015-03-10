namespace String_Disperser
{
    using System;
    using System.Collections;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>
    {
        public StringDisperser(params string[] inputParams)
        {
            this.InputParams = inputParams;
        }

        public string[] InputParams { get; set; }

        public override bool Equals(object param)
        {
            if (!(param is StringDisperser))
            {
                return false;
            }

            StringDisperser disperser = (StringDisperser)param;

            return this.InputParams.ToString().CompareTo(disperser.ToString()) == 0;
        }

        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return str1.Equals(str2);
        }

        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !str1.Equals(str2);
        }

        public override int GetHashCode()
        {
            var hashCode = 0;
            foreach (var str in this.InputParams)
            {
                hashCode ^= str.GetHashCode();
            }

            return hashCode;
        }

        public object Clone()
        {
            return new StringDisperser(this.InputParams.ToString());
        }

        public int CompareTo(StringDisperser str)
        {
            StringBuilder firstStr = new StringBuilder();
            foreach (var item in this.InputParams)
            {
                firstStr.Append(item);
            }

            StringBuilder otherStr = new StringBuilder();
            foreach (var item in str)
            {
                otherStr.Append(item);
            }

            return firstStr.ToString().CompareTo(otherStr.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.InputParams)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    yield return item[i];
                }   
            }
        }

        public override string ToString()
        {
            return string.Join(", ", InputParams);
        }
    }
}