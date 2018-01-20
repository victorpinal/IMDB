Imports System.IO
Imports System.Text
Imports SevenZip

Public Class Compresor

    Shared Function CompressString(text As String) As Byte()
        Dim compressedData As Byte() = Nothing
        Dim compressor As New SevenZipCompressor()
        compressor.CompressionMethod = CompressionMethod.Ppmd
        compressor.CompressionLevel = CompressionLevel.Ultra
        compressor.ScanOnlyWritable = True
        compressor.DefaultItemName = "T"

        Dim utf8 As New UTF8Encoding()
        Using msin As New MemoryStream(utf8.GetBytes(text))
            Using msout As New MemoryStream()
                compressor.CompressStream(msin, msout)
                compressedData = msout.ToArray()
            End Using
        End Using
        Return compressedData
    End Function

    Shared Function DecompressString(compressedText As Byte()) As String
        Dim uncompressedbuffer As Byte() = Nothing
        Using compressedbuffer As New MemoryStream(compressedText)
            Try
                Using extractor As New SevenZipExtractor(compressedbuffer)
                    Using msout As New MemoryStream()
                        extractor.ExtractFile(0, msout)
                        uncompressedbuffer = msout.ToArray()
                    End Using
                End Using
            Catch e As Exception
                uncompressedbuffer = Encoding.UTF8.GetBytes(e.Message)
            End Try
        End Using
        Return Encoding.UTF8.GetString(uncompressedbuffer)
    End Function

End Class
