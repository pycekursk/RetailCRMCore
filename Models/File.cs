namespace RetailCRMCore.Models
{
  public class File
  {

    /// <summary>
    /// Файл является изображением
    /// </summary>
    public string isImage { get; set; }

    /// <summary>
    /// Имя файла
    /// </summary>
    public string filename { get; set; }

    /// <summary>
    /// Оригинальное имя файла
    /// </summary>
    public string originalName { get; set; }

    /// <summary>
    /// MIME-тип файла
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime createdAt { get; set; }

    /// <summary>
    /// Размер файла в байтах
    /// </summary>
    public string size { get; set; }

  }
}