namespace SegurancaPublicaApi.ViewModels
{
    public class OcorrenciaViewModel
{
    public int Id { get; set; }          
    public DateTime Data { get; set; }   
    public string Descricao { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
}


}
