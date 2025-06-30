using System.ComponentModel.DataAnnotations.Schema;
namespace Fuelled.ClientTracker.Models;

public class Document
{
    public int Id { get; set; }

    public string FileName { get; set; }

    public string ContentType { get; set; }

    public byte[] Data { get; set; }

    public Guid ClientId { get; set; }

    public ClientRecord Client { get; set; }


}