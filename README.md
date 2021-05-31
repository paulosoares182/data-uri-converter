# ![](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) DataURI Converter

## Description
The idea of this project is to build a class library to work with the DataURI scheme in C#.

![](https://img.shields.io/static/v1?label=Status&message=Developing&color=blue&style=plastic)
![](https://img.shields.io/badge/c%23-%23239120.svg?style=plastic&logo=c-sharp&logoColor=white)

## 📝 Features

- [x] Convert DataURI to C# object.
- [ ] Convert DataURI to IMAGE file.
- [ ] Convert DataURI to AUDIO file.
- [ ] Convert DataURI to VIDEO file.
- [ ] Convert DataURI to IMAGE file.
- [ ] Convert DataURI to TEXT and PDF file.

### Prerequisites

Before you begin, you will need to have on your machine:
[.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) or [.NET Framework 4.7.2 ](https://dotnet.microsoft.com/download/dotnet-framework/net472). 
Also, it’s good to have an editor to work with the code like [VSCode](https://code.visualstudio.com/) or IDE [Visual Studio](https://visualstudio.microsoft.com/pt-br/vs/community/).

## 🛠️ Tools

The following tools were used in the construction of the project:

- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [C#](https://docs.microsoft.com/en-US/dotnet/csharp/)
- [Regular Expression](https://docs.microsoft.com/en-US/dotnet/standard/base-types/regular-expression-language-quick-reference/)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/vs/community/)

## DataURI sections and types

- **Image:** gif, jpeg, pjpeg, png, bmp, svg_xml, tiff, vnd_djvu, x_xcf.
- **Video:** avi, mpeg, mp4, ogg, quicktime, webm, x_matroska, x_ms_wmv, x_flv.
- **Audio:** basic, l24, mp4, mpeg, ogg, flac, opus, vorbis, vnd_rn_realaudio, vnd_wave, webm, x_aac, x_caf.
- **Text:** cmd, css, csv, html, markdown, javascript, plain, rtf, vcard, vnd_a, vnd_abc, xml, x_gwt_rpc, x_jquery_tmpl.
- **Message:** http, imdn_xml, partial, rfc822.
- **Model:** iges, mesh, vrml, x3d_binary, x3d_fastinfoset, x3d_vrml, x3d_xml.
- **Multipart:** mixed, alternative, related, form_data, signed, encrypted.
- **Application:** atom_xml, vnd_dart, ecmascript, edi_x12, edifact, json, javascript, octet_stream, ogg, dash_xml, pdf, postscript, rdf_xml, rss_xml, soap_xml, font_woff, xhtml_xml, xml, xml_dtd, xop_xml, zip, gzip, smil_xml, vnd_android_package_archive, vnd_debian_binary_package, vnd_google_earth_kml_xml, vnd_google_earth_kmz, vnd_mozilla_xul_xml, vnd_ms_excel, vnd_ms_powerpoint, vnd_ms_xpsdocument, vnd_oasis_opendocument_text, vnd_oasis_opendocument_spreadsheet, vnd_oasis_opendocument_presentation, vnd_oasis_opendocument_graphics, vnd_openxmlformats_officedocument_spreadsheetml_sheet, vnd_openxmlformats_officedocument_presentationml_presentation, vnd_openxmlformats_officedocument_wordprocessingml_document, x_7z_compressed, x_chrome_extension, x_dvi, x_font_ttf, x_javascript, x_latex, x_mpegurl, x_rar_compressed, x_shockwave_flash, x_stuffit, x_tar, x_www_form_urlencoded, x_xpinstall, x_nacl, x_pnacl, x_pkcs12.- 

## Usage

```cs
/* 
* .NET 5 Syntax
*/

public DataURI ConvertToDataURI(string strDataUri = "data:image/png;base64,iVBORw0KGgoAAAAN...")
{
    DataURI dataUri = new(strDataUri);
    return dataUri;
}

public DataURI ConvertToDataUri(string section = "image", string type = "png", string base64 = "iVBORw0KGgoAAAAN...")
{
    DataURI dataUri = new(section, type, base64);
    return dataUri;
}
```

```cs
/* 
* .NET Framework Syntax
*/

public DataURI ConvertToDataURI(string strDataUri = "data:image/png;base64,iVBORw0KGgoAAAAN...")
{
    DataURI dataUri = new DataURI(strDataUri);
    return dataUri;
}

public DataURI ConvertToDataUri(string section = "image", string type = "png", string base64 = "iVBORw0KGgoAAAAN...")
{
    DataURI dataUri = new DataURI(section, type, base64);
    return dataUri;
}
```

```cs
// DataURI Properties

public MediaTypeSection Section { get; private set; }
public int Type { get; private set; }
public string SectionDescription { get; private set; }
public string TypeDescription { get; private set; }
public byte[] Data { get; private set; }
```

## License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
