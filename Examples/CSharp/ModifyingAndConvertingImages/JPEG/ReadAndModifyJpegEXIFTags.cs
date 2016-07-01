﻿using System;
using System.Reflection;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadAndModifyJpegEXIFTags
    {
        public static void Run()
        {
            // ExStart:ReadAndModifyJpegEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            // Load an image using the factory method Load exposed by Image class
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an object of ExifData and fill it will image's EXIF information
                ExifData exif = ((JpegImage)image).ExifData;
                // Check if image has any EXIF entries defined
                if (exif != null)
                {
                    // In order to get all EXIF tags, first get the Type of EXIF object
                    Type type = exif.GetType();
                    //Get all properties of EXIF object into an array
                    PropertyInfo[] properties = type.GetProperties();
                    // Iterate over the EXIF properties
                    foreach (PropertyInfo property in properties)
                    {
                        // Display property name and its value
                        Console.WriteLine(property.Name + ":" + property.GetValue(exif, null));
                    }
                }
            }
            // ExEnd:ReadAndModifyJpegEXIFTags
        }
    }
}