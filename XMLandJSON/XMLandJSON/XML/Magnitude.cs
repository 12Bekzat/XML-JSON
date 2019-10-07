using System;
using System.Collections.Generic;
using System.Text;

namespace XMLProject
{
  public class Magnitude
  {
    public string dataSource { get; set; }
    public string eventSource { get; set; }
    public string dataId { get; set; }
    public string publicId { get; set; }
    public double mag { get; set; }
    public string type { get; set; }
    public string originId { get; set; }
    public string evaluationMode { get; set; }
    public CreationInfo creationInfo { get; set; }
  }
}
