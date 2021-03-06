using Data.URI.Enums;

using System;

namespace Data.URI.Extensions
{
    public static class DataUriExtensions
    {
        public static MediaTypeSection GetSection(this string sectionDescription)
        {
            MediaTypeSection? section = null;

            foreach (var value in (MediaTypeSection[])Enum.GetValues(typeof(MediaTypeSection)))
            {
                if (value.ToString() == sectionDescription.ToUpperInvariant())
                {
                    section = value;
                    break;
                }
            }

            if (section is null)
                throw new Exception($"Section '{sectionDescription}' is invalid.");

            return section ?? 0;
        }
        public static int GetTypeValue(this string typeDescription, MediaTypeSection section)
        {
            int typeValue = -1;
            typeDescription = typeDescription.ToUpperInvariant().ReplaceTokens(@"([\+\.\-])", "_");

            try
            {
                switch (section)
                {
                    case MediaTypeSection.APPLICATION:
                        {
                            MediaTypeApplication[] values = (MediaTypeApplication[])Enum.GetValues(typeof(MediaTypeApplication));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.AUDIO:
                        {
                            MediaTypeAudio[] values = (MediaTypeAudio[])Enum.GetValues(typeof(MediaTypeAudio));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.IMAGE:
                        {
                            MediaTypeImage[] values = (MediaTypeImage[])Enum.GetValues(typeof(MediaTypeImage));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.MESSAGE:
                        {
                            MediaTypeMessage[] values = (MediaTypeMessage[])Enum.GetValues(typeof(MediaTypeMessage));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.MODEL:
                        {
                            MediaTypeModel[] values = (MediaTypeModel[])Enum.GetValues(typeof(MediaTypeModel));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.MULTIPART:
                        {
                            MediaTypeMultipart[] values = (MediaTypeMultipart[])Enum.GetValues(typeof(MediaTypeMultipart));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.TEXT:
                        {
                            MediaTypeText[] values = (MediaTypeText[])Enum.GetValues(typeof(MediaTypeText));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    case MediaTypeSection.VIDEO:
                        {
                            MediaTypeVideo[] values = (MediaTypeVideo[])Enum.GetValues(typeof(MediaTypeVideo));
                            foreach (var type in values)
                            {
                                if (type.ToString() == typeDescription)
                                {
                                    typeValue = (int)type;
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }

            if (typeValue == -1)
                throw new Exception($"Type '{typeDescription}' does not exist in section '{section}'.");

            return typeValue;
        }
        public static Enum GetMediaType(this int type, MediaTypeSection section)
        {
            try
            {

                Enum sectionEnum = null;

                switch (section)
                {
                    case MediaTypeSection.APPLICATION:
                        sectionEnum = (MediaTypeApplication)type;
                        break;
                    case MediaTypeSection.AUDIO:
                        sectionEnum = (MediaTypeAudio)type;
                        break;
                    case MediaTypeSection.IMAGE:
                        sectionEnum = (MediaTypeImage)type;
                        break;
                    case MediaTypeSection.MESSAGE:
                        sectionEnum = (MediaTypeMessage)type;
                        break;
                    case MediaTypeSection.MODEL:
                        sectionEnum = (MediaTypeModel)type;
                        break;
                    case MediaTypeSection.MULTIPART:
                        sectionEnum = (MediaTypeMultipart)type;
                        break;
                    case MediaTypeSection.TEXT:
                        sectionEnum = (MediaTypeText)type;
                        break;
                    case MediaTypeSection.VIDEO:
                        sectionEnum = (MediaTypeVideo)type;
                        break;
                    default:
                        throw new Exception($"Section '{section}' does not contain type '{type}'");
                };

                return sectionEnum;
            }
            catch
            {
                throw new Exception($"Section '{section}' does not contain type '{type}'");
            }
        }
    }
}
