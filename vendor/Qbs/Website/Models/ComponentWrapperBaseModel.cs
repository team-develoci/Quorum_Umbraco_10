namespace Umbraco10Project.vendor.Qbs.Website.Models;

public abstract class ComponentWrapperBaseModel
{
    public string WrapperComponentModifier { get; set; }

    public string ComponentView { get; set; }

    public IEnumerable<dynamic> ComponentModel { get; set; }

    public string ComponentModifier { get; set; }

    public object ComponentSettings { get; set; }
}