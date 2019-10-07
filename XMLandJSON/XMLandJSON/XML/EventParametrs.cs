using System;
using System.Collections.Generic;
using System.Text;

namespace XMLProject
{
  public class EventParametrs
  {
    public string dataSource { get; set; }
    public string eventSource { get; set; }
    public string dataId { get; set; }
    public string publicId { get; set; }
    public Description description { get; set; }
    public Origin origin { get; set; }
    public Magnitude magnitude { get; set; }
    public string preferredOriginID { get; set; }
    public string preferredMagnitudeID { get; set; }
    public string type { get; set; }
    public CreationInfo creationInfo { get; set; }
  }
}
