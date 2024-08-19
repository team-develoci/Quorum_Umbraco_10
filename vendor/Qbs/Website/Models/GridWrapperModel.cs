namespace Umbraco10Project.vendor.Qbs.Website.Models;

public class GridWrapperModel : ComponentWrapperBaseModel
{
    public int? XSColumns { get; set; }

    public int? SColumns { get; set; }

    public int? MColumns { get; set; }

    public int? LColumns { get; set; }

    public string XSClass => XSColumns.HasValue ? ("col-xs-" + 12 / XSColumns) : "";

    public string SClass => SColumns.HasValue ? ("col-sm-" + 12 / SColumns) : "";

    public string MClass => MColumns.HasValue ? ("col-md-" + 12 / MColumns) : "";

    public string LClass => LColumns.HasValue ? ("col-lg-" + 12 / LColumns) : "";

    public string Classes => XSClass + " " + SClass + " " + MClass + " " + LClass;

    private IList<int> columnValues => (from i in new List<int?> { XSColumns, SColumns, MColumns, LColumns }
        where i.HasValue
        select i into s
        select s.Value).ToList();

    public int NumberOfItemsPerRows => (!columnValues.Any()) ? 1 : columnValues.Max();

    public int NumberOfRows => (base.ComponentModel != null) ? ((int)Math.Ceiling((double)base.ComponentModel.Count() / (double)NumberOfItemsPerRows)) : 0;

    public bool NoRowWrappers { get; set; }
}