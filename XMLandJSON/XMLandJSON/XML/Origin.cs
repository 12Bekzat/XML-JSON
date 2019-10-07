using System;
using System.Collections.Generic;
using System.Text;

namespace XMLProject
{
  public class Origin
  {
    public string dataSource { get; set; }
    public string eventSource { get; set; }
    public string dataId { get; set; }
    public string publicId { get; set; }
    public DateTime time { get; set; }
    public double longitude { get; set; }
    public double latitude { get; set; }
    public Depth depth { get; set; }
    public OriginUncertainty originUncertainty { get; set; }
    public Quality quality { get; set; }
    public string evaluationMode { get; set; }
    public CreationInfo creationInfo { get; set; }
  }
}
