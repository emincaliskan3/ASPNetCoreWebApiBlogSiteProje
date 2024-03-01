namespace ASPNetCoreWebApiBlogSiteProje.Tools
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile? formFile, string klasorYolu = "/wwwroot/Images/")
        {
            string dosyaAdi = "";

            if (formFile is not null)
            {
                dosyaAdi = formFile.FileName;
                string dizin = Directory.GetCurrentDirectory() + klasorYolu + dosyaAdi;
                using var stream = new FileStream(dizin, FileMode.Create);
                await formFile.CopyToAsync(stream);
            }

            return dosyaAdi;
        }
    }
}
