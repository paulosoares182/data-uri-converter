using Data.URI.Enums;
using Data.URI.Extensions;

using System;
using System.Collections.Generic;

namespace Data.URI
{
    public class DataURI
    {
        #region Properties

        public MediaTypeSection Section { get; private set; }
        public int Type { get; private set; }
        public string SectionDescription { get; private set; }
        public string TypeDescription { get; private set; }
        public byte[] Data { get; private set; }

        #endregion

        private readonly string _type;
        private readonly string _section;

        private readonly string _dataUriPattern = @"data:([a-zA-Z]+)\/([\W\w]+);base64,([\W\w]+)";

        /// <summary>
        /// Build DataURI by string.
        /// Syntax: data:[section]/[type];base64,[base64Data]
        /// </summary>
        /// <param name="strDataUri"></param>
        public DataURI(string strDataUri)
        {
            List<string> tokens = strDataUri.GetTokens(_dataUriPattern);

            if (tokens.Count != 3)
                throw new Exception("Invalid DataUri.");

            Section = tokens[0].GetSection();
            Type = tokens[1].GetTypeValue(Section);
            Data = Convert.FromBase64String(tokens[2]);
            SectionDescription = Section.ToString();
            TypeDescription = Type.GetMediaType(Section).ToString();

            _section = tokens[0];
            _type = tokens[1];
        }

        /// <summary>
        /// Build DataURI by section, type and data.
        /// Syntax: data:[section]/[type];base64,[base64Data]
        /// </summary>
        /// <param name="section"></param>
        /// <param name="type"></param>
        /// <param name="base64Data"></param>
        public DataURI(string section, string type, string base64Data)
        {
            Section = section.GetSection();
            Type = type.GetTypeValue(Section);
            Data = Convert.FromBase64String(base64Data);
            SectionDescription = Section.ToString();
            TypeDescription = Type.GetMediaType(Section).ToString();

            _section = section;
            _type = type;
        }

        /// <summary>
        /// Get 'data:[section]/[type];base64,[base64Data]'.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"data:{_section}/{_type};base64,{Convert.ToBase64String(Data)}";
        }
    }
}
