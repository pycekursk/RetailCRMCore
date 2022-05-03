using System.ComponentModel;

namespace RetailCRMCore.Models
{
  public enum ContragentType
  {
    legal_entity,
    enterpreneur,
    individual,
    @default = 0,
  }

  public class LegalEntity
  {
    public string code { get; set; }
    public string vatRate { get; set; }
    public ContragentType contragentType { get; set; }
    public string legalName { get; set; }
    public string legalAddress { get; set; }
    public string INN { get; set; }
    public string OKPO { get; set; }
    public string KPP { get; set; }
    public string OGRN { get; set; }
    public string OGRNIP { get; set; }
    public string certificateNumber { get; set; }
    public string certificateDate { get; set; }
    public string BIK { get; set; }
    public string bank { get; set; }
    public string bankAddress { get; set; }
    public string corrAccount { get; set; }
    public string bankAccount { get; set; }
  }
}