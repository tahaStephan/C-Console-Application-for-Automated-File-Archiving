using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Teknoser_Log_Zipper.Models;
using System.Reflection.Emit;
using Teknoser_Log_Zipper;
using System.IO.Compression;
using System.IO;
using System;

internal class Program
{
    private static void Main(string[] args)
    {


        NorthWindOperation isim = new NorthWindOperation();
        isim.NorthwindHandler();

        string kaynakKlasorYolu = @"C:\Users\Name\Desktop\Log_Zipper\kaynak_klasor\"; // Dosyaların bulunduğu klasör yolu
        string hedefKlasorYolu = @"C:\Users\Name\Desktop\Log_Zipper\hedef_klasor\";   // Sıkıştırılmış dosyaların taşınacağı klasör yolu

        try
        {
            string[] dosyaYolları = Directory.GetFiles(kaynakKlasorYolu);
            string benzersizDosyaAdi = Guid.NewGuid().ToString() + ".zip";
            string hedefDosyaYolu = Path.Combine(hedefKlasorYolu, benzersizDosyaAdi);
            ZipFile.CreateFromDirectory(kaynakKlasorYolu, hedefDosyaYolu, CompressionLevel.SmallestSize, false);

            Console.WriteLine("Dosyalar sıkıştırıldı ve taşındı.");

            foreach (string dosyaYolu in dosyaYolları)
            {
                FileInfo fileInfo = new FileInfo(dosyaYolu);
                DateTime sonGuncellemeTarihi = fileInfo.LastWriteTime;
                DateTime simdikiZaman = DateTime.Now;
                TimeSpan fark = simdikiZaman - sonGuncellemeTarihi;

                if (fark.TotalMinutes >= 5)
                {
                    // Dosyayı zip dosyasına ekleyin
                    using (FileStream zipFileStream = new FileStream(hedefDosyaYolu, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipFileStream, ZipArchiveMode.Update))
                        {
                            string dosyaAdi = Path.GetFileName(dosyaYolu);
                            archive.CreateEntryFromFile(dosyaYolu, dosyaAdi);
                        }
                    }
                    // Dosyayı sil
                    File.Delete(dosyaYolu);
                }
                else
                {
                    Console.WriteLine($"{dosyaYolu} dosyası silinecek kadar eski değil.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata oluştu: " + ex.Message);
        }
    }
}